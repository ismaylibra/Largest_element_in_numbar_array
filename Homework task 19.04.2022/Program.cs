using System;

namespace Homework_task_19._04._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrayin uzunlugunu daxil edin: ");
            int numArrLength = Convert.ToInt32(Console.ReadLine());
            int[] numArr = new int[numArrLength];
            int i, max;
           

            max = numArr[0];
            Console.WriteLine("Verilmis uzunluqdaki arrayin icindeki elementleri  daxil edin: ", numArrLength);
            for ( i = 0; i < numArrLength; i++)
            {
                Console.WriteLine(i+0 +" nomreli element: ");
                numArr[i] = Convert.ToInt32(Console.ReadLine());

                if (max < numArr[i])
                {

                    max = numArr[i];
                    

                }
            }
            Console.WriteLine("Arrayin icindeki en boyuk eded = " + max);
        }


    }
}
