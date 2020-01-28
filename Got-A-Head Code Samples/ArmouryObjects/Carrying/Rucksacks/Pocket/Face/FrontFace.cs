using System;
using System.Collections.Generic;
using System.Text;

namespace ArmouryObjects.Carrying.Rucksacks.Pocket.Face
{
    public class FrontFace : RucksackPocketFace
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pocket"></param>
        public FrontFace(IRucksackPocket pocket) : base(pocket) { }

        /// <summary>
        /// 
        /// </summary>
        public override double Height { get { return Pocket.Height; } }

        /// <summary>
        /// 
        /// </summary>
        public override double Width { get { return Pocket.Width; } }
        /// <summary>
        /// 
        /// </summary>
        public override int Fraction { get { return Pocket.FrontPockets.Count; } }
        /// <summary>
        /// 
        /// </summary>
        public override double MaxDepth { get { return base.CalculateMaxDepth(Pocket.Depth); } }

    }
}
