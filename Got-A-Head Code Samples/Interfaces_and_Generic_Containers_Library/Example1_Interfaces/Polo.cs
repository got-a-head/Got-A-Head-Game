
using System;

namespace Interfaces_and_Generic_Containers.Example1_Interfaces
{
    /// <summary>
    /// A class representing my polo that implements ICarControls
    /// </summary>
    public class Polo : ICarControls, ICarPerformance
    {
        short currentDirection = 0;
        /// <summary>
        /// My Polo turns very slowly
        /// </summary>
        readonly short wheelTurn = 15;
        readonly short MaxDegrees = 360;
    
        short currentSpeed = 0;
        /// <summary>
        /// And can't accelerate very much
        /// </summary>
        readonly short acceleratorPress = 1;
        readonly short brakePress = -1;
        /// <summary>
        /// and doesn't have a high top speed
        /// </summary>
        readonly short PoloMaxSpeed = 85;
        readonly short MinSpeed = 0;

        /* Properties and Methods from ICarControls */

        public short DirectionInDegrees { get { return currentDirection; } }

        public short SpeedInMph { get { return currentSpeed; } }

        public void PressAccelerator()
        {
            currentSpeed = (short) Math.Min(PoloMaxSpeed, currentSpeed + acceleratorPress);
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

        /* Properties from ICarPerformance */

        public short MaxSpeed { get { return PoloMaxSpeed; } }

        public short MaxSteeringLock { get { return wheelTurn; } }

        public short AccelerationPerSecond { get { return acceleratorPress; } }

        public short BrakingPerSecond { get { return brakePress; } }

        /* Object class overrides */
        public override string ToString()
        {
            return "I'm a Polo";
        }
    }
}
