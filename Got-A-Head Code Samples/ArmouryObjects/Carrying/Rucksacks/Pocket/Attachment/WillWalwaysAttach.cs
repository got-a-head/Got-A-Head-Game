
namespace ArmouryObjects.Carrying.Rucksacks.Pocket.Attachment
{
    /// <summary>
    /// 
    /// </summary>
    public class WillWalwaysAttach : IPocketAttachment
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="faceToAttachTo"></param>
        /// <param name="pocketToAttach"></param>
        /// <returns></returns>
        public bool CanPockeAttachToParent(IRucksackPocketFace faceToAttachTo, IRucksackPocket pocketToAttach)
        {
            return true;
        }
    }
}
