//using System;
//using System.Collections.Generic;


//namespace Session10Assignment
//{
//    internal class QEight
//    {
//        public static void factorial(int num) {
//            long res = 1;
//            int temp = num;
//            if (temp == 1 || temp == 2) {
//                Console.WriteLine("The factorial of " + num + " is " + num);
//            }
//            while (temp > 1) { 
//                res *= temp;
//                temp--;
//            }
//            try
//            {
//                int res32 = int.Parse(res.ToString());
//                Console.WriteLine("The factorial of " + num + " is " + res32);
//            }
//            catch(OverflowException e) { 
//                Console.WriteLine("The factorial is tooooo large!");
//            }
//        }

//        static void Main() {
//            factorial(20);
//        }
//    }
//}
