using System;

namespace LoopLearning
{
    public class Loops
    {
        public static void Run()
        {
            int[] numArr = new int[5] { 1, 2, 3, 4, 5 };
            //index out of bound expection when we access the array outside of index

            // Its an DateTime obj
            DateTime startTime = DateTime.Now;
            Console.WriteLine((DateTime.Now - startTime).TotalSeconds);


            for (int i = 0; i < numArr.Length; i++)
            {
                Console.WriteLine(numArr[i]);
            }

            int sumOfArr = 0;

            //Very iemuerable
            foreach (int i in numArr)
            {
                sumOfArr = sumOfArr + i;
                Console.WriteLine(i);
            }
            Console.WriteLine(sumOfArr);

            // numArr.Sum(); // this also use sum the array but its lower

            //for loop better direct access, for each loop faster than the for loop, while loop faster than the foreach loop


            // while(condition){
            //Statement
            // }

            // do{

            // } while(condition);

            int totalValues = 0;

            totalValues = SumOfArr(numArr);

            Console.WriteLine(totalValues);

        }

        private static int SumOfArr(int[] arr)
        {

            int a = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                a += arr[i];
            }

            Console.WriteLine(a);
            return a;
        }
    }
}