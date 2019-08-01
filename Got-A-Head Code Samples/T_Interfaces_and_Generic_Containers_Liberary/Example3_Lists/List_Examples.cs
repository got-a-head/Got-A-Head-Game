using System;
using System.Collections.Generic;
using Xunit;
using Interfaces_and_Generic_Containers.Example1_Interfaces;

namespace T_Interfaces_and_Generic_Containers_Liberary.Example3_Lists
{
    /// <summary>
    /// N.B, the exception assertion was taken from <a href="https://stackoverflow.com/questions/45017295/assert-an-exception-using-xunit">this</a> Stack Overflow post
    /// </summary>
    public class List_Examples
    {
        /* We can create references to an interface IList<strings>, essentially an arrray of ints.*/
        readonly IList<string> myStringListn;
        readonly IList<IList<ICarControls>> myCarListofLists;
        readonly IList<IList<IList<int>>> myIntListofListOfLists;

        readonly Polo polo = new Polo();
        readonly Ferrari_Enzo_ZXX1 ferrari = new Ferrari_Enzo_ZXX1();

        /// <summary>;
        /// 
        /// </summary>
        public List_Examples()
        {
            /* create our lists and initialise them with some values*/
            myStringListn = new List<string> { "Alice", "White Rabbit", "Cheshire Cat", "Mad Hatter", "March Hare" };
            myCarListofLists = new List<IList<ICarControls>> { new List<ICarControls> { polo }, new List<ICarControls> { ferrari } };

            /* N.B. unlike arrays, you can have different numbers of elements in each column! Also note that we need to create new list<int> objects for the 1st and 2nd dimention with the new operator*/
            myIntListofListOfLists = new List<IList<IList<int>>> {
                new List<IList<int>> {
                    new List<int>  { 2, 4, 8, 10, 14 },
                    new List<int>  { 3, 6, 9, 12 }
                },
               new List<IList<int>> {
                    new List<int>  { 7, 21, 28, 35, 42, 49 },
               }
             };
        }

        [Fact]
        public void StringListTest()
        {

            /* check we have put five elements in.*/
            Assert.Equal(5, myStringListn.Count);

            /* check iten 0 is Alice */
            Assert.Equal("Alice", myStringListn[0]);

            myStringListn.Add("Mock Turtle");

            /* check we have put six elements in.*/
            Assert.Equal(6, myStringListn.Count);

            /* check iten 6 is Mock Turtle */
            Assert.Equal("Mock Turtle", myStringListn[5]);

            myStringListn.Remove("White Rabbit");

            /* check we have five elements again.*/
            Assert.Equal(5, myStringListn.Count);

            /* Use an enumerator to go through every element in the list */
            var myStringListEnumerator = myStringListn.GetEnumerator();

            Assert.True(myStringListEnumerator.MoveNext());
            Assert.Equal("Alice", myStringListEnumerator.Current);

            Assert.True(myStringListEnumerator.MoveNext());
            Assert.Equal("Cheshire Cat", myStringListEnumerator.Current);

            Assert.True(myStringListEnumerator.MoveNext());
            Assert.Equal("Mad Hatter", myStringListEnumerator.Current);

            Assert.True(myStringListEnumerator.MoveNext());
            Assert.Equal("March Hare", myStringListEnumerator.Current);

            Assert.True(myStringListEnumerator.MoveNext());
            Assert.Equal("Mock Turtle", myStringListEnumerator.Current);

            Assert.False(myStringListEnumerator.MoveNext());
        }

        [Fact]
        public void Car2DListsTest()
        {

            /* check we have put five elements in.*/
            Assert.Equal(2, myCarListofLists.Count);

            /* check we have put five elements in.*/
            Assert.Equal(1, myCarListofLists[0].Count);

            /* check iten [0][0] is a Polo */
            Assert.Equal("I'm a Polo", myCarListofLists[0][0].ToString());

            myCarListofLists.Add( new List<ICarControls> { ferrari, polo } );

            /* check we have put five elements in.*/
            Assert.Equal(3, myCarListofLists.Count);

            /* check we have put five elements in.*/
            Assert.Equal(2, myCarListofLists[2].Count);

            /* check iten [0][0] is a Polo */
            Assert.Equal("I'm a Ferrari Enzo ZXX", myCarListofLists[2][0].ToString());

        }

        [Fact]
        public void Int3DListsTest()
        {

            /* check we have put five, four and six elements at the third level lists.*/
            Assert.Equal(5, myIntListofListOfLists[0][0].Count);
            Assert.Equal(4, myIntListofListOfLists[0][1].Count);
            Assert.Equal(6, myIntListofListOfLists[1][0].Count);

            /* check a few elements in the structure.*/
            Assert.Equal(42, myIntListofListOfLists[1][0][4]);
            Assert.Equal(8, myIntListofListOfLists[0][0][2]);
            Assert.Equal(9, myIntListofListOfLists[0][1][2]);

            /* will thrown an argument out of range exception as there are only four times in the list myIntListofListOfLists[0][1] */
            Action act = () => { int i = myIntListofListOfLists[0][1][5]; };
            Assert.Throws<ArgumentOutOfRangeException>(act);

            /* Add some new elements */
            myIntListofListOfLists[0][0].Add(16);
            myIntListofListOfLists[0][1].Add(15);
            myIntListofListOfLists[0][1].Add(18);

            /* check a few elements in the structure.*/
            Assert.Equal(16, myIntListofListOfLists[0][0][5]);
            Assert.Equal(18, myIntListofListOfLists[0][1][5]);
            Assert.Equal(49, myIntListofListOfLists[1][0][5]);
        }

    }
}
