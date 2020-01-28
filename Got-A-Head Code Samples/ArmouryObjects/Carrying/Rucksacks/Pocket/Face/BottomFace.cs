using System;
using System.Collections.Generic;
using System.Text;

namespace ArmouryObjects.Carrying.Rucksacks.Pocket.Face
{
    public class BottomFace : RucksackPocketFace
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pocket"></param>
        public BottomFace(IRucksackPocket pocket) : base(pocket) { }

        /// <summary>
        /// 
        /// </summary>
        public override double Height { get { return Pocket.Depth; } }

        /// <summary>
        /// 
        /// </summary>
        public override double Width { get { return Pocket.Width; } }
        /// <summary>
        /// 
        /// </summary>
        public override int Fraction { get { return Pocket.BottomPockets.Count; } }
        /// <summary>
        /// 
        /// </summary>
        public override double MaxDepth { get { return base.CalculateMaxDepth(Pocket.Height); } }
    }
}
