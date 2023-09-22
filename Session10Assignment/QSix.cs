//using System;
//using System.Collections.Generic;


//namespace Session10Assignment
//{
//    internal class QSix
//    {
//        class NPException : Exception
//        {
//            public NPException(string message) : base(message) { }
//        }

//        static void Main() {
//            Console.WriteLine("Enter a non-negative number:");
//            double num = double.Parse(Console.ReadLine());
//            if (num < 0)
//            {
//                try
//                {
//                    throw new NPException("Invalid input: Input number is negative.");
//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine(e.Message);
//                }
//            }
//            else {
//                Console.WriteLine(Math.Sqrt(num));
//            }
//        }
//    }
//}
