using System;
using System.Collections.Generic;
using System.Text;

namespace Loops
{
    class DoWhlie
    {

        
        public void FindValue()
        {
            string reChoice = "";
            do
            {


                //Console.WriteLine("from switch");
                Console.WriteLine("enter your choice 1 for int \"i\" 2 fro any key \"k\" ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("enter a value for i");
                        int i = Console.Read();
                        if (i >= 65 && i <= 90)
                        {
                            Console.WriteLine($"input is upper case");

                        }
                        else if (i >= 97 && i <= 122)
                        {
                            Console.WriteLine($"input is lower case");

                        }
                        else if (i >= 48 && i <= 57)
                        {
                            Console.WriteLine("Number");
                            if (i % 2 == 0)
                            {
                                Console.WriteLine($"input is even number");
                            }
                            else
                            {
                                Console.WriteLine($"input is odd number");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No AlphaNumaric");
                        }
                        break;
                    case 2:
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
                        break;
                    default:
                        Console.WriteLine("enter only 1 or  2");
                        break;
                }
                Console.WriteLine("if you whant to continue press \"yes\" else \"no\" ");
                reChoice = Console.ReadLine().ToLower();

            } while (reChoice == "yes");
            
        }
    }
                
           
}
