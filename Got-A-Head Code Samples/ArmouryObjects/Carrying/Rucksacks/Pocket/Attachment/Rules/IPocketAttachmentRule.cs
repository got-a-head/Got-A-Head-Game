

namespace ArmouryObjects.Carrying.Rucksacks.Pocket.Attachment.Rules
{
    /// <summary>
    /// 
    /// </summary>
    public interface IPocketAttachmentRule
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="faceToAttachTo"></param>
        /// <param name="pocketToAttach"></param>
        /// <returns></returns>
        bool CanPocketFitOnParentsFace(IRucksackPocketFace faceToAttachTo, IRucksackPocket pocketToAttach);
    }
}
