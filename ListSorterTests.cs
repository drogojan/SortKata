using System.Collections.Generic;
using NUnit.Framework;

namespace SortKata
{
    public class ListSorterTests
    {
        static object[] SortTestCases = {
            new object[] { new List<int>(), new List<int>() },
            new object[] { new List<int> { 1 }, new List<int> { 1 } },
            new object[] { new List<int> { 1, 2 }, new List<int> { 1, 2 } },
            new object[] { new List<int> { 1, 2 }, new List<int> { 2, 1 } },
            new object[] { new List<int> { 1, 2, 3 }, new List<int> { 1, 2, 3 } },
            new object[] { new List<int> { 1, 2, 3 }, new List<int> { 2, 1, 3 } },
            new object[] { new List<int> { 1, 2, 3 }, new List<int> { 1, 3, 2 } },
            new object[] { new List<int> { 1, 2, 3 }, new List<int> { 3, 2, 1 } },
            new object[] { new List<int> { 1, 2, 3, 4, 5, 6 }, new List<int> { 3, 6, 2, 4, 1, 5 } },
        };

        [Test, TestCaseSource("SortTestCases")]
        public void Should_Sort_The_List_Ascending(List<int> expected, List<int> list)
        {
            ListSorter listSorter = new ListSorter();

            List<int> actual = listSorter.BubbleSort(list);

            CollectionAssert.AreEqual(expected, actual);
        }

        static object[] SortTestCases2 = {
            new object[] { new List<int>(), new List<int>() },
            new object[] { new List<int> { 1 }, new List<int> { 1 } },
            new object[] { new List<int> { 1, 2 }, new List<int> { 1, 2 } },
            new object[] { new List<int> { 1, 2 }, new List<int> { 2, 1 } },
            new object[] { new List<int> { 1, 2, 3 }, new List<int> { 1, 2, 3 } },
            new object[] { new List<int> { 1, 2, 3 }, new List<int> { 2, 1, 3 } },
            new object[] { new List<int> { 1, 2, 3 }, new List<int> { 1, 3, 2 } },
            new object[] { new List<int> { 1, 2, 3 }, new List<int> { 3, 2, 1 } },
            new object[] { new List<int> { 1, 2, 3, 4, 5, 6 }, new List<int> { 3, 6, 2, 4, 1, 5 } },
        };


        [Test, TestCaseSource("SortTestCases2")]
        public void Should_Sort_The_List_Ascending_When_Using_A_Transformation_With_A_Higher_Priority(List<int> expected, List<int> list)
        {
            ListSorter listSorter = new ListSorter();

            List<int> actual = listSorter.QuickSort(list);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}