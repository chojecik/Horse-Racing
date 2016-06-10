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
    /// Logika interakcji dla klasy Rules.xaml
    /// </summary>
    public partial class Rules : Window
    {
        public Rules()
        {
            InitializeComponent();

           

            var userControl = new UserControl1("./RULES.pdf");
            this.windowsFormsHost1.Child = userControl;
            
        }
    }
}
