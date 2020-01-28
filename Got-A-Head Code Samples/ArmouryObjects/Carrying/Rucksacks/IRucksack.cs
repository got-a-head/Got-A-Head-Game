using ArmouryObjects.RucksackItems;
using ArmouryObjects.Carrying.Rucksacks.Pocket;

namespace ArmouryObjects.Carrying.Rucksacks
{
    /// <summary>
    /// 
    /// </summary>
    public interface IRucksack : IRucksackItem
    {
        /// <summary>
        /// 
        /// </summary>
        IRucksackPocket MainPocket { get; }

    }
}
