using System;
namespace PasswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Random random = new Random();
            char[] characters =
                {
                    'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                    'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
                };


            char[] charactersandnumbers =
                {
                    'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                    'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
                    '1', '2', '3', '4', '5', '6', '7', '8', '9', '0','1', '2', '3', '4', '5', '6', '7', '8', '9', '0'
                };// cisla tam mam 2x aby byla jejich vetsis cetnost protoze jinak jich to generovalo hrozne malo

            char[] charactersandnumbersandspecialSymbols =
                {
                    'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                    'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
                    '!', '@', '#', '$', '%', 'ˆ', '&', '*', '(', ')', '_', '+', '-', '=', '[', ']', '{', '}', ';', ':', ',', '.', '<', '>', '/', '?',
                    '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'

                };


            string input;


            Random password = new Random(); // musim declarovat abych mohl pouzivat random



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

                
                

                if(input.Length == 1 && (input == "1" || input == "+" || input == "2" || input == "ě" || input == "3" || input == "š" || input == "k"))
                {
                    switch (input)
                    {
                        case "1":
                        case "+":
                            while (true) //nekonecna smicka, zastavi jedine break
                            {
                                
                                Console.WriteLine("-------------------------------------------------------------");
                                Console.WriteLine("ENTER A PASSWORD LENGHT: ");
                                Console.WriteLine("PRESS K FOR END ");
                                Console.WriteLine("-------------------------------------------------------------");
                                string passwordLenghtinput = Console.ReadLine();
                                if (int.TryParse(passwordLenghtinput, out int passwordLenght))//zkusi prevest string input na int a da ho do promene passwordLenght
                                {
                                    if (passwordLenght >= 8)
                                    {
                                        
                                        
                                        for (int i = 0; i < passwordLenght; i++) //konecny forloop, ktery se bude opakovat tolikrat, kolikrat dam input kterej je > 8
                                        {
                                            int randomIndex = random.Next(characters.Length); //tento radek mi bude vytvared nahodny index (s maximalnim rozsahem toho daneho pole
                                            Console.WriteLine("random inxex je: {0}, random char je: {1}", randomIndex , characters[randomIndex])  ;

                                        }

                                     
                                        break;

                                    }


                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("PASSWORD MUST BE AT LEAST 8 CHARACTERS LONG");
                                    }
                                }
                                else if (passwordLenghtinput == "k")
                                {
                                    Console.Clear();
                                    Console.WriteLine("END OF PROGRAM");
                                    break;
                                }

                                else//kdyz se nepovede prevedeni string inputu na int, provede se tento radek
                                {
                                    Console.Clear();
                                    Console.WriteLine(passwordLenghtinput + " IS INVALID INPUT PLEASE TRY AGAIN");
                                }
                                
                            }
                            break;
                            

                        case "2":
                        case "ě":
                            while(true) //nekonecna smicka, zastavi jecine break
                            {
                                Console.WriteLine("-------------------------------------------------------------");
                                Console.WriteLine("ENTER A PASSWORD LENGHT: ");
                                Console.WriteLine("PRESS K FOR END ");
                                Console.WriteLine("-------------------------------------------------------------");
                                string passwordLenghtinput = Console.ReadLine();
                                if (int.TryParse(passwordLenghtinput, out int passwordLenght))//zkusi prevest string input na int a da ho do promene passwordLenght
                                {
                                    if (passwordLenght >= 8)
                                    {
                                        for (int i = 0; i < passwordLenght; i++) //konecny forloop, ktery se bude opakovat tolikrat, kolikrat dam input kterej je > 8
                                        {
                                            int randomIndex = random.Next(charactersandnumbers.Length); //tento radek mi bude vytvared nahodny index (s maximalnim rozsahem{maximalnim indexem} toho daneho pole)
                                            Console.WriteLine("random inxex je: {0}, random char je: {1}", randomIndex, charactersandnumbers[randomIndex]);

                                        }

                                        break;

                                    }


                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("PASSWORD MUST BE AT LEAST 8 CHARACTERS LONG");
                                    }
                                }
                                else if (passwordLenghtinput == "k")
                                {
                                    Console.Clear();
                                    Console.WriteLine("END OF PROGRAM");
                                    break;
                                }

                                else//kdyz se nepovede prevedeni string inputu na int, provede se tento radek
                                {
                                    Console.Clear();
                                    Console.WriteLine(passwordLenghtinput + " IS INVALID INPUT PLEASE TRY AGAIN");
                                }

                            }
                            break;

                        case "3":
                        case "š":
                            while(true) //nekonecna smicka, zastavi jecine break
                            {
                                Console.WriteLine("-------------------------------------------------------------");
                                Console.WriteLine("ENTER A PASSWORD LENGHT: ");
                                Console.WriteLine("PRESS K FOR END ");
                                Console.WriteLine("-------------------------------------------------------------");
                                string passwordLenghtinput = Console.ReadLine();
                                if (int.TryParse(passwordLenghtinput, out int passwordLenght))//zkusi prevest string input na int a da ho do promene passwordLenght
                                {
                                    if (passwordLenght >= 8)
                                    {
                                        for (int i = 0; i < passwordLenght; i++) //konecny forloop, ktery se bude opakovat tolikrat, kolikrat dam input kterej je > 8
                                        {
                                            int randomIndex = random.Next(charactersandnumbersandspecialSymbols.Length); //tento radek mi bude vytvared nahodny index (s maximalnim rozsahem{maximalnim indexem} toho daneho pole)
                                            Console.WriteLine("random inxex je: {0}, random char je: {1}", randomIndex, charactersandnumbersandspecialSymbols[randomIndex]);

                                        }

                                        break;

                                    }


                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("PASSWORD MUST BE AT LEAST 8 CHARACTERS LONG");
                                    }
                                }
                                else if (passwordLenghtinput == "k")
                                {
                                    Console.Clear();
                                    Console.WriteLine("END OF PROGRAM");
                                    break;
                                }

                                else//kdyz se nepovede prevedeni string inputu na int, provede se tento radek
                                {
                                    Console.Clear();
                                    Console.WriteLine(passwordLenghtinput + " IS INVALID INPUT PLEASE TRY AGAIN");
                                }

                            }
                            break;


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
                    Console.Clear();
                    Console.WriteLine(input + " IS WRONG INPUT PLEASE TRY AGAIN");                   
                }
            }


        }


    }

    
}
