using System;
using Xunit;

namespace Interfaces_and_Generic_Containers.Example1_Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public class InterfaceTests
    {
        readonly Polo polo;

        /// <summary>
        /// 
        /// </summary>
        public InterfaceTests()
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
