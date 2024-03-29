﻿namespace ArrayStudy.OparationArrays
{
    internal class ArrayOrder
    {

        public void BubbleSortOrder(ref int[] array)
        {
            int previousValue;
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array.Length - 1; j++)
                {
                    if(array[j] > array[j + 1])
                    {
                        previousValue = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = previousValue;
                    }
                }
            }
        }
        public void ArrayPrint(int[] array)
        {
            string line = string.Join(", ", array);
            Console.WriteLine(line);
        }
        public void SortOrder(ref int[] array)
        {
            Array.Sort(array);
        }
    }
}
