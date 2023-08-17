using System;

namespace Bubble_Sort_Algorithm
{

    // this will come up in interview so learn it
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 6, 5, 1, 7, 2, 4 };
            int[] sortedArray = BubbleSort(intArray);
            foreach(var i in sortedArray)
            {
                   Console.WriteLine(i);
            }
            
        }
       public static int[] BubbleSort(int[] array)
        {
            // hold the temp value for the swap. Think of it as state
            int temp = 0;
            // this will iterte over the entire loop many times
            for(int pointer =0; pointer < array.Length; pointer++)
            {
                // this will be for comapring and sorting
                for(int sort = 0; sort < array.Length - 1; sort++)
                {
                    // this checks to see if left side is larger than the right
                    if(array[sort] > array[sort + 1])
                    {
                        // swap 
                        // we store the var as temp so we dont over right it  when we swap 
                        temp = array[sort + 1];
                        // this puts the left var in the right
                        array[sort + 1] = array[sort];

                        // we put the right var in the left
                        array[sort] = temp;
                    }
                }
            }
            return array;
        }
    }
}
