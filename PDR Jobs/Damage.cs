using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDR_Jobs
{
    public class Damage
    {
        public double HailSize;
        public int LotSize;
        public int NumberTotaled;
        public String PhotoFile;
        public double SplitPercentage;

        public override string ToString()
        {
            return $"{ HailSize} {LotSize} ";
        }

    }
}
