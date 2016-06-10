using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRacing
{
    public class JockeyList: IPickable
    {
        public List<Jockey> jockeys;

        public JockeyList()
        {
            this.jockeys = new List<Jockey>();

            this.jockeys.Add(new Jockey() { name = "Jack Sparrow", experience = .87});
            this.jockeys.Add(new Jockey() { name = "Leonardo diCaprio", experience = .75});
            this.jockeys.Add(new Jockey() { name = "Bill Clinton", experience = .94});
            this.jockeys.Add(new Jockey() { name = "Bob Dylan", experience = .82});
            this.jockeys.Add(new Jockey() { name = "Steven King", experience = .80});
            this.jockeys.Add(new Jockey() { name = "Usain Bolt", experience = .88});
            this.jockeys.Add(new Jockey() { name = "Willy Wonka", experience = .90});
            this.jockeys.Add(new Jockey() { name = "Harry Potter", experience = .78});
            this.jockeys.Add(new Jockey() { name = "Peter Pan", experience = .85});
            this.jockeys.Add(new Jockey() { name = "David Beckham", experience = .91});


        }

        public void Pick(int[] array, List<Horse> list)
        {
            throw new NotImplementedException();
        }

        public void Pick(int[] array, List<Jockey> list)
        {
            for (int i = 0; i < 6; i++)
                list.Insert(i,jockeys[array[i]]);

        }
    }
}
