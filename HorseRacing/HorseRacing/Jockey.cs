using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRacing
{
    public class Jockey
    {
        public string name { get; set; }
        public double experience { get; set; }
        

        public string DescribeYourself()
        {
            string tmp;

            tmp = "Name: " + this.name + "\t\t" + "Experience: " + this.experience + "\n\n";

            return tmp;
        }
    }
}
