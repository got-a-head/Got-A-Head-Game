using System;


namespace ArmouryObjects.Carrying.Rucksacks.Pocket
{
    /// <summary>
    /// 
    /// </summary>
    public interface IRucksackPocketFace
    {
        /// <summary>
        /// 
        /// </summary>
        Double Height { get; }
        /// <summary>
        /// 
        /// </summary>
        Double Width { get; }
        /// <summary>
        /// Returns the denominator of the fraction of the face that a new pocket must occupy.
        /// </summary>
        int Fraction { get; }
        /// <summary>
        /// This indicates the maximum depth that any pocket put on the face can support.
        /// This would normally be 1/4 of the depth of the dimension of the pocket 
        /// </summary>
        Double MaxDepth { get; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="newPocket"></param>
        /// <returns></returns>
        bool CanPocketFitOnFace(IRucksackPocket newPocket);

    }
}
