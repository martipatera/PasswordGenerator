
using System;
using System.IO;
namespace PasswordGenerator
    


{
    internal class Program
    {
        static void MyPasswords()
        {

            string path = @"/Users/martinpatera/Projects/PasswordGenerator/mypasswords.txt";

            using (StreamReader sr = new StreamReader(path)) //cte to co je v path
            {
                string line;
                Console.Clear();
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("YOUR PASSWORDS");
                Console.WriteLine("-------------------------------------------------------------");
                while (!(sr.EndOfStream)) // dokud NEnastane konec souboru bude cist radky
                {
                    line = sr.ReadLine(); //nacte to jeden radek ze souboru a ulozi ho do promene line
                    Console.WriteLine(line);
                }
                Console.WriteLine("-------------------------------------------------------------");
            }
        }

        static void CharactersAndNumbers()
        {
            string path = @"/Users/martinpatera/Projects/PasswordGenerator/mypasswords.txt";
            string password = " ";//pripravim si password jako prazdnej string
            Random random = new Random();// musim declarovat abych mohl pouzivat random
            char[] charactersandnumbers =
                {
                    'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                    'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
                    '1', '2', '3', '4', '5', '6', '7', '8', '9', '0','1', '2', '3', '4', '5', '6', '7', '8', '9', '0'
                };// cisla tam mam 2x aby byla jejich vetsis cetnost protoze jinak jich to generovalo hrozne malo
            while (true) //nekonecna smicka, zastavi jecine break
            {
                
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("ENTER A PASSWORD LENGHT: ");
                Console.WriteLine("PRESS K FOR END ");
                Console.WriteLine("-------------------------------------------------------------");
                
                string passwordLenghtinput = Console.ReadLine();
                Console.Clear();
                
                if (int.TryParse(passwordLenghtinput, out int passwordLenght))//zkusi prevest string input na int a da ho do promene passwordLenght
                {
                    if (passwordLenght >= 8)
                    {
                        for (int i = 0; i < passwordLenght; i++) //konecny forloop, ktery se bude opakovat tolikrat, kolikrat dam input kterej je > 8
                        {
                            int randomIndex = random.Next(charactersandnumbers.Length); //tento radek mi bude vytvaret nahodny index (s maximalnim rozsahem{maximalnim indexem} toho daneho pole)
                            password = password + charactersandnumbers[randomIndex];  //characters[randomIndex] je ten char ktery to random vygeneruje


                        }



                        while (true)

                        {
                            Console.WriteLine("-------------------------------------------------------------");
                            Console.WriteLine("PLEASE ENTER A PASSWORD NAME: ");
                            Console.WriteLine("-------------------------------------------------------------");

                            string passwordName;
                            passwordName = Console.ReadLine();
                            Console.Clear();


                            if (passwordName.Trim().Length < 1) //trim() vezme " "na zacatku a konci a urizne je
                            {
                                Console.Clear();
                                Console.WriteLine("-------------------------------------------------------------");
                                Console.WriteLine("{0} IS WRONG PASSWORD NAME, PLEASE TRY AGAIN", passwordName);
                                Console.WriteLine("-------------------------------------------------------------");


                            }



                            else
                            {
                                passwordName = passwordName.Trim();
                                Console.Clear();
                                Console.WriteLine("-------------------------------------------------------------");
                                Console.WriteLine("YOUR PASSWORD FOR {0} IS {1}", passwordName, password);
                                Console.WriteLine(passwordName + " " + password);
                                Console.WriteLine("-------------------------------------------------------------");
                                using (StreamWriter sw = File.AppendText(path)) //using aby se soubor automaticky uzavrel, AppendText vlozi ten text co chci do toho naseho souboru
                                {
                                    sw.WriteLine(passwordName + " " + password);
                                }
                                break;
                            }
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
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine("END OF PROGRAM");
                    Console.WriteLine("-------------------------------------------------------------");
                    break;
                }

                else//kdyz se nepovede prevedeni string inputu na int, provede se tento radek
                {
                    Console.Clear();
                    Console.WriteLine(passwordLenghtinput + " IS INVALID INPUT PLEASE TRY AGAIN");
                }

            }
        }

        static void CharactersNumbersAndSymbols()

        {
            string path = @"/Users/martinpatera/Projects/PasswordGenerator/mypasswords.txt";
            string password = " ";//pripravim si password jako prazdnej string
            Random random = new Random();// musim declarovat abych mohl pouzivat random
            char[] charactersandnumbersandspecialSymbols =
                {
                    'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                    'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
                    '!', '@', '#', '$', '%', 'ˆ', '&', '*', '(', ')', '_', '+', '-', '=', '[', ']', '{', '}', ';', ':', ',', '.', '<', '>', '/', '?',
                    '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'

                };
            while (true) //nekonecna smicka, zastavi jecine break
            {
                
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("ENTER A PASSWORD LENGHT: ");
                Console.WriteLine("PRESS K FOR END ");
                Console.WriteLine("-------------------------------------------------------------");
                string passwordLenghtinput = Console.ReadLine();
                Console.Clear();

                if (int.TryParse(passwordLenghtinput, out int passwordLenght))//zkusi prevest string input na int a da ho do promene passwordLenght
                {
                    if (passwordLenght >= 8)
                    {
                        for (int i = 0; i < passwordLenght; i++) //konecny forloop, ktery se bude opakovat tolikrat, kolikrat dam input kterej je > 8
                        {
                            int randomIndex = random.Next(charactersandnumbersandspecialSymbols.Length); //tento radek mi bude vytvaret nahodny index (s maximalnim rozsahem{maximalnim indexem} toho daneho pole)
                            password = password + charactersandnumbersandspecialSymbols[randomIndex];  //characters[randomIndex] je ten char ktery to random vygeneruje

                        }
                        while (true)

                        {
                            Console.WriteLine("-------------------------------------------------------------");
                            Console.WriteLine("PLEASE ENTER A PASSWORD NAME: ");
                            Console.WriteLine("-------------------------------------------------------------");
                            string passwordName;
                            passwordName = Console.ReadLine();
                            Console.Clear();

                            if (passwordName.Trim().Length < 1) //trim() vezme " "na zacatku a konci a urizne je
                            {
                                Console.WriteLine("-------------------------------------------------------------");
                                Console.WriteLine("{0} IS WRONG PASSWORD NAME, PLEASE TRY AGAIN", passwordName);
                                Console.WriteLine("-------------------------------------------------------------");
                            }



                            else
                            {
                                passwordName = passwordName.Trim();
                                Console.Clear();
                                Console.WriteLine("-------------------------------------------------------------");
                                Console.WriteLine("YOUR PASSWORD FOR {0} IS {1}", passwordName, password);
                                Console.WriteLine(passwordName + " " + password);
                                Console.WriteLine("-------------------------------------------------------------");
                                using (StreamWriter sw = File.AppendText(path)) //using aby se soubor automaticky uzavrel, AppendText vlozi ten text co chci do toho naseho souboru
                                {
                                    sw.WriteLine(passwordName + " " + password);
                                }
                                break;
                            }
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
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine("END OF PROGRAM");
                    Console.WriteLine("-------------------------------------------------------------");
                    break;
                }

                else//kdyz se nepovede prevedeni string inputu na int, provede se tento radek
                {
                    Console.Clear();
                    Console.WriteLine(passwordLenghtinput + " IS INVALID INPUT PLEASE TRY AGAIN");
                }

            }
        }
        static void Main(string[] args)
        {
            Console.Clear();
            string path = @"/Users/martinpatera/Projects/PasswordGenerator/mypasswords.txt";

            if (!File.Exists(path)) //pokud soubor neexistuje udelej toto
            {
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("FILE CREATED SUCCESSFULLY!");
                Console.WriteLine("-------------------------------------------------------------");
                using (StreamWriter sw = File.CreateText(path)) //vytvori soubor s adresou ktera je v path
                
                {
                   
                }
                


            }
           





            string input;


            while (true) /* podminku nastavime aby byla vzdy pravdiva = je nekonecna
                          * kdyz podminka if bude pravdiva, hodi se to do switche a ukonci se while loop pomoci break 
                          * kdyz zadam cokoliv jineho bude se to opakovat protoze v else nemam break*/

            {

                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("PLEASE SELECT PASSWORD STRENGHT:");
                Console.WriteLine("0 TO SHOW YOUR PREVIOUS PASSWORDS");
                Console.WriteLine("1 OR + FOR NUMBERS + CHARACTERS");
                Console.WriteLine("2 OR ě FOR CHARACTERS + NUMBERS + SPECIAL SYMBOLS ");
                Console.WriteLine("K FOR END");
                Console.WriteLine("-------------------------------------------------------------");

                string pressedKey = Console.ReadLine();
                input = pressedKey.ToLower();




                if (input.Length == 1 && (input == "1" || input == "+" || input == "2" || input == "ě" || input == "k" || input == "0"))
                {
                    switch (input)
                    {
                        case "1":
                        case "+":
                            Console.Clear();
                            CharactersAndNumbers();
                            break;//ukonceni switche, musi byt!!!

                        case "2":
                        case "ě":
                            Console.Clear();
                            CharactersNumbersAndSymbols();
                            break;//ukonceni switche, musi byt!!!

                        case "0":
                            MyPasswords();
                            break;


                        case "k":
                            Console.Clear();
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