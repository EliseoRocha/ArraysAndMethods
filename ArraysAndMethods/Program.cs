using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stop = false;
            int[] InputNums = new int[10];
            List<long> numbers = new List<long>();

            while (!stop)
            {
                byte minNum = 10;
                Console.WriteLine("\nPlease enter an integer, if you want to stop, enter 0.");
                string userValue = Console.ReadLine();
                
                if (userValue.ToLower() == "0")
                {
                    Console.WriteLine($"Youre average is {numbers.Average()}");
                    stop = true;
                }
                else
                {
                    long userNumber = Convert.ToInt64(Console.ReadLine());
                    numbers.Add(userNumber);
                    break;
                }
            }
        }
    }
}
