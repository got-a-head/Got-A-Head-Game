using ArmouryObjects.RucksackItems;
using System.Collections.Generic;

namespace ArmouryObjects.Carrying.Rucksacks.Pocket
{
    /// <summary>
    /// 
    /// </summary>
    public interface IRucksackPocket : IRucksackItem
    {
        /// <summary>
        /// The minimum proportion that the dimension of the rucksack perpendicular to the face can have to the depth of an attached side pocket.
        /// So if this is 4, the depth of the attached side pocket must be less than 1/4 of the size of the dimension of the pocket perpendicular to 
        /// the face the side pocket is being attached to.
        /// Essentially it is a measure of the maximum depth that any side pocket can have, so a measure of the strength of this pocket's material.
        /// </summary>
        int AttachedPocketDepthPreporation { get; }
        /// <summary>
        /// 
        /// </summary>
        IRucksackPocketFace Top { get; }
        /// <summary>
        /// 
        /// </summary>
        IRucksackPocketFace Bottom { get; }
        /// <summary>
        /// 
        /// </summary>
        IRucksackPocketFace Back { get; }
        /// <summary>
        /// 
        /// </summary>
        IRucksackPocketFace Front { get; }
        /// <summary>
        /// 
        /// </summary>
        IRucksackPocketFace Left { get; }
        /// <summary>
        /// 
        /// </summary>
        IRucksackPocketFace Right { get; }


        /// <summary>
        /// 
        /// </summary>
        IList<IRucksackPocket> TopPockets { get; }
        /// <summary>
        /// 
        /// </summary>
        IList<IRucksackPocket> BottomPockets { get; }
        /// <summary>
        /// 
        /// </summary>
        IList<IRucksackPocket> LeftPockets { get; }
        /// <summary>
        /// 
        /// </summary>
        IList<IRucksackPocket> RightPockets { get; }
        /// <summary>
        /// 
        /// </summary>
        IList<IRucksackPocket> FrontPockets { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="face"></param>
        /// <param name="newPockt"></param>
        /// <returns></returns>
        bool CanPocketFitOnFace(IRucksackPocketFace face, IRucksackPocket newPockt);
    }
}
