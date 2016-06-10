using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRacing
{
    public class Horse
    {
        public string name { get; set; }
        public double startSpeed { get; set; }
        public double finishSpeed { get; set; }
        public double finishDistance { get; set; }
        

        public string DescribeYourself()
        {
            string tmp;

            tmp = "Name: " + this.name + "\t\t" + "Start speed: " + this.startSpeed + "\t\t" + "Finish speed: " + this.finishSpeed + "\t\t" + "Finish commencement: " + this.finishDistance + "\n\n";

            return tmp;
        }
    }
}
