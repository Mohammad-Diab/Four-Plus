using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Four_Plus
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        bool EnterNumber = true;
        string number;
        bool game_over;
        int round_number;
        List<int> numbers = new List<int>();
        List<string> numbers_result = new List<string>();
        List<int> banned_numbers = new List<int>();
        List<int> OK_numbers = new List<int>();

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            NewGame();
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            if (!game_over)
            {
                if (EnterNumber)
                {
                    if (isValid(textBox.Text))
                    {
                        round_number++;
                        EnterNumber = false;
                        string result = CheckNumber(textBox.Text, number);
                        user_list.Items.Add(textBox.Text + "   " + (result == string.Empty ? "لا شيء" : result));
                        if (result == "++++")
                        {
                            game_over = true;
                            await new MessageDialog("Congratulations you won.", "Game over").ShowAsync();
                        }
                        else
                        {
                            string exp = GetExpecting(numbers, numbers_result, banned_numbers, OK_numbers);
                            if (exp != null)
                            {
                                await new MessageDialog(string.Format("I think your number is {0}", exp), string.Format("Round {0}:", round_number)).ShowAsync();
                                cpu_list.Items.Add(exp);
                            }
                            else
                            {
                                game_over = true;
                                await new MessageDialog("Your answers is wrong, Please give me right result next time.", "Game over").ShowAsync();
                            }
                        }
                    }
                    else
                        await new MessageDialog("Invalid input try again.", "Invalid input").ShowAsync();
                }
                else
                {
                    if (CheckUserResult(textBox.Text))
                    {
                        EnterNumber = true;
                        numbers_result.Add(textBox.Text);
                        cpu_list.Items.RemoveAt(cpu_list.Items.Count - 1);
                        cpu_list.Items.Add(numbers[numbers.Count - 1] + "   " + (textBox.Text == string.Empty ? "لا شيء" : textBox.Text));
                        if (textBox.Text.Equals("++++"))
                        {
                            await new MessageDialog("I won.\nYou are a loser 😜.", "Game over").ShowAsync();
                            game_over = true;
                        }
                    }
                    else
                        await new MessageDialog("Invalid input try again.", "Invalid input").ShowAsync();
                }
                textBox.Text = string.Empty;
                SetInputState();
            }
            else
                await new MessageDialog("the game is over, start new game to begain.", "Game over").ShowAsync();
        }

        private void NewGame()
        {
            number = GetNumber();
            game_over = false;
            EnterNumber = true;
            round_number = 0;
            numbers = new List<int>();
            numbers_result = new List<string>();
            banned_numbers = new List<int>();
            OK_numbers = new List<int>();
            user_list.Items.Clear();
            cpu_list.Items.Clear();
            textBox.Text = string.Empty;
            SetInputState();
        }

        private string GetNumber()
        {
            Random rand = new Random((int)(DateTime.Now.Ticks - 635839051000005200));
            int[] nums_array = new int[4];
            for (int i = 0; i < 4; i++)
            {
                nums_array[i] = rand.Next(1, 10);
                for (int j = i - 1; j >= 0; j--)
                    if (nums_array[i] == nums_array[j])
                        i--;
            }
            return string.Empty + nums_array[3] + nums_array[0] + nums_array[1] + nums_array[2];
        }

        private bool isValid(string number)
        {
            if (number.Length != 4)
                return false;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] > '0' && number[i] < ':')
                {
                    for (int j = i + 1; j < number.Length; j++)
                        if (number[i] == number[j])
                            return false;
                }
                else
                    return false;
            }
            return true;
        }

        private string CheckNumber(string first, string second)
        {
            string result = string.Empty;
            if (first.Length == second.Length)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    if (first[i] == second[i])
                        result += "+";
                    else
                    {
                        for (int j = 0; j < second.Length; j++)
                            if (first[i] == second[j])
                                result += ">";//➡
                    }
                }
            }
            return result;
        }

        private string GetExpecting(List<int> numbers, List<string> numbers_result, List<int> banned_numbers, List<int> OK_Number)
        {
            //remove numbers
            if (numbers.Count == 1)
            {
                if (numbers_result[0].Length == 4)
                {
                    for (int i = 1; i < 10; i++)
                        if (!numbers[0].ToString().Contains(i.ToString()))
                            banned_numbers.Add(i);
                        else
                            OK_Number.Add(i);
                }
                else if (numbers_result[0] == string.Empty)
                    for (int i = 0; i < numbers[0].ToString().Length; i++)
                        banned_numbers.Add(int.Parse((numbers[0].ToString())[i].ToString()));
                else
                {
                    string num = string.Empty;
                    for (int i = 1; i < 10; i++)
                        if ((!numbers[0].ToString().Contains(i.ToString())))
                        {
                            if (num.Length == 4)
                                break;
                            num += i;
                        }
                    numbers.Add(int.Parse(num));
                    return num;
                }
            }
            else if (numbers.Count == 2)
            {
                if ((numbers_result[1] + numbers_result[0]).Length == 3)
                {
                    for (int i = 1; i < 10; i++)
                    {
                        if (!(numbers[1].ToString() + numbers[0].ToString()).Contains(i.ToString()))
                        {
                            OK_Number.Add(i);
                            break;
                        }
                    }
                }
                if (numbers_result[1].Length == 4)
                {
                    for (int i = 1; i < 10; i++)
                        if (!numbers[1].ToString().Contains(i.ToString()))
                            banned_numbers.Add(i);
                        else
                            OK_Number.Add(i);
                }
                else if (numbers_result[1] == string.Empty)
                    for (int i = 0; i < numbers[1].ToString().Length; i++)
                        banned_numbers.Add(int.Parse((numbers[1].ToString())[i].ToString()));
            }

            List<int> possible_number = new List<int>();
            for (int i = 1234; i <= 9876; i++)
            {
                bool cont = false;
                var number = i.ToString();
                for (int k = 0; k < banned_numbers.Count; k++)
                    if (number.Contains(banned_numbers[k].ToString()))
                    {
                        cont = true;
                        break;
                    }
                for (int k = 0; k < OK_Number.Count; k++)
                    if (!number.Contains(OK_Number[k].ToString()))
                    {
                        cont = true;
                        break;
                    }
                if (cont)
                    continue;
                if (isValid(number))
                {
                    bool acc = true;
                    for (int j = 0; j < numbers.Count; j++)
                    {
                        if (new string(CheckNumber(number, numbers[j].ToString()).OrderBy(c => c).ToArray()) != new string(numbers_result[j].OrderBy(c => c).ToArray()))
                        {
                            acc = false;
                            break;
                        }
                    }
                    if (acc)
                        possible_number.Add(i);
                }
            }
            Random rand = new Random((int)(DateTime.Now.Ticks - 635839051001005010));
            if (possible_number.Count > 0)
            {
                int random = rand.Next(0, possible_number.Count);
                numbers.Add(possible_number[random]);
                return possible_number[random].ToString();
            }
            else
                return null;
        }

        private bool CheckUserResult(string user_result)
        {
            byte p_count = 0, a_count = 0;
            if (user_result.Length > 4)
                return false;
            for (int i = 0; i < user_result.Length; i++)
            {
                if (user_result[i] != '+' && user_result[i] != '>')
                    return false;
                else
                {
                    if (user_result[i] == '+')
                        p_count++;
                    else if (user_result[i] == '>')
                        a_count++;
                }
            }
            if ((p_count == 3) && (a_count == 1))
                return false;
            return true;
        }

        private void SetInputState()
        {
            if (EnterNumber || game_over)
            {
                textBlock1.Text = "أدخل تخمينك (4 أرقام)";
                textBox.PlaceholderText = "مثال: 1234";
            }
            else
            {
                textBlock1.Text = string.Format("أدخل تلميحك لتخمين الكمبيوتر {0} (+ و >)", numbers[numbers.Count - 1]);
                textBox.PlaceholderText = "مثال: ++> أو اتركه فارغاً إذا لم يصب أي رقم";
            }
        }



        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            NewGame();
        }

        private async void AppBarButton_Click_1(object sender, RoutedEventArgs e)
        {
            if (!game_over)
            {
                game_over = true;
                SetInputState();
                await new MessageDialog(string.Format("انسحبت. رقمي كان {0}", number), "انسحاب").ShowAsync();
            }
        }

        private async void AppBarButton_Click_2(object sender, RoutedEventArgs e)
        {
            await new MessageDialog("تصميم وبرمجة: محمد دياب\n2015", "Four Plus").ShowAsync();
        }
    }
}
