using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int number;
            string name;
            string answer;


            // input

            Console.WriteLine("what's your name?");
            name = Console.ReadLine();
            do { 
            Console.WriteLine($"{name} enter an integer between 1 and 100");



            //  processing

            // validation

            while (!int.TryParse(Console.ReadLine(), out number) || !(number >= 1 && number <= 100))
            {
                
                
                Console.WriteLine($" please {name} enter an integer within the range");

            }


            
            

            
                if (number % 2 == 0)
                {
                    if (number > 2 && number < 25)
                    {
                        Console.WriteLine($"{name} Even and less than 25");
                    }
                    else
                    {
                        Console.WriteLine($"{name} {number} an Even ");
                    }

                }
                else
                {
                    if (number > 2 && number < 25)
                    {
                        Console.WriteLine($"{name} Odd and less than 25");
                    }
                    else
                    {
                        Console.WriteLine($"{name} {number} and  Odd ");
                    }

                }
                Console.WriteLine("Continue?(y/n)");
                answer = Console.ReadLine();
                if (answer == "n" || answer == "N")
                {
                    Console.WriteLine($"Bye {name}");
                    Console.ReadLine();
                    break;



                }
            }
            while (answer == "Y" || answer == "y");
            


        }
        }
    }

