using System;
namespace PasswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            while (true) /* podminku nastavime aby byla vzdy pravdiva = je nekonecna
                          * kdyz podminka if bude pravdiva, hodi se to do switche a ukonci se while loop pomoci break 
                          * kdyz zadam cokoliv jineho bude se to opakovat protoze v else nemam break*/

            {
                
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("Please select the password strength:");
                Console.WriteLine("1 or + for only characters");
                Console.WriteLine("2 or ě for characters + numbers");
                Console.WriteLine("3 or š for characters + numbers + special symbols");
                Console.WriteLine("k for end");
                Console.WriteLine("-------------------------------------------------------------");

                string pressedKey = Console.ReadLine();
                input = pressedKey.ToLower();
                Console.Clear();

                if (input == "1" || input == "+" || input == "2" || input == "ě" || input == "3" || input == "š" || input == "k")
                {
                    switch (input)
                    {
                        case "1":
                        case "+":
                            Console.WriteLine("Pressed " + input);
                            break; //ukonceni switche, musi byt!!!

                        case "2":
                        case "ě":
                            Console.WriteLine("Pressed " + input);
                            break; //ukonceni switche, musi byt!!!

                        case "3":
                        case "š":
                            Console.WriteLine("Pressed " + input);
                            break; //ukonceni switche, musi byt!!!


                        case "k":
                            Console.WriteLine("END OF PROGRAM");
                            break; //ukonceni switche, musi byt!!!

                        default:
                            break; //ukonceni switche, musi byt!!!
                    }

                    break; // ukonceni nekonecne smycky smycky po zadani platneho inputu
                }
                else //bude se opakovat dokud nezadam spravnou podminku if
                {

                    Console.WriteLine("WRONG INPUT PLEASE TRY AGAIN");                   
                }
            }


        }


    }

    
}