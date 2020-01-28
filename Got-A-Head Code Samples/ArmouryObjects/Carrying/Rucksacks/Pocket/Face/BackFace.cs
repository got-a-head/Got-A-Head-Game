using System;
using System.Collections.Generic;
using System.Text;

namespace ArmouryObjects.Carrying.Rucksacks.Pocket.Face
{
    public class BackFace : RucksackPocketFace
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pocket"></param>
        public BackFace(IRucksackPocket pocket) : base(pocket) { }

        /// <summary>
        /// 
        /// </summary>
        public override double Height { get { return Pocket.Height; } }

        /// <summary>
        /// 
        /// </summary>
        public override double Width { get { return Pocket.Width; } }
        /// <summary>
        /// You can't have any pockets attached to the back
        /// </summary>
        public override int Fraction { get { return 1; } }
        /// <summary>
        /// 
        /// </summary>
        public override double MaxDepth { get { return base.CalculateMaxDepth(Pocket.Depth); } }
    }
}
