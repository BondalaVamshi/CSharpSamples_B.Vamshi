using System;

namespace CoditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("from switch");
            Switch switchO = new Switch();
            switchO.Find();
            Console.WriteLine("from if else");
            Console.WriteLine("enter your choice 1 for int \"i\" 2 fro any key \"k\" ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("enter a value for i");
                int i = Console.Read();
                if (i >= 65 && i <= 90)
                {
                    Console.WriteLine($"input is upper case");

                }
                else if (i >= 97 && i <= 122)
                {
                    Console.WriteLine($" is lower case");

                }
                else if (i >= 48 && i <= 57)
                {
                    Console.WriteLine("Number");
                    if (i % 2 == 0)
                    {
                        Console.WriteLine($" is even number");
                    }
                    else
                    {
                        Console.WriteLine($" is odd number");
                    }
                }
                else
                {
                    Console.WriteLine("No AlphaNumaric");
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("enter a value for k");
                char k = Convert.ToChar(Console.Read());
                if (char.IsUpper(k))
                {
                    Console.WriteLine("UPPER CASE");
                }
                else if (char.IsLower(k))
                {
                    Console.WriteLine("Lower case");
                }
                else if (char.IsDigit(k))
                {
                    Console.WriteLine("Number");
                }
                else
                {
                    Console.WriteLine("Nonn AlphaNumaric");
                    Console.WriteLine("Nonn AlphaNumaric");
                }
            }
            else
            {
                Console.WriteLine("enter 1 or 2");
            }




        }


    }
            
           
            
        
    
}
