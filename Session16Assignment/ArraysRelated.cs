using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session16Assignment
{
    
    internal class ArraysRelated
    {
        static void Main()
        {   

            
            ArrayList myList = new ArrayList();
            myList.Add(1);
            myList.Add(2);

            // Fixed size ArrayList
            ArrayList fixedSizedList = ArrayList.FixedSize(myList);
            try
            {
                fixedSizedList.Add(3);
            }
            catch(Exception e) {
                Console.WriteLine("Displaying Exception: \n" + e.ToString()) ;
            }
            Console.WriteLine("press anykey to continue....");
            Console.WriteLine("__________________________");
            Console.ReadKey();

            // AddRange
            Console.WriteLine();
            Console.WriteLine("Before AddRange: ");
            foreach (int i in myList)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("After AddRange: ");
            myList.AddRange(fixedSizedList);
            foreach (int i in myList) {
                Console.Write(i + " ");            
            }
            Console.WriteLine();
            Console.WriteLine("press anykey to continue....");
            Console.WriteLine("__________________________");
            Console.ReadKey();

            //Sort and BinarySearch
            int[] myArray = new int[] { 17, 4, 3, 2, 6, 7, 12, 9, 10, 13, 8, 15, 1 };
            Console.WriteLine();
            Console.WriteLine("Current Array.");
            foreach (int i in myArray) {
                Console.Write(i + " ");
            }
            Array.Sort(myArray, 0, myArray.Length, StringComparer.CurrentCulture);
            Console.WriteLine();
            Console.WriteLine("Sorted Array.");
            foreach (int i in myArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            int index = Array.BinarySearch(myArray, 0, myArray.Length, 5, StringComparer.CurrentCulture);
            if (index < 0) { 
                Console.WriteLine("Did not find the element!") ;
            }
            index = Array.BinarySearch(myArray, 0, myArray.Length, 17, StringComparer.CurrentCulture);
            if (index >= 0)
            {
                Console.WriteLine($"Element is at index {index}");
            }
            Console.WriteLine("press anykey to continue....");
            Console.WriteLine("__________________________");
            Console.ReadKey();

            // Shallow copy from clone
            Car car1 = new Car("BoBoBo...");
            Car car2 = new Car("DoomDoomDoom...");
            Car car3 = new Car("VROOOOOOOOOM...");
            Car[] cars = new Car[] { car1, car2 , car3};
            Console.WriteLine();
            Console.WriteLine("Initial cars' names:");
            foreach (Car car in cars)
            {
                Console.WriteLine("Car name is "+ car.Name);
            }
            Car[] cars2 = (Car[])cars.Clone();
            car1.Name = "AOAOAO...";
            Console.WriteLine("Changed cars' names:");
            foreach (Car car in cars2)
            {
                Console.WriteLine("Car name is " + car.Name);
            }
            Console.WriteLine("press anykey to continue....");
            Console.WriteLine("__________________________");
            Console.ReadKey();
        }

        class Car {
            public string Name;
            public Car(string Name) { 
                this.Name = Name;
            }
        }
    }
}
