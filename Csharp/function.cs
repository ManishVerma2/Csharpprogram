//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace program1
//{
//    internal class function
//    {
//        static void Main()
//        {
//            msg();
//            sum(10, 20);
//            int f = fact(7);
//            Console.WriteLine("factrol is " + f);
//            Console.WriteLine("Enter 1st number : ");
//            int n1 = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter 2nd number : ");
//            int n2 = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine($"Before swap n1={n1} and n2={n2}");
//            swap(ref n1, ref n2);
//            Console.WriteLine($"After swap n1={n1} and n2={n2}");
//            int hindi, english, math, scince, sst, total, per;
//            hindi = 80;
//            english = 60;
//            math = 65;
//            scince = 70;
//            sst = 83;
//            result(hindi, english, math, scince, sst, out total, out per);
//            Console.WriteLine($"total number is : {total}");
//            Console.WriteLine($"percentage is : {per}");
//        }
//        static void msg()
//        {
//            Console.WriteLine("Hello User...");
//        }
//        static void sum(int x, int y)
//        {
//            int total;
//            total = x + y;
//            Console.WriteLine($"The sum {x} and {y} is " + total);
//        }
//        static int fact(int num)
//        {
//            int f = 1;
//            for (int i = 1; i <= num; i++)
//            {
//                f = f * i;
//            }
//            return f;
//        }
//        static void swap(ref int a, ref int b)
//        {
//            int c;
//            c = a;
//            a = b;
//            b = c;
//        }
//        static void result(int h, int e, int m, int sci, int sst, out int t, out int p)
//        {
//            t = h + e + m + sci + sst;
//            p = t / 5;
//        }
//    }
//}
