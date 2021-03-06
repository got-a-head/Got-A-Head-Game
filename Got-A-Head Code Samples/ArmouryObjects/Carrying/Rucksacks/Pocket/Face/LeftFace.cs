﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ArmouryObjects.Carrying.Rucksacks.Pocket.Face
{
    public class LeftFace : RucksackPocketFace
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pocket"></param>
        public LeftFace(IRucksackPocket pocket) : base(pocket) { }

        /// <summary>
        /// 
        /// </summary>
        public override double Height { get { return Pocket.Height; } }

        /// <summary>
        /// 
        /// </summary>
        public override double Width { get { return Pocket.Depth; } }
        /// <summary>
        /// 
        /// </summary>
        public override int Fraction { get { return Pocket.LeftPockets.Count; } }
        /// <summary>
        /// 
        /// </summary>
        public override double MaxDepth { get { return base.CalculateMaxDepth(Pocket.Width); } }

    }
}
