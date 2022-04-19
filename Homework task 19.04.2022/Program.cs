using System;

namespace Homework_task_19._04._2022
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] numArr = { 15, 6, 9, 64, 58 };
            
            int max = numArr[0];
            for (int i = 0; i < numArr.Length; i++)
            {
                if (max < numArr[i])
                {

                    max = numArr[i];
                    Console.WriteLine("Arrayin icindeki en boyuk eded = " +numArr[i]);

                }
            }
        }


    }
}
