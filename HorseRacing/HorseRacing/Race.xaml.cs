using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace HorseRacing
{


    public partial class Race : Window
    {
        
        
        private double[] alreadyCoveredDistance = new double[6];
        private double[] disposition = new double[6];
        private Ellipse[] ellipse = new Ellipse[6];
        private Label[] arrayOfLabels = new Label[6];
        private List<double> listOfCurrentRanking = new List<double>();
        private Random rand = new Random();
        private int index;
        private double bestInEachLoop;
        private Boolean isWinnerFound = false;
        public int idOfWinner;

        enum EndOfRace : int
        {
            finishingLine=600
        }


        public Race()
        {
            InitializeComponent();
            CompositionTarget.Rendering += CompositionTarget_Rendering;

            for (int i = 0; i < 6; i++)
                disposition[i] = (rand.Next(85, 115)) / 100.0;

            ellipse[0] = theEllipse;
            ellipse[1] = theEllipse1;
            ellipse[2] = theEllipse2;
            ellipse[3] = theEllipse3;
            ellipse[4] = theEllipse4;
            ellipse[5] = theEllipse5;

            arrayOfLabels[0] = label1;
            arrayOfLabels[1] = label2;
            arrayOfLabels[2] = label3;
            arrayOfLabels[3] = label4;
            arrayOfLabels[4] = label5;
            arrayOfLabels[5] = label6;

            for(int i=0; i<6; i++)
            {
                arrayOfLabels[i].Foreground = ellipse[i].Fill;
                arrayOfLabels[i].Content = MainWindow.runningHorses[i].name; 
            }

            

            for(int i=0; i<6; i++)
            {
                if(MainWindow.playerChoice.Equals(arrayOfLabels[i].Content.ToString()))
                {
                    label8.Foreground = arrayOfLabels[i].Foreground;
                    label8.Content = arrayOfLabels[i].Content;
                }
            }

        }


        private void CompositionTarget_Rendering(object sender, System.EventArgs e)
        {
            for (int i=0; i<6; i++)
            {
                if (alreadyCoveredDistance[i] >= MainWindow.runningHorses[i].finishDistance)
                    alreadyCoveredDistance[i] += MainWindow.runningHorses[i].finishSpeed * MainWindow.runningJockeys[i].experience * disposition[i];
                else
                    alreadyCoveredDistance[i] += MainWindow.runningHorses[i].startSpeed * MainWindow.runningJockeys[i].experience * disposition[i];
            }

            for(int i=0; i<6; i++)
            {
                if (alreadyCoveredDistance[i] < (double)EndOfRace.finishingLine)
                    ellipse[i].SetValue(Canvas.LeftProperty, alreadyCoveredDistance[i]);
                else
                {
                    alreadyCoveredDistance[i] = (double)EndOfRace.finishingLine;
                    ellipse[i].SetValue(Canvas.LeftProperty, alreadyCoveredDistance[i]);
                }
            }

            

            if (alreadyCoveredDistance[0] == (double)EndOfRace.finishingLine && alreadyCoveredDistance[1] == (double)EndOfRace.finishingLine && alreadyCoveredDistance[2] == (double)EndOfRace.finishingLine && alreadyCoveredDistance[3] == (double)EndOfRace.finishingLine && alreadyCoveredDistance[4] == (double)EndOfRace.finishingLine && alreadyCoveredDistance[5] == (double)EndOfRace.finishingLine)
                this.Close();


            MakeScoreboard();
        }


        public void MakeScoreboard()
        {

            listOfCurrentRanking.Clear();
            for (int i = 0; i < 6; i++)
            {
                listOfCurrentRanking.Add(Canvas.GetLeft(ellipse[i]));

                if((Canvas.GetLeft(ellipse[i]) >= 600) && (isWinnerFound==false))
                {
                    isWinnerFound = true;
                    idOfWinner = i;
                }
            }


            if (isWinnerFound==false)
            {
                bestInEachLoop = listOfCurrentRanking.Max();
                index = listOfCurrentRanking.FindIndex(x => x == bestInEachLoop);
                winning.Foreground = ellipse[index].Fill;
                winning.Content = MainWindow.runningHorses[index].name; ;
            }
        }
    }
}
