using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace HorseRacing
{
    public partial class MainWindow : Window
    {
        public static List<Horse> runningHorses = new List<Horse>();
        public static List<Jockey> runningJockeys = new List<Jockey>();
        public static String playerChoice;
        public static List<String> hints = new List<string>();
        private int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private HorseList temp = new HorseList();
        private JockeyList temp1 = new JockeyList();
        private List<double> winRatio = new List<double>();
        private double betValue;
        private double money = 2000;
        
        private int gamesCounter;


        public MainWindow()
        {
            
            InitializeComponent();
            Shuffle(numbers);
            temp.Pick(numbers, runningHorses);
            Shuffle(numbers);
            temp1.Pick(numbers, runningJockeys);
            CalculateWinRatio(runningHorses, runningJockeys);
            SetInterface();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            betValue = slider.Value;
            money = money - betValue;
            textBlock.Text = money.ToString();
            MessageBox.Show("Selected horse: " + playerChoice + "\n" + "Money bet: " + betValue + "\n" + "Money left: " + money);

            Race race = new Race();
            this.Hide();
            race.ShowDialog();
            this.Show();

            if (playerChoice == race.winning.Content.ToString())
            {
                money = money + winRatio[race.idOfWinner] * betValue;
                textBlock.Text = money.ToString();
                MessageBox.Show("Winner of the race: " + race.winning.Content.ToString() + "\n\n" + "YOU WON THE BET!!!");
            }
            else
                MessageBox.Show("Winner of the race: " + race.winning.Content.ToString() + "\n\n" + "YOU LOST THE BET");

            if (money <= 0)
            {
                MessageBox.Show("You lost all of your money - GAME OVER");
                Application.Current.Shutdown();
            }
            else if (money >= 50000)
            {
                MessageBox.Show("You earned a lot of cash - YOU WON");
                Application.Current.Shutdown();
            }

            gamesCounter++;
        }

        private void Shuffle<T>(IList<T> list)
        {
            int n = list.Count;
            Random rnd = new Random();
            while (n > 1)
            {
                int k = (rnd.Next(0, n) % n);
                n--;
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }


        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (checkBox.IsChecked == true)
            {
                hints.Add(runningHorses[0].DescribeYourself());
                money = money - 250;

            }
            if (checkBox1.IsChecked == true)
            {
                hints.Add(runningHorses[1].DescribeYourself());
                money = money - 250;

            }
            if (checkBox2.IsChecked == true)
            {
                hints.Add(runningHorses[2].DescribeYourself());
                money = money - 250;

            }
            if (checkBox3.IsChecked == true)
            {
                hints.Add(runningHorses[3].DescribeYourself());
                money = money - 250;

            }
            if (checkBox4.IsChecked == true)
            {
                hints.Add(runningHorses[4].DescribeYourself());
                money = money - 250;

            }
            if (checkBox5.IsChecked == true)
            {
                hints.Add(runningHorses[5].DescribeYourself());
                money = money - 250;

            }
            if (checkBox6.IsChecked == true)
            {
                hints.Add(runningJockeys[0].DescribeYourself());
                money = money - 250;

            }
            if (checkBox7.IsChecked == true)
            {
                hints.Add(runningJockeys[1].DescribeYourself());
                money = money - 250;

            }
            if (checkBox8.IsChecked == true)
            {
                hints.Add(runningJockeys[2].DescribeYourself());
                money = money - 250;

            }
            if (checkBox9.IsChecked == true)
            {
                hints.Add(runningJockeys[3].DescribeYourself());
                money = money - 250;

            }
            if (checkBox10.IsChecked == true)
            {
                hints.Add(runningJockeys[4].DescribeYourself());
                money = money - 250;

            }
            if (checkBox11.IsChecked == true)
            {
                hints.Add(runningJockeys[5].DescribeYourself());
                money = money - 250;

            }

            
                MessageBox.Show("Hints have been bought");
            

            //hints.Clear();
            SetInterface();
        }

        private void SetInterface()
        {

            slider.Value = 0;
            slider.Maximum = money;
            textBlock.Text = money.ToString();
            radioButton.Content = runningHorses[0].name;
            radioButton.IsChecked = false;
            radioButton1.Content = runningHorses[1].name;
            radioButton1.IsChecked = false;
            radioButton2.Content = runningHorses[2].name;
            radioButton2.IsChecked = false;
            radioButton3.Content = runningHorses[3].name;
            radioButton3.IsChecked = false;
            radioButton4.Content = runningHorses[4].name;
            radioButton4.IsChecked = false;
            radioButton5.Content = runningHorses[5].name;
            radioButton5.IsChecked = false;

            textBlock3.Text = runningJockeys[0].name;
            textBlock4.Text = runningJockeys[1].name;
            textBlock5.Text = runningJockeys[2].name;
            textBlock6.Text = runningJockeys[3].name;
            textBlock7.Text = runningJockeys[4].name;
            textBlock8.Text = runningJockeys[5].name;
            textBlock18.Text = winRatio[0].ToString();
            textBlock19.Text = winRatio[1].ToString();
            textBlock20.Text = winRatio[2].ToString();
            textBlock21.Text = winRatio[3].ToString();
            textBlock22.Text = winRatio[4].ToString();
            textBlock23.Text = winRatio[5].ToString();
            textBlock25.Text = gamesCounter.ToString();

            checkBox.IsChecked = false;
            checkBox1.IsChecked = false;
            checkBox2.IsChecked = false;
            checkBox3.IsChecked = false;
            checkBox4.IsChecked = false;
            checkBox5.IsChecked = false;
            checkBox6.IsChecked = false;
            checkBox7.IsChecked = false;
            checkBox8.IsChecked = false;
            checkBox9.IsChecked = false;
            checkBox10.IsChecked = false;
            checkBox11.IsChecked = false;

            textBox.Text = String.Empty;

        }


        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {
            playerChoice = radioButton.Content.ToString();
        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {
            playerChoice = radioButton1.Content.ToString();
        }

        private void radioButton2_Checked(object sender, RoutedEventArgs e)
        {
            playerChoice = radioButton2.Content.ToString();
        }

        private void radioButton3_Checked(object sender, RoutedEventArgs e)
        {
            playerChoice = radioButton3.Content.ToString();
        }

        private void radioButton4_Checked(object sender, RoutedEventArgs e)
        {
            playerChoice = radioButton4.Content.ToString();
        }

        private void radioButton5_Checked(object sender, RoutedEventArgs e)
        {
            playerChoice = radioButton5.Content.ToString();
        }


        private void CalculateWinRatio(List<Horse> horseList, List<Jockey> jockeyList)
        {
            for (int i = 0; i < 6; i++)
            {
                
                if ((horseList[i].startSpeed * jockeyList[i].experience * horseList[i].finishDistance + jockeyList[i].experience * horseList[i].finishSpeed * (600 - horseList[i].finishDistance) >= 300))
                    winRatio.Insert(i, 2);

                else if ((horseList[i].startSpeed * jockeyList[i].experience * horseList[i].finishDistance + jockeyList[i].experience * horseList[i].finishSpeed * (600 - horseList[i].finishDistance) < 300 && horseList[i].startSpeed * jockeyList[i].experience * horseList[i].finishDistance + jockeyList[i].experience * horseList[i].finishSpeed * (600 - horseList[i].finishDistance) >= 280))
                    winRatio.Insert(i, 2.5);

                else if ((horseList[i].startSpeed * jockeyList[i].experience * horseList[i].finishDistance + jockeyList[i].experience * horseList[i].finishSpeed * (600 - horseList[i].finishDistance) < 280 && horseList[i].startSpeed * jockeyList[i].experience * horseList[i].finishDistance + jockeyList[i].experience * horseList[i].finishSpeed * (600 - horseList[i].finishDistance) >= 260))
                    winRatio.Insert(i, 3);

                else if ((horseList[i].startSpeed * jockeyList[i].experience * horseList[i].finishDistance + jockeyList[i].experience * horseList[i].finishSpeed * (600 - horseList[i].finishDistance) < 260))
                    winRatio.Insert(i, 4);
            }


        }


        private void button2_Click(object sender, RoutedEventArgs e)
        {
            
            Shuffle(numbers);
            temp.Pick(numbers, runningHorses);
            Shuffle(numbers);
            temp1.Pick(numbers, runningJockeys);
            CalculateWinRatio(runningHorses, runningJockeys);
            SetInterface();
        }

        private void textBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (int.Parse(textBox.Text) <= money)
                {
                    betValue = int.Parse(textBox.Text);
                    slider.Value = betValue;
                }
                else
                    MessageBox.Show("You don't have enough money to make this bet" + "\n" + "Instead you bet: " + slider.Value);
            }

            catch (FormatException)
            {
                MessageBox.Show("Entered value must be a number");
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Rules rules = new Rules();
            rules.Show();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            YourHints yourHints = new YourHints();
            yourHints.Show();
        }
    }
}
