//using System;
//using System.Collections.Generic;


//namespace Session10Assignment
//{
//    internal class QThree
//    {
//        static void Main() {
//            List<int> nums = new List<int>();

//            try
//            {
//                Console.WriteLine("Input a list of Integers one by one.");
//                while (true)
//                {
//                    string input = Console.ReadLine();
//                    if (input == "")
//                    {
//                        break;
//                    }
//                    int num = int.Parse(input);
//                    nums.Add(num);
//                }
//                Console.WriteLine("Your input list of intergers are");
//                foreach (int i in nums)
//                {   
//                    Console.Write(i + " ");
//                }
//            }
//            catch (FormatException)
//            {
//                Console.WriteLine("Invalid Input: You need to enter an integer.");
//            }
//            catch (OverflowException) {
//                Console.WriteLine("Out of bound Error: Your input is outside the range of int32.");
//            }
//        }
        


//    }
//}
