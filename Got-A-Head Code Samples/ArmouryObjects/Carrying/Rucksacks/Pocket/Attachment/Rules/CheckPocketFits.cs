using ArmouryObjects.Carrying.Rucksacks.Pocket.Face;
using System;

namespace ArmouryObjects.Carrying.Rucksacks.Pocket.Attachment.Rules
{
    public class CheckPocketFits : IPocketAttachmentRule
    {
        RucksackFaceComparer _comparer = new RucksackFaceComparer();

        /// <summary>
        /// Will attach if the face on which the pocket is being placed is bigger than the pocket.
        /// </summary>
        /// <param name="faceToAttachTo"></param>
        /// <param name="pocketToAttach"></param>
        /// <returns></returns>
        public bool CanPocketFitOnParentsFace(IRucksackPocketFace faceToAttachTo, IRucksackPocket pocketToAttach)
        {
            if (faceToAttachTo is null) { throw new ArgumentNullException("faceToAttachTo"); }
            if (pocketToAttach is null) { throw new ArgumentNullException("pocketToAttach"); }
            return _comparer.Compare(faceToAttachTo, pocketToAttach.Back) >= 0;
        }
    }
}
