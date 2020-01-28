namespace ArmouryObjects.Carrying.Rucksacks.Pocket.Face
{
    /// <summary>
    /// 
    /// </summary>
    public class TopFace : RucksackPocketFace, IRucksackPocketFace
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pocket"></param>
        public TopFace(IRucksackPocket pocket) : base(pocket) { }

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
        public override int Fraction { get { return Pocket.TopPockets.Count; } }
        /// <summary>
        /// 
        /// </summary>
        public override double MaxDepth { get { return base.CalculateMaxDepth(Pocket.Height); } }

    }
}
