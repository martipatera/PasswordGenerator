using System;
namespace PasswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            do
            {
                Console.Clear();
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("Please select  the password strength:");
                Console.WriteLine("1 or + for only characters");
                Console.WriteLine("2 or ě for charactects + numbers");
                Console.WriteLine("3 or š for charactects + numbers + special symbols");
                Console.WriteLine("k for end");
                Console.WriteLine("-------------------------------------------------------------");

                string pressedKey = Console.ReadLine(); 
                input = pressedKey.ToLower();
                Console.Clear();
                if (input.Length <= 0 || input.Length > 1 || input == " ")

                {
                    Console.WriteLine("Wrong Input");
                    Console.Write(input);

                }
                else
                {
                    switch (input)

                    {
                        case "1":
                        case "+":

                            Console.WriteLine("Pressed " + input);
                            break;




                        case "2":
                        case "ě":
                            Console.WriteLine("Pressed " + input);
                            break;



                        case "3":
                        case "š":
                            Console.WriteLine("Pressed " + input);
                            break;


                        default:
                            break;

                    }


                }



            } while (input != "k");
            Console.WriteLine("END OF THE PROGRAM");
            Console.ReadKey();
        }
    }
}