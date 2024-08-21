using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueTag_Task_4
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            // Start of the application
            Console.WriteLine("Start");

            // Get min, max, interval
            Console.Write("Enter minimum value: ");
            int min = int.Parse(Console.ReadLine());

            Console.Write("Enter maximum value: ");
            int max = int.Parse(Console.ReadLine());

            Console.Write("Enter interval: ");
            int interval = int.Parse(Console.ReadLine());

            // Check if the interval is valid
            switch ((max - min) % interval)
            {
                case 0:
                    {
                        int n = (max - min) / interval;
                        Console.WriteLine($"{n}");
                        int i = 1;
                        int sum = 0;
                        

                        // Calculate the sum
                        while (i <= n)
                        {
                            sum += min;
                            min += interval;
                            i++;
                        }

                        // Print the sum
                        Console.WriteLine("Sum: " + sum);
                        break;
                    }

                default:
                    // Print invalid interval message
                    Console.WriteLine("Invalid interval");
                    break;
            }

            // End of the application
            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
    

