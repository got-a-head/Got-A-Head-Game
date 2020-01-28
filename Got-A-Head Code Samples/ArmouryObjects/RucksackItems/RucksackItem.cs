

namespace ArmouryObjects.RucksackItems
{
    public class RucksackItem : IRucksackItem
    {
        readonly float _height;
        readonly float _width;
        readonly float _depth;
        readonly float _volume;
        readonly float _mass;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="height"></param>
        /// <param name="width"></param>
        /// <param name="depth"></param>
        /// <param name="volume"></param>
        /// <param name="mass"></param>

        public RucksackItem(float height, float width, float depth, float volume, float mass)
        {
            _height = height;
            _width = width;
            _depth = depth;
            _volume = volume;
            _mass = mass;
        }

        /// <summary>
        /// Length along the priamry axis in m
        /// </summary>
        public float Height { get { return _height; } }
        /// <summary>
        /// maximum possible length along any seocndary axis perperndicular to the primary axis
        /// </summary>
        public float Width { get { return _width; } }
        /// <summary>
        /// Length along axis perpendicular to X and Y
        /// </summary>
        public float Depth { get { return _depth; } }
        /// <summary>
        /// Volume of the object in cubic metres
        /// </summary>
        public float Volume { get { return _volume; } }
        /// <summary>
        /// mass of the object in kg.
        /// </summary>
        public float Mass { get { return _mass; } }
    }
}
