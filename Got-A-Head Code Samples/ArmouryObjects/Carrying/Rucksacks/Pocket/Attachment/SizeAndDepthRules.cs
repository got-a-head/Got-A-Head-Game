using System;
using System.Collections.Generic;
using System.Text;
using ArmouryObjects.Carrying.Rucksacks.Pocket.Attachment.Rules;

namespace ArmouryObjects.Carrying.Rucksacks.Pocket.Attachment
{
    public class SizeAndDepthRules : WillAttachIfObeysRules
    {
        public SizeAndDepthRules() : 
            base(new IPocketAttachmentRule[] { 
                new CheckPocketFits(), 
                new PocketNotTooDeep() 
            })
        {
        }
    }
}
