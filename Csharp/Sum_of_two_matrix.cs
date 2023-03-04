//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace program1
//{
//    internal class Sum_of_two_matrix
//    {
//        static void Main()
//        {
//            int[,] a = new int[3, 3];
//            int[,] b=new int[3, 3];
//            int[,] c = new int[3, 3];
//            int i, j;
//            //first matrix 
//            for(i=0; i<3; i++)
//            {
//                for(j=0; j<3; j++)
//                {
//                    Console.WriteLine( $"Enter 1st matrix {(i,j)} Number : ");
//                    a[i, j] = Convert.ToInt32(Console.ReadLine());
//                }
//            }
//            for (i = 0; i < 3; i++)
//            {
//                for (j = 0; j < 3; j++)
//                {
//                    Console.Write($"{a[i, j]}\t");
//                }
//                Console.Write("\n");
//            }

//            //2nd matrix
//            for (i = 0; i < 3; i++)
//            {
//                for (j = 0; j < 3; j++)
//                {
//                    Console.WriteLine($"Enter 2nd matrix {(i, j)} Number : ");
//                    b[i, j] = Convert.ToInt32(Console.ReadLine());
//                }
//            }
//            for (i = 0; i < 3; i++)
//            {
//                for (j = 0; j < 3; j++)
//                {
//                    Console.Write($"{b[i, j]}\t");
//                }
//                Console.Write("\n");
//            }

//            //sum of two matrix
//            Console.WriteLine("Sum of two matrix is : ");
//            for(i = 0; i < 3; i++)
//            {
//                for(j = 0; j < 3; j++)
//                {
//                    c[i, j] = a[i, j] + b[i, j];
//                    Console.Write($"{c[i, j]}\t");
//                }
//                Console.Write("\n");
//            }
//        }
//    }
//}
