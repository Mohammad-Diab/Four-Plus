using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Four_Plus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Multiplayer_Click(object sender, RoutedEventArgs e)
        {
            AnimateMenuMultiPlayer();

        }

        private void AnimateMenuMultiPlayer()
        {
            ThicknessAnimation ta1 = new ThicknessAnimation(new Thickness(-180, 0, 0, 196), new Duration(new TimeSpan(750000)));
            ta1.Completed += (object sender, EventArgs e) =>
            {
                ThicknessAnimation ta2 = new ThicknessAnimation(new Thickness(-180, 0, 0, 157), new Duration(new TimeSpan(750000)));
                ta2.Completed += (object sender2, EventArgs e2) =>
                {
                    ThicknessAnimation ta3 = new ThicknessAnimation(new Thickness(-180, 0, 0, 118), new Duration(new TimeSpan(750000)));
                    ta3.Completed += (object sender3, EventArgs e3) =>
                    {
                        ThicknessAnimation ta4 = new ThicknessAnimation(new Thickness(-180, 0, 0, 79), new Duration(new TimeSpan(750000)));
                        ta4.Completed += (object sender4, EventArgs e4) =>
                        {
                            ThicknessAnimation ta5 = new ThicknessAnimation(new Thickness(-180, 0, 0, 40), new Duration(new TimeSpan(750000)));
                            ta5.Completed += (object sender5, EventArgs e5) =>
                            {
                                m_p_intenet.Visibility = Visibility.Visible;
                                m_p_local.Visibility = Visibility.Visible;
                                m_p_lan.Visibility = Visibility.Visible;
                                m_p_back.Visibility = Visibility.Visible;
                                ThicknessAnimation ta6 = new ThicknessAnimation(new Thickness(180, 0, 0, 157), new Duration(new TimeSpan(750000)));
                                ta6.Completed += (object sender6, EventArgs e6) =>
                                {
                                    ThicknessAnimation ta7 = new ThicknessAnimation(new Thickness(180, 0, 0, 118), new Duration(new TimeSpan(750000)));
                                    ta7.Completed += (object sender7, EventArgs e7) =>
                                    {
                                        ThicknessAnimation ta8 = new ThicknessAnimation(new Thickness(180, 0, 0, 79), new Duration(new TimeSpan(750000)));
                                        ta8.Completed += (object sender8, EventArgs e8) =>
                                        {
                                            ThicknessAnimation ta9 = new ThicknessAnimation(new Thickness(180, 0, 0, 40), new Duration(new TimeSpan(750000)));
                                            ta9.Completed += (object sender9, EventArgs e9) =>
                                            {
                                                s_p.Visibility = Visibility.Hidden;
                                                m_p.Visibility = Visibility.Hidden;
                                                options.Visibility = Visibility.Hidden;
                                                about.Visibility = Visibility.Hidden;
                                                exit.Visibility = Visibility.Hidden;
                                            };
                                            m_p_back.BeginAnimation(MarginProperty, ta9);
                                        };
                                        m_p_intenet.BeginAnimation(MarginProperty, ta8);
                                    };
                                    m_p_lan.BeginAnimation(MarginProperty, ta7);
                                };
                                m_p_local.BeginAnimation(MarginProperty, ta6);
                            };
                            exit.BeginAnimation(MarginProperty, ta5);
                        };
                        about.BeginAnimation(MarginProperty, ta4);
                    };
                    options.BeginAnimation(MarginProperty, ta3);
                };
                m_p.BeginAnimation(MarginProperty, ta2);
            };
            s_p.BeginAnimation(MarginProperty, ta1);
        }

        private void m_p_back_Click(object sender, RoutedEventArgs e)
        {
            AnimateMenuBack();
        }

        private void AnimateMenuBack()
        {
            s_p.Visibility = Visibility.Visible;
            m_p.Visibility = Visibility.Visible;
            options.Visibility = Visibility.Visible;
            about.Visibility = Visibility.Visible;
            exit.Visibility = Visibility.Visible;
            ThicknessAnimation ta0 = new ThicknessAnimation(new Thickness(550, 0, 0, 40), new Duration(new TimeSpan(750000)));
            ta0.Completed += (object sender, EventArgs e) =>
            {
                ThicknessAnimation ta1 = new ThicknessAnimation(new Thickness(550, 0, 0, 79), new Duration(new TimeSpan(750000)));
                ta1.Completed += (object sender1, EventArgs e1) =>
                {
                    ThicknessAnimation ta2 = new ThicknessAnimation(new Thickness(550, 0, 0, 118), new Duration(new TimeSpan(750000)));
                    ta2.Completed += (object sender2, EventArgs e2) =>
                    {
                        ThicknessAnimation ta3 = new ThicknessAnimation(new Thickness(550, 0, 0, 157), new Duration(new TimeSpan(750000)));
                        ta3.Completed += (object sender3, EventArgs e3) =>
                        {
                            m_p_intenet.Visibility = Visibility.Hidden;
                            m_p_local.Visibility = Visibility.Hidden;
                            m_p_lan.Visibility = Visibility.Hidden;
                            m_p_back.Visibility = Visibility.Hidden;
                            ThicknessAnimation ta4 = new ThicknessAnimation(new Thickness(180, 0, 0, 40), new Duration(new TimeSpan(750000)));
                            ta4.Completed += (object sender4, EventArgs e4) =>
                            {
                                ThicknessAnimation ta5 = new ThicknessAnimation(new Thickness(180, 0, 0, 79), new Duration(new TimeSpan(750000)));
                                ta5.Completed += (object sender5, EventArgs e5) =>
                                {

                                    ThicknessAnimation ta6 = new ThicknessAnimation(new Thickness(180, 0, 0, 118), new Duration(new TimeSpan(750000)));
                                    ta6.Completed += (object sender6, EventArgs e6) =>
                                    {
                                        ThicknessAnimation ta7 = new ThicknessAnimation(new Thickness(180, 0, 0, 157), new Duration(new TimeSpan(750000)));
                                        ta7.Completed += (object sender7, EventArgs e7) =>
                                        { s_p.BeginAnimation(MarginProperty, new ThicknessAnimation(new Thickness(180, 0, 0, 196), new Duration(new TimeSpan(750000)))); };
                                        m_p.BeginAnimation(MarginProperty, ta7);
                                    };
                                    options.BeginAnimation(MarginProperty, ta6);
                                };
                                about.BeginAnimation(MarginProperty, ta5);
                            };
                            exit.BeginAnimation(MarginProperty, ta4);
                        };
                        m_p_local.BeginAnimation(MarginProperty, ta3);
                    };
                    m_p_lan.BeginAnimation(MarginProperty, ta2);
                };
                m_p_intenet.BeginAnimation(MarginProperty, ta1);
            };
            m_p_back.BeginAnimation(MarginProperty, ta0);
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello Human", "Four Plus", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Options_Click(object sender, RoutedEventArgs e)
        {
            ThicknessAnimation m = new ThicknessAnimation(new Thickness(-550, -400, 0, 0), new Duration(new TimeSpan(1500000)));
            grid_mother.BeginAnimation(MarginProperty, m);
        }

        private void OptionsBack_Click(object sender, RoutedEventArgs e)
        {
            ThicknessAnimation m = new ThicknessAnimation(new Thickness(0, -400, -550, 0), new Duration(new TimeSpan(1500000)));
            grid_mother.BeginAnimation(MarginProperty, m);
        }

        private void SP_Click(object sender, RoutedEventArgs e)
        {
            SinglePlayerAnimation();
            //StartSingleGame();
        }

        private void SinglePlayerAnimation()
        {
            ThicknessAnimation ta1 = new ThicknessAnimation(new Thickness(180, 0, 0, 546), new Duration(new TimeSpan(750000)));
            ta1.Completed += (object sender, EventArgs e) =>
            {
                ThicknessAnimation ta2 = new ThicknessAnimation(new Thickness(180, 0, 0, 507), new Duration(new TimeSpan(750000)));
                ta2.Completed += (object sender2, EventArgs e2) =>
                {
                    ThicknessAnimation ta3 = new ThicknessAnimation(new Thickness(180, 0, 0, 468), new Duration(new TimeSpan(750000)));
                    ta3.Completed += (object sender3, EventArgs e3) =>
                    {
                        ThicknessAnimation ta4 = new ThicknessAnimation(new Thickness(180, 0, 0, 429), new Duration(new TimeSpan(750000)));
                        ta4.Completed += (object sender4, EventArgs e4) =>
                        {
                            ThicknessAnimation ta5 = new ThicknessAnimation(new Thickness(180, 0, 0, 390), new Duration(new TimeSpan(750000)));
                            ta5.Completed += (object sender5, EventArgs e5) =>
                            {
                                //ThicknessAnimation ta6 = new ThicknessAnimation(new Thickness(180, 0, 0, -35), new Duration(new TimeSpan(750000)));
                                //ThicknessAnimation ta7 = new ThicknessAnimation(new Thickness(180, 0, 0, -74), new Duration(new TimeSpan(750000)));
                                //ThicknessAnimation ta8 = new ThicknessAnimation(new Thickness(180, 0, 0, -113), new Duration(new TimeSpan(750000)));
                                //ThicknessAnimation ta9 = new ThicknessAnimation(new Thickness(180, 0, 0, -152), new Duration(new TimeSpan(750000)));
                                //ThicknessAnimation ta10 = new ThicknessAnimation(new Thickness(180, 0, 0, -191), new Duration(new TimeSpan(750000)));
                                ThicknessAnimation ta11 = new ThicknessAnimation(new Thickness(0, 0, -550, -400), new Duration(new TimeSpan(2000000)));
                                ta11.Completed += (object sender6, EventArgs e6) =>
                                 {
                                     ShowMessage("Hello human!", 0, Brushes.ForestGreen);
                                     //info_grid.Opacity = 0;
                                     //info_grid.Visibility = Visibility.Visible;
                                     //info_grid.BeginAnimation(OpacityProperty, new DoubleAnimation(1, new Duration(new TimeSpan(2000000))));

                                     exit.BeginAnimation(MarginProperty, new ThicknessAnimation(new Thickness(180, 0, 0, 40), new Duration(new TimeSpan(10))));
                                     about.BeginAnimation(MarginProperty, new ThicknessAnimation(new Thickness(180, 0, 0, 79), new Duration(new TimeSpan(10))));
                                     options.BeginAnimation(MarginProperty, new ThicknessAnimation(new Thickness(180, 0, 0, 118), new Duration(new TimeSpan(10))));
                                     m_p.BeginAnimation(MarginProperty, new ThicknessAnimation(new Thickness(180, 0, 0, 157), new Duration(new TimeSpan(10))));
                                     s_p.BeginAnimation(MarginProperty, new ThicknessAnimation(new Thickness(180, 0, 0, 196), new Duration(new TimeSpan(10))));

                                     stack_info.Height = info_text1.ActualHeight;

                                     BackgroundWorker b1 = new BackgroundWorker();
                                     b1.DoWork += (object sender7, DoWorkEventArgs e7) => { Thread.Sleep(2000); };
                                     b1.RunWorkerCompleted += (object sender8, RunWorkerCompletedEventArgs e8) =>
                                     {
                                         DoubleAnimation da1 = new DoubleAnimation(info_text1.ActualHeight, 0, new Duration(new TimeSpan(2000000)));
                                         info_text1.BeginAnimation(HeightProperty, da1);

                                         BackgroundWorker b2 = new BackgroundWorker();
                                         b2.DoWork += (object sender9, DoWorkEventArgs e9) => { Thread.Sleep(2000); };
                                         b2.RunWorkerCompleted += (object sender10, RunWorkerCompletedEventArgs e10) =>
                                         {
                                             DoubleAnimation da2 = new DoubleAnimation(info_text2.ActualHeight, 0, new Duration(new TimeSpan(2000000)));
                                             info_text2.BeginAnimation(HeightProperty, da2);

                                             BackgroundWorker b3 = new BackgroundWorker();
                                             b3.DoWork += (object sender9, DoWorkEventArgs e9) => { Thread.Sleep(2000); };
                                             b3.RunWorkerCompleted += (object sender11, RunWorkerCompletedEventArgs e11) =>
                                             {
                                                 DoubleAnimation da = new DoubleAnimation(0, new Duration(new TimeSpan(2000000)));
                                                 da.Completed += (object sender12, EventArgs e12) =>
                                                 {
                                                     info_grid.Visibility = Visibility.Hidden;
                                                     info_grid.Opacity = 1;
                                                 };
                                                 info_grid.BeginAnimation(OpacityProperty, da);
                                                 button1_Click(null, null);
                                             };
                                             b3.RunWorkerAsync();
                                         };
                                         b2.RunWorkerAsync();

                                     };
                                     b1.RunWorkerAsync();

                                     //exit.Margin = new Thickness(180, 0, 0, 40);
                                     //about.Margin = new Thickness(180, 0, 0, 40);
                                     //options.Margin = new Thickness(180, 0, 0, 40);
                                     //m_p.Margin = new Thickness(180, 0, 0, 40);
                                     //s_p.Margin = new Thickness(180, 0, 0, 40);
                                 };
                                //exit.BeginAnimation(MarginProperty, ta6);
                                //about.BeginAnimation(MarginProperty, ta7);
                                //options.BeginAnimation(MarginProperty, ta8);
                                //m_p.BeginAnimation(MarginProperty, ta9);
                                //s_p.BeginAnimation(MarginProperty, ta10);
                                grid_mother.BeginAnimation(MarginProperty, ta11);
                            };
                            exit.BeginAnimation(MarginProperty, ta5);
                        };
                        about.BeginAnimation(MarginProperty, ta4);
                    };
                    options.BeginAnimation(MarginProperty, ta3);
                };
                m_p.BeginAnimation(MarginProperty, ta2);
            };
            s_p.BeginAnimation(MarginProperty, ta1);
        }



        #region NEW GAME CREATION

        private void StartSingleGame()
        {
            stack_info.Height = info_text1.ActualHeight;

            BackgroundWorker b1 = new BackgroundWorker();
            b1.DoWork += (object sender, DoWorkEventArgs e) => { Thread.Sleep(2000); };
            b1.RunWorkerCompleted += (object sender, RunWorkerCompletedEventArgs e) =>
            { info_text1.BeginAnimation(HeightProperty, new DoubleAnimation(info_text1.ActualHeight, 0, new Duration(new TimeSpan(1000000)))); };
            b1.RunWorkerAsync();
        }

        #endregion

        #region Single Player

        private void GetNumber(out string number)
        {
            Random rand = new Random((int)(DateTime.Now.Ticks - 635839051002000200));
            int[] nums_array = new int[4];
            for (int i = 0; i < 4; i++)
            {
                nums_array[i] = rand.Next(1, 10);
                for (int j = i - 1; j >= 0; j--)
                    if (nums_array[i] == nums_array[j])
                        i--;
            }
            number = string.Empty + nums_array[3] + nums_array[0] + nums_array[1] + nums_array[2];
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
                        banned_numbers.Add(i);
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
                        if (CheckNumber(number, numbers[j].ToString()) != numbers_result[j])
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

        private void EnterNumber()
        {
            if (!game_over)
            {
                if (is_number_or_result)
                {
                    if (!isValid(player_number_text.Text))
                    {
                        //MessageBox.Show("حط رقم مثل العالم والناس احسن ما اجي...");
                        ShowMessage("Please enter a valid four digits number.", 1, Brushes.Orange);
                        player_number_text.Clear();
                        player_number_text.Focus();
                    }
                    else
                    {
                        player_list.Items.Add(player_number_text.Text);
                        string result = CheckNumber(player_number_text.Text, computer_number);
                        player_list.Items.Add(result == string.Empty ? "NO THING" : result);

                        player_list.SelectedIndex = player_list.Items.Count - 1;
                        player_list.ScrollIntoView(player_list.SelectedItem);

                        player_number_text.Clear();
                        if (player_list.Items[player_list.Items.Count - 1].Equals("++++"))
                        {
                            //MessageBox.Show("انا كنت متساهل معك لهيك فزت, تجرب مرة ثانية؟", "خلصت اللعبة", MessageBoxButton.YesNo, MessageBoxImage.Question);
                            ShowMessage("Congratulations you won, Play again?", 2, Brushes.Green);
                            player_win++;
                            game_over = true;
                            player_win_count.Text = player_win + (player_win == 1 ? " win" : " wins");
                        }
                        else
                        {
                            string cpu_guess = GetExpecting(numbers, numbers_result, banned_numbers, OK_Number);
                            if (cpu_guess != null)
                            {
                                cpu_list.Items.Add(cpu_guess);

                                cpu_list.SelectedIndex = cpu_list.Items.Count - 1;
                                cpu_list.ScrollIntoView(cpu_list.SelectedItem);

                                player_result_text.Focus();
                                is_number_or_result = false;
                            }
                            else
                            {
                                ShowMessage("Some of your hints is invalid so the game is over, Do you want to play again?", 2, Brushes.OrangeRed);
                                //MessageBox.Show("بتلعب بدون كذب ولا بحذفلك ملفاتك");
                                game_over = true;
                            }
                        }
                    }
                }
                else
                {
                    ShowMessage("Give me a hint for my guess first.", 1, Brushes.Orange);
                    //MessageBox.Show("يا غبي عطيني جواب رقمي بالاول");
                    player_result_text.Focus();
                }
            }
        }

        private void EnterResult()
        {
            if (!game_over)
            {
                if (!is_number_or_result)
                {
                    if (!CheckUserResult(player_result_text.Text))
                    {
                        //MessageBox.Show("حاج تخبيص");
                        ShowMessage("Invalid hint, please try again.", 1, Brushes.Orange);
                        player_result_text.Clear();
                    }
                    else
                    {
                        cpu_list.Items.Add(player_result_text.Text == string.Empty ? "NO THING" : player_result_text.Text);

                        cpu_list.SelectedIndex = cpu_list.Items.Count - 1;
                        cpu_list.ScrollIntoView(cpu_list.SelectedItem);

                        numbers_result.Add(player_result_text.Text);
                        player_result_text.Clear();
                        player_number_text.Focus();
                        is_number_or_result = true;
                        if (numbers_result[numbers_result.Count - 1].Equals("++++"))
                        {
                            ShowMessage("Unfortunately you lose, play again?", 2, Brushes.IndianRed);
                            cpu_win++;
                            cpu_win_count.Text = cpu_win + (cpu_win == 1 ? " win" : " wins");
                            game_over = true;
                        }
                    }
                }
                else
                {
                    ShowMessage("It's your turn, give me a number.", 1, Brushes.BlueViolet);
                    //MessageBox.Show("يا غشيم صار دورك هات شي رقم.");
                    player_number_text.Focus();
                }
            }
        }

        #endregion

        string computer_number;
        bool human_turn;
        int current_battle_number = 0, cpu_win = 0, player_win = 0;
        List<string> numbers_result;
        List<int> numbers, banned_numbers, OK_Number;
        bool is_number_or_result, game_over = false;

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //info_grid.Visibility = Visibility.Hidden;
            current_battle_number++;
            info_round_number.Text = battle_number.Text = current_battle_number.ToString();
            if (current_battle_number > 1)
            {
                BackgroundWorker b1 = new BackgroundWorker();
                b1.DoWork += (object s1, DoWorkEventArgs e1) => { Thread.Sleep(500); };
                b1.RunWorkerCompleted += (object s1, RunWorkerCompletedEventArgs e1) => { ShowMessage(null, 0, Brushes.ForestGreen); };
                b1.RunWorkerAsync();
            }
            numbers = new List<int>();
            numbers_result = new List<string>();
            banned_numbers = new List<int>();
            OK_Number = new List<int>();
            human_turn = current_battle_number % 2 == 1;
            GetNumber(out computer_number);
            player_list.Items.Clear();
            cpu_list.Items.Clear();
            game_over = false;
            if (!human_turn)
            {
                string cpu_guess = GetExpecting(numbers, numbers_result, banned_numbers, OK_Number);
                cpu_list.Items.Add(cpu_guess);
                is_number_or_result = false;
            }
            else
                is_number_or_result = true;
        }

        private void player_number_text_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (player_number_text.Text == string.Empty)
                number_placeholder.Visibility = Visibility.Visible;
            else
                number_placeholder.Visibility = Visibility.Hidden;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ShowMessage("My number is: \"" + (game_over ? computer_number : "????") + "\"", 1, game_over ? Brushes.RoyalBlue : Brushes.Red);
            //if (game_over)
            //    ShowMessage(computer_number, 1);
            //else
            //    ShowMessage("????", 1);
        }

        private void NumberSingButton_Click(object sender, RoutedEventArgs e)
        {
            if (!game_over)
            {
                Button b = (Button)sender;
                TextBox t = b.Content.ToString()[0] < '1' || b.Content.ToString()[0] > '9' ? player_result_text : player_number_text;
                string text = t.Text;
                int index = t.CaretIndex + 1;
                t.Text = t.Text.Substring(0, t.CaretIndex) + b.Content + t.Text.Substring(t.CaretIndex);
                t.CaretIndex = index;
                t.Focus();
            }
        }

        private void EnterNumberButton_Click(object sender, RoutedEventArgs e)
        {
            EnterNumber();
        }

        private void EnterResultButton_Click(object sender, RoutedEventArgs e)
        {
            EnterResult();
        }

        private void player_result_text_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (player_result_text.Text == string.Empty)
                result_placeholder.Visibility = Visibility.Visible;
            else
                result_placeholder.Visibility = Visibility.Hidden;
        }

        private void OK_Button_Click(object sender, RoutedEventArgs e)
        {
            if(((Button)sender).Content.Equals("YES"))
            {
                button1_Click(null, null);
            }
            else if(((Button)sender).Content.Equals("NO"))
            {

            }
            DoubleAnimation da = new DoubleAnimation(0, new Duration(new TimeSpan(2000000)));
            da.Completed += (object sender12, EventArgs e12) =>
            {
                info_grid.Visibility = Visibility.Hidden;
                info_grid.Opacity = 1;
            };
            info_grid.BeginAnimation(OpacityProperty, da);
        }

        private void BackspaceButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox textbox = ((Button)sender).Name == "number_backspace" ? player_number_text : player_result_text;
            if (textbox.CaretIndex > 0)
            {
                int index = textbox.CaretIndex;
                textbox.Text = textbox.Text.Substring(0, textbox.CaretIndex - 1) + (textbox.CaretIndex == textbox.Text.Length ? "" : textbox.Text.Substring(textbox.CaretIndex, textbox.Text.Length - textbox.CaretIndex)) /*+ textbox.Text.Substring(textbox.CaretIndex, textbox.Text.Length - textbox.CaretIndex + 1)*/;
                textbox.CaretIndex = index - 1;
            }
            textbox.Focus();
        }

        private void PauseGame_Click(object sender, RoutedEventArgs e)
        {
            pause_grid.Visibility = Visibility.Visible;
            pause_stack.BeginAnimation(MarginProperty, new ThicknessAnimation(new Thickness(15, game_over ? 123 : 140, 0, 0), new Thickness(215, game_over ? 123 : 140, 0, 0), new Duration(new TimeSpan(1000000))));
            resume_game.Content = game_over ? "Back" : "Resume";
            new_game.Visibility = game_over ? Visibility.Visible : Visibility.Collapsed;
        }

        private void ResumeGame_Click(object sender, RoutedEventArgs e)
        {
            ThicknessAnimation ta = new ThicknessAnimation(new Thickness(215, game_over ? 123 : 140, 0, 0), new Thickness(15, game_over ? 123 : 140, 0, 0), new Duration(new TimeSpan(1000000)));
            ta.Completed += (object s1, EventArgs e1) => {
                pause_grid.Visibility = Visibility.Hidden;
                if (((Button)sender).Content.Equals("New game"))
                    button1_Click(null, null);
            };
            pause_stack.BeginAnimation(MarginProperty, ta);
        }

        private void Surrender_Click(object sender, RoutedEventArgs e)
        {
            ThicknessAnimation ta = new ThicknessAnimation(new Thickness(215, game_over ? 123 : 140, 0, 0), new Thickness(15, game_over ? 123 : 140, 0, 0), new Duration(new TimeSpan(1000000)));
            ta.Completed += (object s1, EventArgs e1) => {
                pause_grid.Visibility = Visibility.Hidden;
                if (!game_over)
                {
                    cpu_win++;
                    cpu_win_count.Text = cpu_win + (cpu_win == 1 ? " win" : " wins");
                    game_over = true;
                }
            };
            pause_stack.BeginAnimation(MarginProperty, ta);
            
        }

        private void BackToMenu_Click(object sender, RoutedEventArgs e)
        {
            ThicknessAnimation ta = new ThicknessAnimation(new Thickness(215, game_over ? 123 : 140, 0, 0), new Thickness(15, game_over ? 123 : 140, 0, 0), new Duration(new TimeSpan(1000000)));
            ta.Completed += (object s1, EventArgs e1) => {
                pause_grid.Visibility = Visibility.Hidden;
                computer_number = null;
                current_battle_number = cpu_win = player_win = 0;
                OK_Number = banned_numbers = numbers = null;
                player_win_count.Text = cpu_win_count.Text = "0 wins";
                player_result_text.Text = player_number_text.Text = "";
                battle_number.Text = info_round_number.Text = "1";
                info_text1.BeginAnimation(HeightProperty, new DoubleAnimation(0, 44, new Duration(new TimeSpan(1))));
                info_text2.BeginAnimation(HeightProperty, new DoubleAnimation(0, 44, new Duration(new TimeSpan(1))));
                cpu_list.Items.Clear();
                player_list.Items.Clear();
                ThicknessAnimation m = new ThicknessAnimation(new Thickness(0, -400, -550, 0), new Duration(new TimeSpan(1500000)));
                grid_mother.BeginAnimation(MarginProperty, m);
            };
            pause_stack.BeginAnimation(MarginProperty, ta);
        }

        private void player_number_text_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                EnterNumber();
            }
        }


        private void player_result_text_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                EnterResult();
            }
        }

        private void ShowMessage(string message, int buttons_number, Brush backgrount_color)
        {
            rectangle.Fill = backgrount_color;
            rectangle.Stroke = backgrount_color;
            ok_button.Visibility = cancel_button.Visibility = Visibility.Hidden;
            info_grid.Opacity = 0;
            info_grid.Visibility = Visibility.Visible;
            if (message != null)
            {
                info_text1.BeginAnimation(HeightProperty, new DoubleAnimation(0, stack_info.ActualHeight, new Duration(new TimeSpan(10))));
                if (message.Length > 40)
                    info_text1.FontSize = 20;
                else
                    info_text1.FontSize = 30;
                stack_info.Height = info_text1.ActualHeight;
                info_text1.Text = message;
            }
            else
            {
                info_text1.BeginAnimation(HeightProperty, new DoubleAnimation(stack_info.ActualHeight, 0, new Duration(new TimeSpan(10))));
                info_text2.BeginAnimation(HeightProperty, new DoubleAnimation(stack_info.ActualHeight, 0, new Duration(new TimeSpan(10))));

                BackgroundWorker b3 = new BackgroundWorker();
                b3.DoWork += (object sender9, DoWorkEventArgs e9) => { Thread.Sleep(2000); };
                b3.RunWorkerCompleted += (object sender11, RunWorkerCompletedEventArgs e11) =>
                {
                    DoubleAnimation da = new DoubleAnimation(0, new Duration(new TimeSpan(2000000)));
                    da.Completed += (object sender12, EventArgs e12) =>
                    {
                        info_grid.Visibility = Visibility.Hidden;
                        info_grid.Opacity = 1;
                    };
                    info_grid.BeginAnimation(OpacityProperty, da);
                };
                b3.RunWorkerAsync();
                stack_info.Height = info_round_text.ActualHeight;
            }
            info_grid.BeginAnimation(OpacityProperty, new DoubleAnimation(1, new Duration(new TimeSpan(2000000))));
            switch (buttons_number)
            {
                case 1:
                    ok_button.Visibility = Visibility.Visible;
                    ok_button.Content = "OK";
                    break;
                case 2:
                    cancel_button.Visibility = Visibility.Visible;
                    ok_button.Visibility = Visibility.Visible;
                    ok_button.Content = "YES";
                    cancel_button.Content = "NO";
                    break;
            }
        }


        #region MultiPlayer

        #region Local
        bool mpl_is_first_player_turn;
        int mpl_rount_number = 0;

        int mpl_RountNumber
        {
            get { return mpl_rount_number; }
            set
            {
                mpl_is_first_player_turn = value % 2 == 1;
                mpl_rount_number = value;
            }
        }

        MPL_Turn mpl_turn = MPL_Turn.Null;
        MPL_Turn mpl_Turn
        {
            get { return mpl_turn; }
            set
            {
                switch(value)
                {
                    case MPL_Turn.FirstNumber:
                        mpl_player2_grid.BeginAnimation(MarginProperty, new ThicknessAnimation(new Thickness(0, 46, 10, 0), new TimeSpan(2000000)));
                        mpl_player1_grid.BeginAnimation(MarginProperty, new ThicknessAnimation(new Thickness(188, 46, 0, 0), new TimeSpan(2000000)));
                        mpl_number_placeholder.BeginAnimation(WidthProperty, new DoubleAnimation(120, new Duration(new TimeSpan(1000000))));
                        mpl_numbers_grid.BeginAnimation(WidthProperty, new DoubleAnimation(180, new Duration(new TimeSpan(1000000))));
                        MessageBox.Show(mpl_player1_name.Text + ": enter guess");
                        break;
                    case MPL_Turn.SecondHint:
                        mpl_player2_grid.BeginAnimation(MarginProperty, new ThicknessAnimation(new Thickness(0, 46, 10, 0), new TimeSpan(2000000)));
                        mpl_player1_grid.BeginAnimation(MarginProperty, new ThicknessAnimation(new Thickness(188, 46, 0, 0), new TimeSpan(2000000)));
                        mpl_number_placeholder.BeginAnimation(WidthProperty, new DoubleAnimation(0, new Duration(new TimeSpan(1000000))));
                        mpl_numbers_grid.BeginAnimation(WidthProperty, new DoubleAnimation(0, new Duration(new TimeSpan(1000000))));
                        MessageBox.Show(mpl_player2_name.Text + ": enter hint");
                        break;
                    case MPL_Turn.SecondNumber:
                        mpl_player1_grid.BeginAnimation(MarginProperty, new ThicknessAnimation(new Thickness(10, 46, 0, 0), new TimeSpan(2000000)));
                        mpl_player2_grid.BeginAnimation(MarginProperty, new ThicknessAnimation(new Thickness(0, 46, 192, 0), new TimeSpan(2000000)));
                        mpl_number_placeholder.BeginAnimation(WidthProperty, new DoubleAnimation(120, new Duration(new TimeSpan(1000000))));
                        mpl_numbers_grid.BeginAnimation(WidthProperty, new DoubleAnimation(180, new Duration(new TimeSpan(1000000))));
                        MessageBox.Show(mpl_player2_name.Text + ": enter guess");
                        break;
                    case MPL_Turn.FirstHint:
                        mpl_player1_grid.BeginAnimation(MarginProperty, new ThicknessAnimation(new Thickness(10, 46, 0, 0), new TimeSpan(2000000)));
                        mpl_player2_grid.BeginAnimation(MarginProperty, new ThicknessAnimation(new Thickness(0, 46, 192, 0), new TimeSpan(2000000)));
                        mpl_number_placeholder.BeginAnimation(WidthProperty, new DoubleAnimation(0, new Duration(new TimeSpan(1000000))));
                        mpl_numbers_grid.BeginAnimation(WidthProperty, new DoubleAnimation(0, new Duration(new TimeSpan(1000000))));
                        MessageBox.Show(mpl_player1_name.Text + ": enter hint");
                        break;
                }
                mpl_turn = value;
            }
        }

        string mpl_player1_number = null, mpl_player2_number = null;

        private void MPL_PlayerNumberText_PreviewKeyUp(object sender, KeyEventArgs e)
        {

        }

        private void MPL_PlayerNumberText_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (mpl_player_number_text.Text == string.Empty)
                mpl_number_placeholder_stack.Visibility = Visibility.Visible;
            else
                mpl_number_placeholder_stack.Visibility = Visibility.Hidden;
        }

        private void MultiPlayerLocal_Click(object sender, RoutedEventArgs e)
        {
            MultiPlayerLocalAnimation();
        }

        private void MultiPlayerLocalAnimation()
        {
            ThicknessAnimation ta11 = new ThicknessAnimation(new Thickness(-550, 0, 0, -400), new Duration(new TimeSpan(2000000)));
            ta11.Completed += (object sender6, EventArgs e6) =>
            {
                player_number_mpl.Visibility = Visibility.Hidden;
                stack_info_mpl.Margin = new Thickness(10, 168, 10, 0);
                rectangle_mpl.Fill = rectangle_mpl.Stroke = Brushes.ForestGreen;
                ok_button_mpl.Visibility = cancel_button_mpl.Visibility = Visibility.Hidden;
                info_grid_mpl.Opacity = 0;
                info_grid_mpl.Visibility = Visibility.Visible;
                info_text1_mpl.BeginAnimation(HeightProperty, new DoubleAnimation(0, stack_info_mpl.ActualHeight, new Duration(new TimeSpan(0))));
                stack_info_mpl.Height = info_text1_mpl.ActualHeight;
                info_text1_mpl.Text = "Hello humans!";
                info_grid_mpl.BeginAnimation(OpacityProperty, new DoubleAnimation(1, new Duration(new TimeSpan(2000000))));


                BackgroundWorker b1 = new BackgroundWorker();
                b1.DoWork += (object sender7, DoWorkEventArgs e7) => { Thread.Sleep(2000); };
                b1.RunWorkerCompleted += (object sender8, RunWorkerCompletedEventArgs e8) =>
                {
                    DoubleAnimation da1 = new DoubleAnimation(info_text1_mpl.ActualHeight, 0, new Duration(new TimeSpan(2000000)));
                    info_text1_mpl.BeginAnimation(HeightProperty, da1);

                    BackgroundWorker b2 = new BackgroundWorker();
                    b2.DoWork += (object sender9, DoWorkEventArgs e9) => { Thread.Sleep(2000); };
                    b2.RunWorkerCompleted += (object sender10, RunWorkerCompletedEventArgs e10) =>
                    {
                        DoubleAnimation da2 = new DoubleAnimation(info_text2_mpl.ActualHeight, 0, new Duration(new TimeSpan(2000000)));
                        info_text2_mpl.BeginAnimation(HeightProperty, da2);

                        BackgroundWorker b3 = new BackgroundWorker();
                        b3.DoWork += (object sender9, DoWorkEventArgs e9) => { Thread.Sleep(2000); };
                        b3.RunWorkerCompleted += (object sender11, RunWorkerCompletedEventArgs e11) =>
                        {
                            rectangle_mpl.Fill = rectangle_mpl.Stroke = Brushes.Blue;
                            info_text1_mpl.Text = mpl_player1_name.Text + ": Please enter your number.";
                            info_text1_mpl.BeginAnimation(HeightProperty, new DoubleAnimation(0, stack_info_mpl.ActualHeight, new Duration(new TimeSpan(0))));
                            stack_info_mpl.Margin = new Thickness(10, 130, 10, 0);
                            player_number_mpl.Visibility = Visibility.Visible;
                            ok_button_mpl.Visibility = cancel_button_mpl.Visibility = Visibility.Visible;
                            ok_button_mpl.Content = "OK";
                            cancel_button_mpl.Content = "CANCEL";

                            DoubleAnimation da = new DoubleAnimation(0, new Duration(new TimeSpan(2000000)));
                            da.Completed += (object sender12, EventArgs e12) =>
                            {
                               
                                //info_grid_mpl.Visibility = Visibility.Hidden;
                                //info_grid_mpl.Opacity = 1;
                            };
                            //info_grid_mpl.BeginAnimation(OpacityProperty, da);
                            //BegainMLPGame();
                        };
                        b3.RunWorkerAsync();
                    };
                    b2.RunWorkerAsync();

                };
                b1.RunWorkerAsync();

                //exit.Margin = new Thickness(180, 0, 0, 40);
                //about.Margin = new Thickness(180, 0, 0, 40);
                //options.Margin = new Thickness(180, 0, 0, 40);
                //m_p.Margin = new Thickness(180, 0, 0, 40);
                //s_p.Margin = new Thickness(180, 0, 0, 40);
            };
            //exit.BeginAnimation(MarginProperty, ta6);
            //about.BeginAnimation(MarginProperty, ta7);
            //options.BeginAnimation(MarginProperty, ta8);
            //m_p.BeginAnimation(MarginProperty, ta9);
            //s_p.BeginAnimation(MarginProperty, ta10);
            grid_mother.BeginAnimation(MarginProperty, ta11);
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            MultiPlayerLocalAnimation();
        }

        private void OK_Button_MPL_Click(object sender, RoutedEventArgs e)
        {
            if (mpl_player1_number == null)
            {
                if (isValid(player_number_mpl.Password))
                {
                    mpl_player1_number = player_number_mpl.Password;
                    rectangle_mpl.Fill = rectangle_mpl.Stroke = Brushes.Red;
                    info_text1_mpl.Text = mpl_player2_name.Text + ": Please enter your number.";
                    info_text1_mpl.BeginAnimation(HeightProperty, new DoubleAnimation(0, stack_info_mpl.ActualHeight, new Duration(new TimeSpan(0))));
                    stack_info_mpl.Margin = new Thickness(10, 130, 10, 0);
                    player_number_mpl.Visibility = Visibility.Visible;
                    player_number_mpl.Password = "";
                }
            }
            else
            {
                if (isValid(player_number_mpl.Password))
                {
                    mpl_player2_number = player_number_mpl.Password;
                    player_number_mpl.Password = "";
                    var an1 = new DoubleAnimation(0, new Duration(new TimeSpan(2000000)));
                    an1.Completed += (object sender1, EventArgs e1) => { info_grid_mpl.Visibility = Visibility.Hidden; };
                    info_grid_mpl.BeginAnimation(OpacityProperty, an1);
                    mpl_RountNumber++;
                    mpl_Turn = mpl_is_first_player_turn ? MPL_Turn.FirstNumber : MPL_Turn.SecondNumber;
                }
            }
        }

        private void MPL_EnterNumberButton_Click(object sender, RoutedEventArgs e)
        {
            if (!game_over)
            {
                switch (mpl_Turn)
                {
                    case MPL_Turn.FirstNumber:
                        if (!isValid(mpl_player_number_text.Text))
                            MessageBox.Show(mpl_player1_name.Text + ": wrong input");
                        else
                        {
                            mpl_player1_list.Items.Add(MakeListView(mpl_player_number_text.Text, mpl_player1_list.Items.Count));
                            if (CheckNumber(mpl_player2_number, mpl_player_number_text.Text).Equals("++++"))
                            {
                                MessageBox.Show(mpl_player1_name.Text + ": won");
                                game_over = true;
                            }
                            mpl_Turn = MPL_Turn.SecondHint;
                        }
                        break;
                    case MPL_Turn.FirstHint:
                        if (!CheckUserResult(mpl_player_number_text.Text))
                            MessageBox.Show(mpl_player1_name.Text + ": wrong hint");
                        else
                        {
                            string result = CheckNumber(mpl_player1_number, (mpl_player2_list.Items[mpl_player2_list.Items.Count - 1] as ListBoxItem).Content.ToString());
                            mpl_player2_list.Items.Add(MakeListView(result, mpl_player2_list.Items.Count));
                            if (!result.Equals(mpl_player_number_text.Text))
                                MessageBox.Show(mpl_player1_name.Text + ": wrong hint, correct hint has been added.");
                            mpl_Turn = MPL_Turn.FirstNumber;
                        }
                        break;
                    case MPL_Turn.SecondNumber:
                        if (!isValid(mpl_player_number_text.Text))
                            MessageBox.Show(mpl_player2_name.Text + ": wrong number");
                        else
                        {
                            mpl_player2_list.Items.Add(MakeListView(mpl_player_number_text.Text, mpl_player2_list.Items.Count));
                            if (CheckNumber(mpl_player1_number, mpl_player_number_text.Text).Equals("++++"))
                            {
                                MessageBox.Show(mpl_player2_name.Text + ": won");
                                game_over = true;
                            }
                            mpl_Turn = MPL_Turn.FirstHint;
                        }
                        break;
                    case MPL_Turn.SecondHint:
                        if (!CheckUserResult(mpl_player_number_text.Text))
                            MessageBox.Show(mpl_player2_name.Text + ": wrong hint");
                        else
                        {
                            string result = CheckNumber(mpl_player2_number, (mpl_player1_list.Items[mpl_player1_list.Items.Count - 1] as ListBoxItem).Content.ToString());
                            mpl_player1_list.Items.Add(MakeListView(result, mpl_player1_list.Items.Count));
                            if (!result.Equals(mpl_player_number_text.Text))
                                MessageBox.Show(mpl_player2_name.Text + ": wrong hint, correct hint has been added.");
                            mpl_Turn = MPL_Turn.SecondNumber;
                        }
                        break;
                }
            }
        }



        #endregion


        #endregion

        private ListBoxItem MakeListView(string text, int count)
        {
            ListBoxItem item = new ListBoxItem();
            item.Background = count % 2 == 1 ? Brushes.LightSkyBlue : Brushes.SkyBlue;
            if (text.Equals(string.Empty))
                item.Content = "NO THING";
            else
                item.Content = text;
            return item;
        }
    }

    enum MPL_Turn
    {
        Null = 0,
        FirstNumber = 1,
        SecondNumber = 3,
        FirstHint = 2,
        SecondHint = 4
    }
}
