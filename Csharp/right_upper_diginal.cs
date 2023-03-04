//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace program1
//{
//    internal class right_upper_diginal
//    {
//        static void Main()
//        {
//            int[,] x = new int[3, 3];
//            int i, j;
//            int sum = 0;
//            for(i = 0; i < 3; i++)
//            {
//                for(j = 0; j < 3; j++)
//                {
//                    Console.WriteLine("Enter elelments : ");
//                    x[i, j] = Convert.ToInt32(Console.ReadLine());
//                }
//            }
//            Console.WriteLine("Your right_uper diginal is : ");
//            for(i = 0; i < 3; i++)
//            {
//                for (j = 0; j < 3; j++)
//                {
//                    if (i + j == 2)
//                    {
//                        Console.Write($"{x[i, j]}\t");
//                        sum = sum + x[i, j];
//                    }
//                }
//                Console.Write("\n");
//            }
//            Console.WriteLine($"Sum of right diagonal : {sum}");
//        }
//    }
//}
