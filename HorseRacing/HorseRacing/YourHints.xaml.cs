using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HorseRacing
{
    /// <summary>
    /// Logika interakcji dla klasy YourHints.xaml
    /// </summary>
    public partial class YourHints : Window
    {
        public YourHints()
        {
            InitializeComponent();

            for(int i=0; i<MainWindow.hints.Count(); i++)
            {
                textBlock.Text += (i+1) + ": " + MainWindow.hints[i];
            }
        }
    }
}
