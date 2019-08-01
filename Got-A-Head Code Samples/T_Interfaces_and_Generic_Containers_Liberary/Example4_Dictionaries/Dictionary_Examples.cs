using System;
using System.Collections.Generic;
using Xunit;
using Interfaces_and_Generic_Containers.Example1_Interfaces;

namespace T_Interfaces_and_Generic_Containers_Liberary.Example4_Dictionaries
{
    public class Dictionary_Examples
    {
        /* We can create references to an interface IList<strings>, essentially an arrray of ints.*/
        readonly IDictionary<string, ICarControls> my1DDictionary;
        readonly IDictionary<string, IDictionary<int, string>> my2DDictionary;

        readonly Polo polo = new Polo();
        readonly Ferrari_Enzo_ZXX1 ferrari = new Ferrari_Enzo_ZXX1();

        /// <summary>;
        /// 
        /// </summary>
        public Dictionary_Examples()
        {
        /* create our dictionaries and initialise them with some values.  N.B., dictionaries are lists of objects called Key Value Pairs.  In this case, the string is the key, and the car
         control is the value.  So we have to have an object initialiser within an object initialiser here where the intter brackets create the KeyValuePair objects.*/
            my1DDictionary = new SortedDictionary<string, ICarControls> {
                { "Alice", polo },
                { "White Rabbit", ferrari},
                { "Cheshire Cat", null},
                { "Mad Hatter", polo },
                { "March Hare", ferrari }
            };
            my2DDictionary = new SortedDictionary<string, IDictionary<int, string>> {
                /* Note the first inteeger key value is not 0.  It doesn't have to be */
                { "Alice", new SortedDictionary<int, string> { { 1, "fall down rabbit hole" }, { 2, "swim in her own tears" }, { 3, "nibble a mushroom" }, { 4, "play croquet" } } },
                { "White Rabbi", new SortedDictionary<int, string> { { 1, "run past Alice" }, { 2, "beat Alice to the garden" }, { 3, "grovel to the Queen" } } },
                { "Cheshire Cat", new SortedDictionary<int, string> { { 1, "grin" }, { 2, "disappear" } } },
                /* N.N the keys don't have to be sequential, they can be any value you like as long as they are unique.*/
                { "Mad Hatter", new SortedDictionary<int, string> { { 3, "Offer Alice some wine" }, { 27, "tell her they haven't got any" } } },
                { "March Hare", new SortedDictionary<int, string> { { -12, "dunk the doormouse" } } }
            };

        }

        [Fact]
        public void StringCarDictionaryTest()
        {

            /* check we have put five elements in.*/
            Assert.Equal(5, my1DDictionary.Count);

            /* iten 0 returns the value of the first element, which is Alice's Polo */
            Assert.Equal("I'm a Polo", my1DDictionary["Alice"].ToString());

            /* Note the string key is case sensitive*/
            Assert.False(my1DDictionary.ContainsKey("march hare"));

            /* Note the string key is case sensitive*/
            Assert.True(my1DDictionary.ContainsKey("March Hare"));

            /* will thrown an argument exceptiopn if we try to put the same key in twice. */
            Action act = () => { my1DDictionary.Add("March Hare", ferrari); };
            Assert.Throws<ArgumentException>(act);
            
            my1DDictionary.Add("Queen of Hearts", ferrari );

            /* check we have put six elements in.*/
            Assert.Equal(6, my1DDictionary.Count);

            /* check iten 6 is Mock Turtle */
            Assert.Equal("I'm a Ferrari Enzo ZXX", my1DDictionary["Queen of Hearts"].ToString());

            /* Use an enumerator to go through every element in the dictionary.  The key and value of the key value pairs in the dictionary are accessed by using its Key and Value properties */
            var myDictionaryEnumerator = my1DDictionary.GetEnumerator();

            Assert.True(myDictionaryEnumerator.MoveNext());
            Assert.Equal("Alice", myDictionaryEnumerator.Current.Key);
            Assert.Equal("I'm a Polo", myDictionaryEnumerator.Current.Value.ToString());

            /* Note, the dictionary is sorted so the White Rabbit is at the end despite being the second key added, and the value of the Cheshire Cat's key value pair is null */
            Assert.True(myDictionaryEnumerator.MoveNext());
            Assert.Equal("Cheshire Cat", myDictionaryEnumerator.Current.Key);
            Assert.Null(myDictionaryEnumerator.Current.Value);

            Assert.True(myDictionaryEnumerator.MoveNext());
            Assert.Equal("Mad Hatter", myDictionaryEnumerator.Current.Key);
            Assert.Equal("I'm a Polo", myDictionaryEnumerator.Current.Value.ToString());

            Assert.True(myDictionaryEnumerator.MoveNext());
            Assert.Equal("March Hare", myDictionaryEnumerator.Current.Key);
            Assert.Equal("I'm a Ferrari Enzo ZXX", myDictionaryEnumerator.Current.Value.ToString());

            Assert.True(myDictionaryEnumerator.MoveNext());
            Assert.Equal("Queen of Hearts", myDictionaryEnumerator.Current.Key);
            Assert.Equal("I'm a Ferrari Enzo ZXX", myDictionaryEnumerator.Current.Value.ToString());

            Assert.True(myDictionaryEnumerator.MoveNext());
            Assert.Equal("White Rabbit", myDictionaryEnumerator.Current.Key);
            Assert.Equal("I'm a Ferrari Enzo ZXX", myDictionaryEnumerator.Current.Value.ToString());

            Assert.False(myDictionaryEnumerator.MoveNext());

            my1DDictionary.Remove("White Rabbit");

            /* check we have five elements again.*/
            Assert.Equal(5, my1DDictionary.Count);

            /* Will throw a KeyNotFoundException if you try and access the dictionary with a key that doesn't exist, so check with the ContainsKey() function if you're note sure */
            Action act2 = () => { Assert.Equal("I'm a Ferrari Enzo ZXX", my1DDictionary["White Rabbit"].ToString()); };
            Assert.Throws<KeyNotFoundException>(act2);
        }

        [Fact]
        public void SrringIntString2DDictionaryTest()
        {

            /* check we have put five elements in.*/
            Assert.Equal(5, my2DDictionary.Count);

            /* check we have put four elements in Alice's dictxioary.*/
            Assert.Equal(4, my2DDictionary["Alice"].Count);

            /* check iten ["Alice][4] is to play croquet */
            Assert.Equal("play croquet", my2DDictionary["Alice"][4].ToString());

            /* N.B., we don't have to use a SortedDictionary<> type.  We can use any type that implements the IDictionary<> interface, int his case Dictionary<>.
             * Note the backwards ordering of the keys*/
            my2DDictionary.Add(
                "Queen of Hearts", 
                new Dictionary<int, string> { { 3, "orders 'off with their heads'"}, { 1, "orders 'off with their heads'" }, { 2, "orders 'off with their heads'" } } 
            );

            /* check we have put five elements in.*/
            Assert.Equal(6, my2DDictionary.Count);

            /* Use an enumerator to go through every element in the dictionary.  The key and value of the key value pairs in the dictionary are accessed by using its Key and Value properties */
            var myDictionaryEnumerator = my2DDictionary["Queen of Hearts"].GetEnumerator();

            /* Because we are not using a sorted dictionary the keys are stored differently, so this time when we enumerate through the dictionary the order of the keys
             * is as we put it into the dictionary, so 3, 2, 1 */
            Assert.True(myDictionaryEnumerator.MoveNext());
            Assert.Equal(3, myDictionaryEnumerator.Current.Key);
            Assert.Equal("orders 'off with their heads'", myDictionaryEnumerator.Current.Value.ToString());

            Assert.True(myDictionaryEnumerator.MoveNext());
            Assert.Equal(1, myDictionaryEnumerator.Current.Key);
            Assert.Equal("orders 'off with their heads'", myDictionaryEnumerator.Current.Value.ToString());

            Assert.True(myDictionaryEnumerator.MoveNext());
            Assert.Equal(2, myDictionaryEnumerator.Current.Key);
            Assert.Equal("orders 'off with their heads'", myDictionaryEnumerator.Current.Value.ToString());

            Assert.False(myDictionaryEnumerator.MoveNext());
        }
    }
}
