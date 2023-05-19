using System;
using System.Globalization;

namespace Lab1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Sum();
            // int[] num = { 15, 47, 12, 65, 48, 654, 987, 29, 647, 174 };
            // int[] num1 = { 15, 47, 12, 65, 48, 654, 987, 29, 647, 174 };

            //Array();
            //Char();

            //int s = New(num);
            // Console.WriteLine(s);
            //Replay();
        }
        static void Sum()
        {
            int[] num = { 15, 47, 12, 65, 48, 654, 987, 29, 647, 174 };
            int i = 0;
            int Sum1 = 0;
            int Sum2 = 0;
            for (i = 0; i < num.Length; i++)
            {
                if (num[i] > 9 && num[i] < 100 && num[i] % 2 == 1)
                {
                    Sum1 += num[i];
                }
                else if (num[i] > 99 && num[i] < 1000)
                {
                    Sum2 += num[i];
                }
               
            }
            Console.WriteLine(Sum2 - Sum1);
        }
        static int New(int[] num)
        {
            
            int i = 0;
            int Sum1 = 0;
            int Sum2 = 0;
            for (i = 0; i < num.Length; i++)
            {
                if (num[i] > 9 && num[i] < 100 && num[i] % 2 == 1)
                {
                    Sum1 += num[i];
                }
                else if (num[i] > 99 && num[i] < 1000)
                {
                    Sum2 += num[i];
                }

                
            }
           

            return Sum2 - Sum1;
        }
        static void Replay()
        {

            int[] num = { 1, 2, 3, 4, 5, 5 };
            int tekrar;

            for (int i = 0; i < num.Length; i++)
            {
                for(int j=0; j < num.Length; j++)
                {

                    if (i == j)
                    {
                        tekrar= i;


                    }
                }

            }
         
            Console.WriteLine(num);  


        }
        static void Array()
        {
            int[] nums = { 18, 15, 1987, 549, 112 };

            int sum = 0;

            for (int j = 0; j < nums.Length; j++)
            {
                sum = 0;
                int num = nums[j];

                while (num != 0)
                {

                    int lastDigit = (num % 10);
                    num = (num - lastDigit) / 10;


                    sum += lastDigit;

                }
                if (sum % 2 == 0)
                {
                    Console.WriteLine(nums[j]);
                    Console.WriteLine("cut reqemdir");


                } 



            }

        }
                
        static void Char()
        {
            Console.WriteLine("Char daxil et");
            char Str = 'H';
            string text= "Hello My Friend";

            for(int i=0; i<text.Length; i++)
            {
                if (text[i] == Str)
                {
                    Console.WriteLine("herf var");

                }

            }
            

        }


    }
}



