using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    internal class Digit_to_word
    {
        public static void Main()
        {
            int num;
            Console.WriteLine("Enter your Digit : ");
            num = Convert.ToInt32(Console.ReadLine());
            if(num>=0 && num<=9)
            {
                word w = (word)num;
                Console.WriteLine($"{w}");
            }
            else if(num>=10 && num<=19)
            {
                ten t = (ten)num;
                Console.WriteLine($"{t}");
            }
            else if (num >= 20 && num <= 99)
            {
                int temp = num % 10;          //num 55, temp=55%10(55/10=5) moduls=5
                hundred h = (hundred)num - temp;  //55-5=50;
                word w = (word)temp;          //5
                if (temp == 0)
                {
                    Console.WriteLine($"{h}");
                }
                else
                {
                    Console.WriteLine($"{h} {w}");
                }
            }
            else if (num >= 100 && num <= 999)
            {
                int temp = num % 100;     //num 555,temp=55%100(555/100)=55 modiles=55
                int sum = num - temp;   //555-55=500
                int first = sum / 100;  //500/100=5
                int firstvalue = sum / first; //500/5=100;
                word w = (word)first;
                thousant th = (thousant)firstvalue;

                if(temp>=0 && temp<=9)
                {
                    word b= (word)temp; 
                    ten t = (ten)temp;
                    Console.WriteLine($"{w} {th} {b}");
                }
                else if (temp >= 10 && temp <= 19)
                {
                    ten t = (ten)temp;
                    Console.WriteLine($"{w} {th} {t}");
                }
                else if (temp == 00)
                {
                    Console.WriteLine($"{w} {th}");
                }
                else if (temp >= 20 && temp <= 99)
                {
                    int last = temp % 10;   
                    int m=temp - last;
                    hundred y = (hundred)m;  
                    word l = (word)last;         
                    if (last == 0)
                    {
                        Console.WriteLine($"{w} {th} {y}");
                    }
                    else
                    {
                        Console.WriteLine($"{w} {th} {y} {l}");
                    }
                }
            }
            else if(num>=1000 && num<=9999)
            {
                int temp = num % 1000;       //5555&1000=555
                int sum =num - temp;          //5555-555=5000
                int first = sum / 1000;      //5000/1000=5
                int firstvalue = sum / first;//5000/5=1000
                word w = (word)first;
                thousant th=(thousant)firstvalue;
                Console.WriteLine($"{w} {th}");
            }
        }
    }
}
