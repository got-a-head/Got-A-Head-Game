using Interfaces_and_Generic_Containers.Example1_Interfaces;
using Xunit;
using System.Collections.Generic;

namespace T_Interfaces_and_Generic_Containers_Liberary.Example2_Arrays
{
    /// <summary>
    /// 
    /// </summary>
    public class ArrayExamples
    {
        /* We can create references to an interface IList<int>, essentially an arrray of ints.*/
        readonly int[] my1DimensionalArray;
        readonly string[,] my2DimensionalArray;
        readonly ICarControls[,,] my3DimensionalArray;
        readonly Polo polo = new Polo();
        readonly Ferrari_Enzo_ZXX1 ferrari = new Ferrari_Enzo_ZXX1();

        /// <summary>
        /// 
        /// </summary>
        public ArrayExamples()
        {
            /* Mke my collection a list and initialise it with some values*/
            my1DimensionalArray = new int[] { 2, 4, 8, 31, 19 };
            my2DimensionalArray = new string[,] { { "doo", "dah", "doo", "dah" }, { "doe", "ray", "me", "far" }, { "sow", "la", "tea", "doe" } };
            my3DimensionalArray = new ICarControls[,,] { { { polo, ferrari } } };
        }


        [Fact]
        public void Int1DArrayTest()
        {

            /* check we have put five elements in.*/
            Assert.Equal(5, my1DimensionalArray.Length);

            /* check iten 0 is 2 */
            Assert.Equal(2, my1DimensionalArray[0]);

            /* check iten 0 is 2 */
            Assert.Equal(31, my1DimensionalArray[3]);

            my1DimensionalArray[3] = 37;

            /* check iten 0 is 2 */
            Assert.Equal(37, my1DimensionalArray[3]);
        }

        [Fact]
        public void String2DArrayTest()
        {

            /* check we have put 3x4 = 12 elements in.*/
            Assert.Equal(12, my2DimensionalArray.Length);

            /* check iten [1,3] is "far" */
            Assert.Equal("far", my2DimensionalArray[1,3]);

            /* check iten [2,0] is "sow" */
            Assert.Equal("sow", my2DimensionalArray[2,0]);

            my2DimensionalArray[2,0] = "Maria";

            /* check iten 0 is 2 */
            Assert.Equal("Maria", my2DimensionalArray[2, 0]);
        }

        [Fact]
        public void CarObject3DArrayTest()
        {

            /* check we have put 1x1x2 = 2 elements in.*/
            Assert.Equal(2, my3DimensionalArray.Length);

            /* check iten [0,0,0] is a Polo */
            Assert.Equal("I'm a Polo", my3DimensionalArray[0,0,0].ToString());

            /* check iten [0,0,1] is a Ferrari */
            Assert.Equal("I'm a Ferrari Enzo ZXX", my3DimensionalArray[0, 0, 1].ToString());

            my3DimensionalArray[0, 0, 0] = ferrari;

            /* check iten [0,0,0] is now a Ferrari */
            Assert.Equal("I'm a Ferrari Enzo ZXX", my3DimensionalArray[0, 0, 0].ToString());
        }
    }
}
