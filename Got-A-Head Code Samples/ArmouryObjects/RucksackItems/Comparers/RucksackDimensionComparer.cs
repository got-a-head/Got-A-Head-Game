using System;
using System.Collections.Generic;
using System.Text;

namespace ArmouryObjects.RucksackItems.Comparers
{
    public class RucksackDimensionComparer : IComparer<IRucksackItem>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int Compare(IRucksackItem x, IRucksackItem y)
        {
            if (ReferenceEquals(x, y))
            {
                return 0;
            }
            double value =
                    !x.Height.Equals(y.Height) ? x.Height - y.Height
                  : !x.Width.Equals(y.Width) ? x.Width - y.Width
                  : !x.Depth.Equals(y.Depth) ? x.Depth - y.Depth
                  : !x.Volume.Equals(y.Volume) ? x.Volume - y.Volume
                  : !x.Mass.Equals(y.Mass) ? x.Mass - y.Mass
                  : 0f;
            return value > 0 ? 1 : value < 0 ? -1 : 0;
        }
    }
}
