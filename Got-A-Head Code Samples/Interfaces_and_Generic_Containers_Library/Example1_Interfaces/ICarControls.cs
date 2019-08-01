
namespace Interfaces_and_Generic_Containers.Example1_Interfaces
{
    /// <summary>
    /// A demonstration interface that has controls of a car and two properties showing speed and direction.
    /// Uf tiy are like me, you don't really care what sort of car you have, as long as you have something
    /// that gets you from A to B.  Other people like only fast cars or slow cars, but I don't care.
    /// 
    /// I can apply ICarControls to any object and it will allow me to 'drive' it; i.e. use in in a routing that requiers me to control a car, silly but it works as a demonstration.
    /// </summary>
    public interface ICarControls
    {
        /// <summary>
        /// Shows the direction the car is going, 0 being north 90 being east and so on.  Is always between 0 and 359
        /// </summary>
        short DirectionInDegrees { get; }

        /// <summary>
        /// Speed in MPH, always between 0 and MaxSpeed
        /// </summary>
        short SpeedInMph { get; }

        /// <summary>
        /// Allows you to turn th wheel left
        /// </summary>
        void TurnWheelLeft();

        /// <summary>
        /// Allows you to turn the wheel right
        /// </summary>
        void TurnWheelRight();

        /// <summary>
        /// Spped sthe car up
        /// </summary>
        void PressAccelerator();

        /// <summary>
        /// Slows the car down.
        /// </summary>
        void PressBreak();

    }
}
