namespace ArmouryObjects.RucksackItems
{
    /// <summary>
    /// An interface that an object must support in order to be put in a rucksack.
    /// This assumes that X lies along the line of maximum length of the object.  Y is then set at the longes dimension in 
    /// a plane perpendicular to the object's X axis and Z is set orthogonal to  both using the right hand rule.
    /// </summary>
    public interface IRucksackItem
    {
        /// <summary>
        /// Size in metres along the X dimension, the object's longest axis
        /// </summary>
        float Height { get; }
        /// <summary>
        /// The Object's size in metres along the longest distance in a plane perpendicular
        /// to the X axis
        /// </summary>
        float Width { get; }
        /// <summary>
        /// The maximum length along the Z axis, which is set perpendicular to X  and Y
        /// using the right hand rule.
        /// </summary>
        float Depth { get; }

        /// <summary>
        /// Volume in litres. This should be less than XSize x YSize x ZSize.
        /// </summary>
        float Volume { get; }
        /// <summary>
        /// Mass of the object in kg.
        /// </summary>
        float Mass { get; }
    }
}
