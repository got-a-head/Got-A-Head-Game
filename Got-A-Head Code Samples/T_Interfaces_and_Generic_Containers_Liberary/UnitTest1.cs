using Interfaces_and_Generic_Containers.Example1_Interfaces;
using System;
using Xunit;

namespace T_Interfaces_and_Generic_Containers_Liberary
{
    public class UnitTest1
    {
        readonly Polo polo;

        /// <summary>
        /// 
        /// </summary>
        public UnitTest1()
        {
            polo = new Polo();
        }

        [Fact]
        public void TurnLeftTest()
        {
            polo.TurnWheelLeft();
            Assert.Equal(-15, polo.DirectionInDegrees);
        }
        [Fact]
        public void TurnRightTest()
        {
            polo.TurnWheelRight();
            int output = polo.DirectionInDegrees;
            Assert.Equal(15, output);
        }
    
    }
}
