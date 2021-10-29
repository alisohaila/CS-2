using System;

namespace vscode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi there! Welcome to Sohaila Ali's official game:) ");
            Console.Write("Do you want to play? (Yes/No): ");
            string play = Console.ReadLine();

            if (play == "yes" || play == "YES" || play == "Yes")
            {
                Console.WriteLine("Okay, let's go! ");
            } else if (play == "no" || play == "NO" || play == "No")
            {
                Console.WriteLine("Alright, bye! ");
                Environment.Exit(0);
            } else
            {
                Console.WriteLine("Invalid Input");
            }
            int score = 0;
            int num_of_questions = 5;

            while (true)
            {
                Console.Write("1. Is Python a programming language or a creature? ");
                string question = Console.ReadLine();

                if (question == ("programming language") || question == ("Programming Language") || question == ("creature") || question == ("Creature"))
                {
                   Console.WriteLine("Correct! It's both actually 1+");
                   score += 1;
                   break; 
                } else
                {
                    Console.WriteLine("Invalid Input");
                    continue;
                }
            }    

            while (true) 
            {
                Console.Write("2. What is a double in Java, C, C# and C++? (Even Number/Decimal Number): ");
                String question = Console.ReadLine();

                if (question == ("decimal number") || question == ("Decimal Number"))
                {
                    Console.WriteLine("Correct! 1+");
                    score += 1;
                    break;
                } else if (question == ("even number") || question == ("Even Number"))
                {
                    Console.WriteLine("Incorrect! It is decimal number");
                    break;
                } else
                {
                    Console.WriteLine("Invalid Input");
                    continue;
                }
            }
            
            while (true)
            {
                Console.Write("3. What is HTML used for? (Game Development/Web Development/Machine Learning): ");
                string question = Console.ReadLine();

                if (question == ("web development") || question == ("Web Development"))
                {
                    Console.WriteLine("Correct! 1+");
                    score += 1;
                    break;
                } else if (question == ("game development") || question == ("Game Development") || question == ("machine learning") || question == ("Machine Learning"))
                {
                    Console.WriteLine("Incorrect! It is Web Development ");
                    break;
                } else
                {
                    Console.WriteLine("Invalid Input");
                    continue;
                }
            }

            while (true)    
            {
                Console.Write("4. What does OOP stand for? (Out of Print/Object Oriented Programming/Out of Place): ");
                String question = Console.ReadLine();

                if (question == ("object oriented programming") || question == ("Object Oriented Programming"))
                {
                    Console.WriteLine("Correct! 1+");
                    score += 1;
                    break;
                } else if (question == ("out of print") || question == ("Out Of Print") || question == ("out of place") || question == ("Out Of Place"))
                {
                    Console.WriteLine("Incorrect! It is Object Oriented programming");
                    break;
                } else
                {
                    Console.WriteLine("Invalid Input");
                    continue;
                }
            }
            
            while (true)
            {
                Console.Write("5. How do you pronounce C#? (See Hashtag/See Sharp): ");
                String question = Console.ReadLine();

                if (question == ("see sharp") || question == ("See Sharp"))
                {
                    Console.WriteLine("Correct! 1+");
                    score += 1;
                    break;
                } else if (question == ("see hashtag") || question == ("See Hashtag"))
                {
                    Console.WriteLine("Incorrect! it is See Sharp");
                    break;
                } else
                {
                    Console.WriteLine("Invalid Input");
                    continue;


                }
            } Console.WriteLine("You've got " + score + "/" + num_of_questions);
        } 
    }   
}