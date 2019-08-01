
namespace Interfaces_and_Generic_Containers.Example1_Interfaces
{
    /// <summary>
    /// An interface that supports properties giving the best performance of the car
    /// </summary>
    public interface ICarPerformance
    {

        /// <summary>
        /// Maximum spped of the car in MPH  This must be a constant
        /// </summary>
        short MaxSpeed { get; }

        /// <summary>
        /// Maximum lock you can turn the steering wheel in degrees
        /// </summary>
        short MaxSteeringLock { get; }

        /// <summary>
        /// How much speed you can gain per second
        /// </summary>
        short AccelerationPerSecond { get; }

        /// <summary>
        /// How much your brakes slow you down per second
        /// </summary>
        short BrakingPerSecond { get; }

    }
}
