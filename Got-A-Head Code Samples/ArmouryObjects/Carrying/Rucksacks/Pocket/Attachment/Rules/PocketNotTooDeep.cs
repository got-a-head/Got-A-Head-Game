using System;
using System.Collections.Generic;
using System.Text;

namespace ArmouryObjects.Carrying.Rucksacks.Pocket.Attachment.Rules
{
    public class PocketNotTooDeep : IPocketAttachmentRule
    {
        public bool CanPocketFitOnParentsFace(IRucksackPocketFace faceToAttachTo, IRucksackPocket pocketToAttach)
        {
            return faceToAttachTo.MaxDepth >= pocketToAttach.Depth;
        }
    }
}
