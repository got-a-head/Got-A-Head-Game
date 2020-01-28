using System;
using System.Collections.Generic;
using System.Text;

namespace ArmouryObjects.RucksackItems.Comparers
{
    public class RucksackVolumeComparerr : IComparer<IRucksackItem>
    {
        public int Compare(IRucksackItem x, IRucksackItem y)
        {
            if (x is null || y is null)
            {
                string msg = x is null && y is null ? "arguments x and y are both null" : x is null ? "argument x is null" : "argument y is null"; 
                throw new NullReferenceException(msg);
            }
            if (ReferenceEquals(x, y))
            {
                return 0;
            }
            double value = x.Volume - y.Volume;
            return value < 0 ? 1 : value < 0 ? -1 : 0;
        }
    }
}
