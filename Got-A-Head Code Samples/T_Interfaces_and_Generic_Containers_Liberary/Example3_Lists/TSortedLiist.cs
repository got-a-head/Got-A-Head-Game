
using System.Collections.Generic;
using Xunit;
using ArmouryObjects.RucksackItems.Comparers;
using ArmouryObjects.RucksackItems;

namespace T_Interfaces_and_Generic_Containers_Liberary.Example3_Lists
{
    /// <summary>
    /// <a ref="https://stackoverflow.com/questions/935621/whats-the-difference-between-sortedlist-and-sorteddictionary/935631#935631">Here</a>
    /// is a useful stack overflow article on the differences between a SortedList and a SortedDictionary.
    /// <a ref="https://stackoverflow.com/questions/2036890/sortedlist-vs-sorteddictionary-vs-sort">This</a> one points out that if you do not need to maintain
    /// a sorted list while new adds and deletes are occuring you shouldn't use either of them. List&lt;x&gt; followed by Sort is  more efficient. 
    /// </summary>
    public class TSortedLiist
    {
        [Fact]
        public void SortedListTest()
        {
            var sortedList = new SortedList<IRucksackItem, IRucksackItem>();

            var sortedListByVolume = new SortedList<IRucksackItem, IRucksackItem>(new RucksackVolumeComparerr());
        }
    }
}
