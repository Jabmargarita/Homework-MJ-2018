using System;

namespace HomeworkFirst
{
    public class Program
    {
        static void Main(string[] args)
        {
            // TODO: write code to ask for input array of numbers, then which number we want to find
            // and then output first and last occurrences into console

            
            int[] items = new int[5];
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine("Please enter your number: ");
                items[i] = Convert.ToInt32(Console.ReadLine());
              
            }
                        
            Console.WriteLine("Which number you want to find?");
            int numberToFind = Convert.ToInt32(Console.ReadLine());

            int index = LastIntegerIndex(items, numberToFind);
            if (index != -1)
            {
                Console.WriteLine("Number " + numberToFind + " is at " + index +" index");
            }
           
            Console.ReadKey();
            
        }

        // TODO : Find index of first occurrence in integer array. Solve using loop of your choice.
        public static int LastIntegerIndex(int[] items, int numberToFind)

        {
            
            for (int i = items.Length - 1; i>=0; i--)
            {
                if (numberToFind == items[i])
                {
                    return i;
                }
            }




            //pazymim kur gali buti mano numberToFind in the array
            int low = 0;
            int high = items.Length - 1;
            int result = -1;
            while (low <= high)
            {
                int middle = (low + high) / 2;
                if (numberToFind == items [middle])
                {
                    result = middle;
                    high = middle - 1;
                    
                } else if (numberToFind < items [middle]) //numberToFind yra before mid
                {
                    high = middle - 1;
                } else
                {
                    low = middle + 1;
                }
            } return result;
        }

    
        // TODO : Find index of last occurrence in given array. Solve using loop of your choice.
        public static int FirstIntegerIndex(int[] items, int numberToFind)
        {

            for (int i = 0; i < items.Length; i++)
            {
                if (numberToFind == items[i])
                {
                    return i;
                }
            }
          
            int low = 0;
            int high = items.Length - 1;
            int result = -1;
            while (low <= high)
            {
                int middle = (low + high) / 2;
                if (numberToFind == items[middle])
                {
                    result = middle;
                    low = middle + 1;

                }
                else if (numberToFind < items[middle]) 
                {
                    high = middle - 1;
                }
                else
                {
                    low = middle + 1;
                }
            }
            return result;
        }
    }
}




//binary search condition - turi buti sorted array!
//testas kodel neveikia?