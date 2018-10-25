using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Validate
    {
        //validates the input so that it isnt null or a number
        public static string IsInputValid(string info)
        {
            while (true)
            {
                if (string.IsNullOrEmpty(info) || info.Length > 35)
                {
                    Console.WriteLine("That is not correct input, try again");

                }

                foreach (char item in info)
                {
                    if (!char.IsLetter(item))
                    {
                        Console.WriteLine("You must use alphabetical characters, try again ");

                    }
                }

                return info;
            }

        }
        //input is the movie category, displays each movie based on the category
        public static void CategorizeMovies(string userInput)
        {
            
                if (userInput.ToLower() == "horror")
                {
                    foreach (Movie movie in Program.movies)
                    {
                       if (movie.Category =="Horror")
                       {
                            Console.WriteLine(movie.Title);
                       }
                    }
                }
                else if (userInput.ToLower() == "animated")
                {
                    foreach (Movie movie in Program.movies)
                    {
                        if (movie.Category == "Animated")
                        {
                            Console.WriteLine(movie.Title);
                        }
                    }
                }
                else if (userInput.ToLower() == "scifi" || userInput.ToLower() == "sci fi")
                {
                    foreach (Movie movie in Program.movies)
                    {
                        if (movie.Category == "SciFi")
                        {
                            Console.WriteLine(movie.Title);
                        }
                    }
                }
                
                else if (userInput.ToLower() == "drama")
                {
                    foreach (Movie movie in Program.movies)
                    {
                        if (movie.Category == "Drama")
                        {
                            Console.WriteLine(movie.Title);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("That category was not recognized, please choose from Horror, Animated, SciFi, or Drama: ");
                    //userInput = Console.ReadLine();
                }

            
        }
        //validates the user input as either y or n
        public static bool YesOrNo(string response)
        {

            while (true)
            {

                if (response == "y")
                {
                    return true;
                }
                else if (response == "n")
                {
                    return false;
                }
                else
                {
                    Console.Write("Invalid input, try (y/n): ");
                    response = Console.ReadLine().ToLower();//changes variable and loops to top

                }
            }

        }
    }
}
