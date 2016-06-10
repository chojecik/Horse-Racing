using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRacing
{
    public class HorseList: IPickable
    {
        public List<Horse> horses;

        public HorseList()
        {
            this.horses = new List<Horse>();

            this.horses.Add(new Horse() { name = "Shergar", startSpeed = .5, finishSpeed = .6, finishDistance=400});
            this.horses.Add(new Horse() { name = "Ruffian", startSpeed = .51, finishSpeed = .65, finishDistance = 380});
            this.horses.Add(new Horse() { name = "Seabiscuit", startSpeed = .53, finishSpeed = .55, finishDistance = 380});
            this.horses.Add(new Horse() { name = "Eight Belles", startSpeed = .48, finishSpeed = .68, finishDistance = 410});
            this.horses.Add(new Horse() { name = "Eclipse", startSpeed = .55, finishSpeed = .5, finishDistance = 450});
            this.horses.Add(new Horse() { name = "Secretariat", startSpeed = .67, finishSpeed = .45, finishDistance = 385});
            this.horses.Add(new Horse() { name = "Oblivion", startSpeed = .47, finishSpeed = .7, finishDistance = 340});
            this.horses.Add(new Horse() { name = "Rocky", startSpeed = .52, finishSpeed = .59, finishDistance = 415});
            this.horses.Add(new Horse() { name = "Sparky", startSpeed = .65, finishSpeed = .48, finishDistance = 350});
            this.horses.Add(new Horse() { name = "Zorro", startSpeed = .57, finishSpeed = .55, finishDistance = 400});
        }

        public void Pick(int[] array, List<Jockey> list)
        {
            throw new NotImplementedException();
        }

        public void Pick (int []array, List<Horse> list)
        {
            for (int i = 0; i < 6; i++)
                list.Insert(i, horses[array[i]]);                                              


        }
    }
}
