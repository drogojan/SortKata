using System;
using System.Collections.Generic;

namespace SortKata
{
    internal class ListSorter
    {
        public ListSorter()
        {
        }

        internal List<int> BubbleSort(List<int> list)
        {
            int count = list.Count;
            if (count < 2)
                return list;

            bool sorted;
            do
            {
                sorted = true;
                for (int i = 0; i < count - 1; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        var temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                        sorted = false;
                    }
                }
                count--;
            } while (!sorted);

            return list;
        }

        internal List<int> QuickSort(List<int> list)
        {
            if (list.Count < 2)
                return list;

            var sorted = new List<int>();
            int firstElement = list[0];
            sorted.Add(firstElement);

            var smallerElements = new List<int>();
            var greaterElements = new List<int>();
            for (int i = 1; i < list.Count; i++)
            {
                int currentElement = list[i];
                if (firstElement > currentElement)
                {
                    smallerElements.Add(currentElement);
                }
                else
                {
                    greaterElements.Add(currentElement);
                }
            }
            sorted.InsertRange(0, QuickSort(smallerElements));
            sorted.AddRange(QuickSort(greaterElements));
            return sorted;
        }
    }
}