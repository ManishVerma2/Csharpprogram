//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace program1
//{
//    internal class lowerdignel
//    {
//        static void Main()
//        {
//            int[,] x = new int[3, 3];
//            int i, j;
//            for(i = 0; i < 3; i++)
//            {
//                for(j = 0; j < 3; j++)
//                {
//                    Console.WriteLine("Enter elements");
//                    x[i,j]= Convert.ToInt32(Console.ReadLine());
//                }
//            }
//            Console.WriteLine("Your lower_dignel is : ");
//            for (i = 0; i < 3; i++)
//            {
//                for (j = 0; j < 3; j++)
//                {
//                    if(i>=j)
//                    {
//                        Console.Write($"{x[i, j]}\t");
//                    }
//                }
//                Console.Write("\n");
//            }

//        }
//    }
//}
