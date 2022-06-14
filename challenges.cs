using System;

namespace Challenges {
    // class EulerProblem1 {
    //     static void Main(string[] args)
    //     {
    //         int[] multiples = {3, 5};
    //         int sum = 0;
    //         for (int i = 0; i < 1000; i++)
    //         {
    //             if((i % 3 == 0) || (i % 5 == 0)) {
    //                 Console.WriteLine(i);
    //                 sum = sum + i;
    //             }
    //         }
    //         Console.WriteLine(sum);
    //     }
    // }
    // class EulerProblem2 {
    //     static void Main(string[] args)
    //     {
    //         int[] fibonacci = new int[50];
    //         fibonacci[0] = 1;
    //         fibonacci[1] = 2;
    //         for (int i = 0; i < 40; i++)
    //         {
    //             if (fibonacci[i] + fibonacci[i + 1] < 4000000)
    //             {
    //                 fibonacci[i + 2] = fibonacci[i] + fibonacci[i + 1];
    //             } else {
    //                 break;
    //             }
                
    //         }
    //         int sum = 0;
    //         foreach (int num in fibonacci)
    //         {
    //             if ((num != 0) && (num % 2 == 0)) {
    //                 Console.WriteLine(num);
    //                 sum = sum + num;
    //             }
    //         }
    //         Console.WriteLine(sum);
    //     }
    // }
    class EulerProblem34 {
        static void Main(string[] args) {
            // For each number from 3 to 1mil
            // Split number into individual digits
            // Factorial each digit and find the sum
            // Compare sum to original number and add to Array if equal
            int totalSum = 0;
            for (int i = 3; i < 1000000; i++)
            {
                string num = i.ToString();
                for (int j = 0; j < num.Length; j++) // For each letter in num
                {
                    int currentNum = Convert.ToInt32(Char.GetNumericValue(num[j]));
                    int currentNumsSum = currentNum;
                    for (int k = currentNum - 1; k > 0; k--)
                    {
                        currentNumsSum *= k;

                    }
                    if (num == currentNumsSum.ToString()) {
                        Console.WriteLine(num);
                    }
                }
            }
            Console.WriteLine(totalSum);
        }
    }
}