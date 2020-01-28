using ArmouryObjects.RucksackItems;
using ArmouryObjects.Carrying.Rucksacks.Pocket;

namespace ArmouryObjects.Carrying.Rucksacks
{
    /// <summary>
    /// 
    /// </summary>
    public class Rucksack : RucksackItem, IRucksack
    {
        private IRucksackPocket _mainPocket;
        /// <summary>
        /// 
        /// </summary>
        public const float DefaultDepth = 0.07f;
        /// <summary>
        /// 
        /// </summary>
        public const float DefaultMass = 0.5f;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="height"></param>
        /// <param name="width"></param>
        /// <param name="depth"></param>
        /// <param name="volume"></param>
        /// <param name="mass"></param>
        /// <param name="mainPocket"></param>
        public Rucksack(float height, float width, float depth, float volume, float mass, IRucksackPocket mainPocket)
                : base(height, width, depth, volume, mass)
        {
            _mainPocket = mainPocket;
        }

        /// <summary>
        /// Defaults to the depth being 7cm and the mass being 500g.  It assumes that the pocket is empty and folded down,
        /// to the depth is an estimate of that.
        /// </summary>
        /// <param name="height"></param>
        /// <param name="width"></param>
        /// <param name="depth"></param>
        /// <param name="mainPocket"></param>
        public Rucksack(float height, float width, IRucksackPocket mainPocket)
                : base(height, width, DefaultDepth, height * width * DefaultDepth, DefaultMass)
        {
            _mainPocket = mainPocket;
        }

        /// <summary>
        /// 
        /// </summary>
        public IRucksackPocket MainPocket { 
            get { return _mainPocket;  } 
            set { _mainPocket = value; }
        }
    }
}
