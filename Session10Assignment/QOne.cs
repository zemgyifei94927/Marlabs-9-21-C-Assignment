//namespace Session10Assignment
//{
//    internal class QOne
//    {
//        class NPException : Exception
//        {
//            public NPException(string message) : base(message) { }
//        }

//        // Q1
//        public static float calAverage(int[] nums)
//        {
//            int n = nums.Length;
//            if (n == 0)
//            {
//                try
//                {
//                    throw new NPException("Empty array exception: Input array is Empty");
//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine(e.Message);
//                }
//            }
//            float sum = 0;
//            for (int i = 0; i < n; i++)
//            {
//                sum += nums[i];
//            }
//            return sum / n;
//        }

//        // Q2

//        static void Main(string[] args)
//        {
//            int[] nums1 = { 1, 2, 3, 4, 5 };
//            Console.WriteLine(calAverage(nums1));

//            int[] nums2 = { };
//            calAverage(nums1);
//        }
//    }
//}