//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Text;

//namespace BasicPrograms2
//{
//    internal class Prime1to100
//    {


//        //Write a C# program to find prime numbers from 1 to 100.
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Prime numbers between 1 to 100");
//            int n = 100;
//          for(int i = 1; i <= n; i++)
//            {
//                if (Prime(i))
//                {
//                    Console.WriteLine(i);
//                }

//            }
            
//        }
//        static bool Prime(int num)
//        {
//            for (int i = 2; i <= num/2; i++)
//            {
//                if (num % i == 0)
//                    return false;

//            }
//            return true;
            
//        }
      
//    }
//}
