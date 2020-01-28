

namespace ArmouryObjects.Carrying.Rucksacks.Pocket.Attachment
{
    /// <summary>
    /// 
    /// </summary>
    public interface IPocketAttachment
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="faceToAttachTo"></param>
        /// <param name="pocketToAttach"></param>
        /// <returns></returns>
        bool CanPockeAttachToParent(IRucksackPocketFace faceToAttachTo, IRucksackPocket pocketToAttach);

    }
}
