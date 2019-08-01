
using System;

namespace Interfaces_and_Generic_Containers.Example1_Interfaces
{
    /// <summary>
    /// A class representing a car that's a little better than my polo at 400 times the price.
    /// </summary>
    public class Ferrari_Enzo_ZXX1 : ICarControls, ICarPerformance
    {
        short currentDirection = 0;
        /// <summary>
        /// A ferrari can turn really quickly
        /// </summary>
        readonly short wheelTurn = 45;
        const short MaxDegrees = 360;
     
        short currentSpeed = 0;
        /// <summary>
        /// And can accelerate very quickly and decelerat even more quickly
        /// </summary>
        readonly short acceleratorPress = 21;
        readonly short brakePress = -80;
        /// <summary>
        /// and has a top spped that is a little bit illegal
        /// </summary>
        readonly short FerraruMaxSpeed = 245;
        readonly short MinSpeed = 0;

        /* Properties and methods from ICarControls */

        public short DirectionInDegrees { get { return currentDirection; } }

        public short SpeedInMph { get { return currentSpeed; } }

        public void PressAccelerator()
        {
            currentSpeed = (short)Math.Min(FerraruMaxSpeed, currentSpeed + acceleratorPress);
        }

        public void PressBreak()
        {
            currentSpeed = (short)Math.Max(MinSpeed, currentSpeed + brakePress);
        }

        public void TurnWheelLeft()
        {
            currentDirection = (short)((currentDirection - wheelTurn) % MaxDegrees);
        }

        public void TurnWheelRight()
        {
            currentDirection = (short)((currentDirection + wheelTurn) % MaxDegrees);
        }

        /* Properties from ICarPerfornamce */

        public short MaxSpeed { get { return FerraruMaxSpeed; } }

        public short MaxSteeringLock { get { return wheelTurn; } }

        public short AccelerationPerSecond { get { return acceleratorPress; } }

        public short BrakingPerSecond { get { return brakePress; } }

        /* Object class overrides */
        public override string ToString()
        {
            return "I'm a Ferrari Enzo ZXX";
        }
    }
}
