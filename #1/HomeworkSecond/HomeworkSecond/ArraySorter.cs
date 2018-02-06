using System;

namespace HomeworkSecond
{
    public class ArraySorter
    {
        // TODO : Sort array ascending order. Use loop of your choice.
        public int[] SortArrayAsc(int[] arr)
        {
            //vadinasi bubble sort

            int size = arr.Length;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        //Swap the elements
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            } return arr;
        }

        // TODO : Sort array descending order. Use loop of your choice.
        public int[] SortArrayDesc(int[] arr)
        {


            int size = arr.Length;

            for (int i = 0; i < size; i++)
            {
                for (int j = i; j < size ; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        //Swap the elements
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }return arr;
        }
    }
}


     

