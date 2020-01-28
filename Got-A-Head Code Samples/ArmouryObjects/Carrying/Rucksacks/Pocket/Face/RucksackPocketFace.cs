namespace ArmouryObjects.Carrying.Rucksacks.Pocket
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class RucksackPocketFace : IRucksackPocketFace
    {

        private IRucksackPocket _pocket;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pocket"></param>
        public RucksackPocketFace(IRucksackPocket pocket)
        {
            _pocket = pocket;
        }

        /// <summary>
        /// To be used by the sub-classes to calculate MaxDepth
        /// </summary>
        /// <param name="perpendicularPocketDimension"></param>
        /// <returns></returns>
        protected double CalculateMaxDepth( double perpendicularPocketDimension)
        {
            return perpendicularPocketDimension / _pocket.AttachedPocketDepthPreporation;
        }
        /// <summary>
        /// 
        /// </summary>
        public IRucksackPocket Pocket {  get { return _pocket; } }
        /// <summary>
        /// 
        /// </summary>
        public abstract double Height { get; }
        /// <summary>
        /// 
        /// </summary>
        public abstract double Width { get; }
        /// <summary>
        /// 
        /// </summary>
        public abstract int Fraction { get; }
        /// <summary>
        /// 
        /// </summary>
        public abstract double MaxDepth { get; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="newPocket"></param>
        /// <returns></returns>
        public bool CanPocketFitOnFace(IRucksackPocket newPocket)
        {
            return _pocket.CanPocketFitOnFace(this, newPocket);
        }

    }
}
