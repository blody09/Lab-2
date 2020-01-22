using System;

namespace Assignment1_blake
{
    class Program
    {
        static void Main(string[] args)
        {
            
            char input = 'y';

            while (input == 'y')
            {
                decimal area = 0.0m;
                decimal perimeter = 0.0m;
                Console.WriteLine("What is the length of the classroom?");
                decimal length = decimal.Parse(Console.ReadLine());

                Console.WriteLine("What is the width of the classroom?");
                decimal width = decimal.Parse(Console.ReadLine());

                area = (length * width);
                Console.WriteLine($"The area of the classroom is {area}.");

                perimeter = (2 * (length + width));
                Console.WriteLine($" The perimeter of the classroom is {perimeter}.");

                Console.WriteLine("Would you like to continue? y or n?");
                input = char.Parse(Console.ReadLine());


               
                    }
            Console.WriteLine("Please Run again.");
            
                }


            }
            
            



        }
  
