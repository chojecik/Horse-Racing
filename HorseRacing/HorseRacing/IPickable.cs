using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRacing
{
    interface IPickable
    {
        void Pick(int[] array, List<Horse> list);
        void Pick(int[] array, List<Jockey> list);

    }
}
