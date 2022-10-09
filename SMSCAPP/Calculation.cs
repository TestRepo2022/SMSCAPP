using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSCAPP
{
    class Calculation
    {
      
        public static void FindArea()
        {
            Console.WriteLine("Enter Height ?");
            int h= Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter Width ?");
            int w= Int32.Parse(Console.ReadLine());

            int a = h * w;
            Console.WriteLine("Total Area="+a);

        }

        public static void Fun1()
        {
            int x = 20;
            if (x > 4)
            {
                Console.WriteLine("Hello");
                Console.WriteLine("Hi");
            }
        }

        public static void CheckEligiblity()
        {
            Console.WriteLine("Enter Your Age ?");
            int age = Int32.Parse(Console.ReadLine());

            if (age > 18)
            {
                Console.WriteLine("You are eligible for vote ....");
            }
            else
            {
                Console.WriteLine("You are not eligible, but you may eligible after {0} Year:",(18-age));
            }
        }
      
        public static void CheckMax()
        {

            Console.WriteLine("Enter First Number ?");
            int N1 = Int32.Parse(Console.ReadLine());


            Console.WriteLine("Enter Second Number ?");
            int N2 = Int32.Parse(Console.ReadLine());


            Console.WriteLine("Enter Third Number ?");
            int N3 = Int32.Parse(Console.ReadLine());

            int max = 0;
            if (N1 > N2 && N1 > N3)
                max = N1;
            else if (N2 > N1 && N2 > N3)
                max = N2;
            else
                max = N3;

            Console.WriteLine("Max is: "+max);
        }

        public static void ValidateMobile()
        {
            Console.WriteLine("Enter Mobile Number ?");
            string mobile = Console.ReadLine();

            if (mobile.Length == 10)
            {
                if(mobile.StartsWith("9")|| mobile.StartsWith("8") || mobile.StartsWith("7"))
                {
                    Console.WriteLine("Valid mobile number !");
                }
                else
                {
                    Console.WriteLine("Mobile number must be start with 9/8/7");
                }
            }
            else
            {
                Console.WriteLine("Please enter 10 digit mobile number only !");
            }
        }

        public static void CalculateDiscount()
        {
            Console.WriteLine("Enter Amount ?");
            int amount = Int32.Parse(Console.ReadLine());

            int discount = 0, resetAmount = 0;
            if (amount >= 10000)
            {
                discount = amount * 25 / 100;
                resetAmount = amount - discount;

            }
            else if(amount>=5000 && amount < 10000)
            {

                discount = amount * 15 / 100;
                resetAmount = amount - discount;
            }
            else if(amount>=2000 && amount < 5000)
            {
                discount = amount * 10 / 100;
                resetAmount = amount - discount;
            }
            else
            {
                discount = amount * 2 / 100;
                resetAmount = amount - discount;
            }

            Console.WriteLine("Your total discount : "+discount);
            Console.WriteLine("Please you pay {0} rs , rest Amount",resetAmount);
        }
    }
}
