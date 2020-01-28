using System;
using System.Collections.Generic;

namespace ArmouryObjects.Carrying.Rucksacks.Pocket.Face
{
    /// <summary>
    /// 
    /// </summary>
    public class RucksackFaceComparer : IComparer<IRucksackPocketFace>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Compare(IRucksackPocketFace x, IRucksackPocketFace y)
        {
            if (x is null || y is null)
            {
                string msg = x is null && y is null ? "arguments x and y are both null" : x is null ? "argument x is null" : "argument y is null";
                throw new NullReferenceException(msg);
            }
            return (int) Math.Round( x.Height != y.Height ? x.Height - y.Height : x.Width - y.Width);
        }
    }
}
