using System;
using System.Collections.Generic;
using System.Text;


/*
 * inputArray=[0,2,3]
 * targetSum=5
 * outputArray=[1,2]
 */
namespace CodingPractiseSolution
{
    public class TwoSumArray
    {    
        public static void Main(string[] args)
        {
            Console.WriteLine("Two Sum Array");

            Console.WriteLine("Enter Size of array");
            int sizeOfArray = 0;
            sizeOfArray=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Input Array Elements");            
            int[] inputArray = new int[sizeOfArray];
            for(int i=0;i<sizeOfArray;i++)
                inputArray[i]= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Target Sum");
            int targetSum= Convert.ToInt32(Console.ReadLine());

            int[] outputArray = new int[sizeOfArray];

            outputArray = TwoSumArray.twoSumArray(inputArray,targetSum);
            Console.Write("Two sum array elements indexs are [");
            for(int k=0;k<outputArray.Length;k++)
            {
                Console.Write(" "+outputArray[k] );
            }
            Console.Write(" ]");

        }

        public static int[] twoSumArray(int[] nums,int target) 
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for(int j = i + 1; j < nums.Length; j++) 
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            throw new ArgumentException("Invalid Input");
        }
    }
}
