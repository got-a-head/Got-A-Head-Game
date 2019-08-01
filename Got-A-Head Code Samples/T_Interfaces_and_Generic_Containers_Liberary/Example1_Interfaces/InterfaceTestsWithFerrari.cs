using Interfaces_and_Generic_Containers.Example1_Interfaces;
using Xunit;
using XUnitUtils;

namespace T_Interfaces_and_Generic_Containers_Liberary.Example1_Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public class InterfaceTestsWithFerrari
    {
        /* We can create references to an interface*/
        readonly ICarControls someCar;
        readonly ICarPerformance carPerfornamce;

        /// <summary>
        /// 
        /// </summary>
        public InterfaceTestsWithFerrari()
        {
            /* and then assign an object to them, this time a Ferrari object*/
            someCar = new Ferrari_Enzo_ZXX1();
            /* as someCar actually points to a Ferrari, even though it is types as an ICarControl, we can cast it to the other interface this object supports.*/
            carPerfornamce = (ICarPerformance)someCar;
        }


        [Fact]
        public void PedalToTheMetalTest()
        {
            short noOfPedalPressesToHitMaxSpeed = (short) ( ( carPerfornamce.MaxSpeed / carPerfornamce.AccelerationPerSecond ) + 1 );
            /* we can then use our interface car controls, to turn the wheel left on the Ferrrari*/

            for( int i = 0; i < noOfPedalPressesToHitMaxSpeed; i++ )
            {
                someCar.PressAccelerator();
            }
            /* we then use the car performance interface to check that the Ferrrari is now pointing in the right direction.*/
            Assert.Equal(carPerfornamce.MaxSpeed, someCar.SpeedInMph);
        }

    }
}
