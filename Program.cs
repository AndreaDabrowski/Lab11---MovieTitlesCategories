using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab11
{
    class Program
    {
       
        public static Movie walle = new Movie("Wall-e", "Animated");
        public static Movie theLittleMermaid = new Movie("The Little Mermaid", "Animated");
        public static Movie StarTrekNemesis = new Movie("Star Trek: Nemesis", "SciFi");
        public static Movie loveActually = new Movie("Love, Actually", "Drama");
        public static Movie panicRoom = new Movie("Panic Room", "Horror");
        public static Movie houseOfWax = new Movie("House of Wax", "Horror");
        public static Movie howToTrainYourDragon = new Movie("How to Train Your Dragon", "Animated");
        public static Movie theNotebook = new Movie("The Notebook", "Drama");
        public static Movie starWars = new Movie("Star Wars Holiday Special", "Horror");
        public static Movie fiftyShadesOfGray = new Movie("Fifty shades of Gray", "Drama");
        
        public static ArrayList movies = new ArrayList() { walle, theLittleMermaid, StarTrekNemesis, loveActually, panicRoom, houseOfWax, howToTrainYourDragon, theNotebook, starWars, fiftyShadesOfGray };

        public static string category, response;//why static?
        static void Main(string[] args)
        {
            Console.WriteLine("Welome to the Movie List Application!!!!!!!!!!!!!111!one!");
            do
            {
                Console.WriteLine("Enter a movie category: ");

                category = Console.ReadLine();
                Validate.IsInputValid(category);//validates category input
                Validate.CategorizeMovies(category);//inputs category and displays titles
                
                Console.WriteLine("Continue? (y/n): ");//prompts user to continue
                response = Console.ReadLine();
                Validate.YesOrNo(response);

            }
            while (Validate.YesOrNo(response));
            {
                Console.WriteLine("Goodbye!");
            }
            Console.ReadLine();
            
        }
    }
}
