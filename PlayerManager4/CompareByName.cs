using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManager4
{
    public class CompareByName : IComparer<Player>
    {
        public bool Ascending { get; private set; }
        public CompareByName(bool isAscending)
        {
            Ascending = isAscending;
        }

        public int Compare(Player x, Player y)
        {
            if (x == null | y == null) return 1;
            else if (Ascending)
            {
                return x.Name.CompareTo(y.Name);
            }
            else return y.Name.CompareTo(x.Name);


        }
    }
}