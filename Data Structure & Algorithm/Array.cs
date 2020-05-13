
using System;

namespace Learn
{
    public class Array
    {
        private int[] items;
        private int count;
        private int[] commandItems;

        public Array(int size)
        {
            items = new int[size];
        }

        /// <summary>
        /// Insert a Items into the array
        /// <!--Complexity 0(n)-->
        /// </summary>
        /// <param name="value"></param>
        public void Add(int value)
        {
            if (count == items.Length)
            {
                // Create new array 
                int[] newArray = new int[count * 2];

                // copy old array items to new array 
                for (int i = 0; i < count; i++)
                {
                    newArray[i] = items[i];
                }
                // Apply new array to old array 
                items = newArray;
            }
            items[count] = value;

            count++;
        }

        /// <summary>
        ///  Return common items in the array and passed parameter array
        /// </summary>
        /// <!--Complexity 0(n)-->
        /// <param name="interArray"></param>
        /// <returns></returns>
        public int[] Intersect(params int[] interArray)
        {
            int arraySize = 0;
            commandItems = new int[count];

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < interArray.Length; j++)
                {
                    if (items[i] == interArray[j])
                    {
                        commandItems[arraySize] = items[i];
                        arraySize++;
                    }
                }
            }
            return commandItems;
        }


        /// <summary>
        /// remove items in specific section
        /// </summary>
        /// <!--Complexity O(n)-->
        /// <param name="index"></param>
        public void RemoveAt(int index)
        {
            // Validate index is Valid 
            if (index > 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException($"{index}", "Your index is not in the range");
            }
            for (int i = index; i < count; i++)
            {
                items[index] = items[index + 1];
            }
            count--;
        }

        /// <summary>
        /// return Index of value
        /// </summary>
        /// <param name="value"></param>
        /// <!--Complexity O(1) -->
        /// <returns></returns>
        public int IndexOf(int value)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Print Array Items
        /// <!--complexity O(n)-->
        /// </summary>
        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(items[i]);
            }
        }

        /// <summary>
        /// Find Higher value of this
        /// <!--Complexity O(n)-->
        /// </summary>
        /// <returns></returns>
        public int Max()
        {
            var max = -1;
            for (int i = 0; i < count; i++)
            {
                if (max <= items[i])
                {
                    max = items[i];
                }
            }
            return max;
        }
       
        /// <summary>
        /// Reverse items array
        /// </summary>
        public void ReverseArray()
        {
            int arrayStartCount = 0;

            // Create new Array 
            var reversedArray = new int[count];

            for (int i = count-1; i < count && i>=0; i--)
            {
                reversedArray[arrayStartCount] = items[i];
                arrayStartCount++;
            }
           
            items = reversedArray;
        }

        /// <summary>
        /// Change vaule in given index
        /// <!--Complexity O(1)-->
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        public void InsertAt(int index, int value)
        {
            if (index < 0 || index > items.Length)
                throw new ArgumentOutOfRangeException();

            items[index] = value;
        }
    }
}