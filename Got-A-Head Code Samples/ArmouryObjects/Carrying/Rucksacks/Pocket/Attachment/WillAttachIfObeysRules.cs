using ArmouryObjects.Carrying.Rucksacks.Pocket.Attachment.Rules;
using System.Collections.Generic;

namespace ArmouryObjects.Carrying.Rucksacks.Pocket.Attachment
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class WillAttachIfObeysRules : IPocketAttachment
    {
        List<IPocketAttachmentRule> _ruleList;

        public WillAttachIfObeysRules(IEnumerable<IPocketAttachmentRule> ruleSet)
        {
            _ruleList = new List<IPocketAttachmentRule>(ruleSet);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="faceToAttachTo"></param>
        /// <param name="pocketToAttach"></param>
        /// <returns></returns>
        public bool CanPockeAttachToParent(IRucksackPocketFace faceToAttachTo, IRucksackPocket pocketToAttach)
        {
            bool bCanPockeAttachToParent = true;
            IEnumerator<IPocketAttachmentRule> enumerator = _ruleList.GetEnumerator();

            while (bCanPockeAttachToParent && enumerator.MoveNext() )
            {
                bCanPockeAttachToParent &= enumerator.Current.CanPocketFitOnParentsFace(faceToAttachTo, pocketToAttach);
            }
            return bCanPockeAttachToParent;
        }
    }
}
