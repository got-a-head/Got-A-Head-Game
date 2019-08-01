using Interfaces_and_Generic_Containers.Example1_Interfaces;
using System.Collections.Generic;
using Xunit;
using XUnitUtils;

namespace T_Interfaces_and_Generic_Containers_Liberary.Example1_Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public class InterfaceTestWithPolo
    {
        /* We can create references to an interface*/
        readonly ICarControls someCar;
        readonly ICarPerformance carPerfornamce;

        /// <summary>
        /// 
        /// </summary>
        public InterfaceTestWithPolo()
        {
            /* and then assign an object to them*/
            someCar = new Polo();
            carPerfornamce = new Polo();
        }

    
        [Fact]
        public void TurnLeftTest()
        {
            /* we can then use our interface car controls, to turn the wheel left on the polo*/
            someCar.TurnWheelLeft();

            /* we then use the car performance interface to check that the polo is now pointing in the right direction.*/
            Assert.Equal(-carPerfornamce.MaxSteeringLock, someCar.DirectionInDegrees);
        }
        [Fact]
        public void TurnRightTest()
        {
            someCar.TurnWheelRight();
             Assert.Equal(carPerfornamce.MaxSteeringLock, someCar.DirectionInDegrees);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="carControls"></param>
        /// <param name="testDescription"></param>
        /// <param name="expectedPerformance"></param>
        [Theory]
        [MemberData(nameof(CarModelData))]
        public void TurnLeftTheory(ICarControls someCar, ICarPerformance carPerfornamce, string testDescription)
        {
            someCar.TurnWheelLeft();
            Assert.True(-carPerfornamce.MaxSteeringLock == someCar.DirectionInDegrees, testDescription);
        }

        public static IEnumerable<object[]> CarModelData
        {
            get
            {
                var data = new List<ITheoryDatum>();

                data.Add(TheoryDatum<ICarControls, ICarPerformance>.Factory(new Polo(), new Polo(), "Polo Test"));
                data.Add(TheoryDatum<ICarControls, ICarPerformance>.Factory(new Ferrari_Enzo_ZXX1(), new Ferrari_Enzo_ZXX1(), "Ferrari Test"));

                return data.ConvertAll(d => d.ToParameterArray());
            }
        }


    }
}
