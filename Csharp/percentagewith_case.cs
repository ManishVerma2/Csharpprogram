//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace program1
//{
//    internal class percentagewith_case
//    {
//        static void Main()
//        {
//            int n1, n2, n3, n4, n5, per;
//            Console.WriteLine("Enter five subject marks : ");
//            n1 = Convert.ToInt32(Console.ReadLine());
//            n2= Convert.ToInt32(Console.ReadLine());
//            n3 = Convert.ToInt32(Console.ReadLine());
//            n4 = Convert.ToInt32(Console.ReadLine());
//            n5 = Convert.ToInt32(Console.ReadLine());
//            per = (n1 + n2 + n3 + n4 + n5) * 100 / 500;
//            Console.WriteLine($"Percentage is : {per}");
//            switch (per) 
//            {
//                case >= 100:
//                    Console.WriteLine("invalid input");
//                    break;
//                case  <= 100 and  >= 85:
//                    Console.WriteLine("merit");
//                    break;
//                case  <= 84 and  >= 60:
//                    Console.WriteLine("1st devision");
//                    break;
//                case <= 59 and  >= 45:
//                    Console.WriteLine("2nd devision");
//                    break;
//                case <= 44 and >= 33:
//                    Console.WriteLine("3rd devision");
//                    break;
//                default:
//                    Console.WriteLine("fail");
//                    break;
                
//            }

//        }
//    }
//}
