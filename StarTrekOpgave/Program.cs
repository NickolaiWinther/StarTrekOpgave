using System;
using System.Collections.Generic;

namespace StarTrekOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select race: \n1. Vulcan");
                string race = Console.ReadLine().ToLower();
                int.TryParse(race, out int raceNumber);

                while (race == "vulcan" || race == "v" || raceNumber == 1)
                {
                    List<string> vocals = new List<string>() { "a", "e", "i", "o", "u", "y" };

                    List<string> mFirstLetters = new List<string>() { "S", "Sp", "Sk", "St", "T" };
                    List<string> mMiddleLetter = new List<string>() { "r", "t", "p", "d", "f", "j", "k", "l", "v", "b", "n", "m" };
                    List<string> mLastLetters = new List<string>() { "q", "p", "k", "ck", "l" };

                    List<string> fFirstLetter = new List<string>() { "T'" };
                    List<string> fSecondLetter = new List<string>() { "P", "K", "Q" };
                    List<string> fLastLetters = new List<string>() { "r", "j", "'p", "k", "l" };



                    Console.WriteLine("Generate Vulcan:\n1. Male\n2. Female\n3. Back" +
                        "");
                    string input = Console.ReadLine().ToLower();
                    int.TryParse(input, out int number);
                    Console.Clear();


                    if (input == "m" || input == "male" || number == 1)
                    {
                        foreach (string firstLetters in mFirstLetters)
                        {
                            foreach (string firstVocal in vocals)
                            {
                                foreach (string MiddleLetter in mMiddleLetter)
                                {
                                    foreach (string lastVocal in vocals)
                                    {
                                        foreach (string lastLetter in mLastLetters)
                                        {
                                            Console.WriteLine(firstLetters + firstVocal + MiddleLetter + lastVocal + lastLetter);
                                        }
                                    }
                                }
                            }
                        }
                        foreach (string firstLetters in mFirstLetters)
                        {
                            foreach (string vocal in vocals)
                            {
                                foreach (string lastLetter in mLastLetters)
                                {
                                    Console.WriteLine(firstLetters + vocal + lastLetter);
                                }
                            }
                        }
                        Console.WriteLine("\nPress a button to continue . . .");
                        Console.ReadKey();
                        Console.Clear();
                    }


                    else if (input == "f" || input == "female" || number == 2)
                    {
                        foreach (string firstLetter in fFirstLetter)
                        {
                            foreach (string secondLetter in fSecondLetter)
                            {
                                foreach (string vocal in vocals)
                                {
                                    foreach (string lastLetter in fLastLetters)
                                    {
                                        Console.WriteLine(firstLetter + secondLetter + vocal + lastLetter);
                                    }
                                }
                            }
                        }
                        Console.WriteLine("\nPress a button to continue . . .");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (input == "b" || input == "back" || number == 3)
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid input");
                    }
                }

                //ER IKKE FÆRDIG MED TALAXIAN
                while (race == "talaxian" || race == "t" || raceNumber == 2)
                {
                    List<string> vocals = new List<string>() { "a", "e", "i", "o", "u", "y" };

                    List<string> mFirstLetters = new List<string>() { "" };
                    List<string> mMiddleLetter = new List<string>() { "r", "t", "p", "d", "f", "j", "k", "l", "v", "b", "n", "m" };
                    List<string> mLastLetters = new List<string>() { "q", "p", "k", "ck", "l" };

                    List<string> fFirstLetter = new List<string>() { "T'" };
                    List<string> fSecondLetter = new List<string>() { "P", "K", "Q" };
                    List<string> fLastLetters = new List<string>() { "r", "j", "'p", "k", "l" };

                    Console.WriteLine("Generate Talaxian:\n1. Male\n2. Female\n3. Back" +
                        "");
                    string input = Console.ReadLine().ToLower();
                    int.TryParse(input, out int number);
                    Console.Clear();

                    if (input == "m" || input == "male" || number == 1)
                    {
                        foreach (string firstLetters in mFirstLetters)
                        {
                            foreach (string firstVocal in vocals)
                            {
                                foreach (string MiddleLetter in mMiddleLetter)
                                {
                                    foreach (string lastVocal in vocals)
                                    {
                                        foreach (string lastLetter in mLastLetters)
                                        {
                                            Console.WriteLine(firstLetters + firstVocal + MiddleLetter + lastVocal + lastLetter);
                                        }
                                    }
                                }
                            }
                        }
                        foreach (string firstLetters in mFirstLetters)
                        {
                            foreach (string vocal in vocals)
                            {
                                foreach (string lastLetter in mLastLetters)
                                {
                                    Console.WriteLine(firstLetters + vocal + lastLetter);
                                }
                            }
                        }
                        Console.WriteLine("\nPress a button to continue . . .");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }
        }
    }
}
