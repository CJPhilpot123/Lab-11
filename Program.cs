using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Number_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie bladerunner2049 = new Movie("Blade Runner 2049", "Sci-Fi");
            Movie SWRise = new Movie("Star Wars Rise of the Skywalker", "Sci-Fi");
            Movie FF8 = new Movie("F8 of the Furious", "Action");
            Movie BM = new Movie("Brick Mansion", "Action");
            Movie Redrum = new Movie("Murder on the Orient Express", "Mystery");
            Movie SH = new Movie("Sherlock Holmes", "Mystery");
            Movie Spirited = new Movie("Spirited Away", "Animated");
            Movie Into = new Movie("Into the Spider-Verse", "Animated");
            Movie Hangover = new Movie("Hangover", "Comedy");
            Movie Office = new Movie("Office Space", "Comedy");

            List<Movie> Action = new List<Movie> { FF8, BM };
            List<Movie> Sci = new List<Movie> { bladerunner2049, SWRise };
            List<Movie> Mystery = new List<Movie> { Redrum, SH };
            List<Movie> Animated = new List<Movie> { Spirited, Into };
            List<Movie> Comedy = new List<Movie> { Hangover, Office };


            int wave = 0;
            wave++;

            while (wave == 1)
            {
                Console.WriteLine("Welcome to the Recommendor \nI have prepared a pair of movies for 5 genres! \nChoose wisely! \n(Sci-Fi/Action/Mystery/Animated/Comedy)");
                
           
                switch (Console.ReadLine())
                {
                    case "Sci-Fi":
                        foreach (Movie movie in Sci)
                        {
                            Console.WriteLine($"{movie.Title}");
                        }

                        break;
                    case "Action":
                        foreach (Movie movie in Action)
                        {
                            Console.WriteLine($"{movie.Title}");
                        };
                        break;
                    case "Mystery":
                        foreach (Movie movie in Mystery)
                        {
                            Console.WriteLine($"{movie.Title}");
                        };
                        break;
                    case "Animated":
                        foreach (Movie movie in Animated)
                        {
                            Console.WriteLine($"{movie.Title}");
                        };
                        break;
                    case "Comedy":
                        foreach (Movie movie in Comedy)
                        {
                            Console.WriteLine($"{movie.Title}");
                        };
                        break;
                    default:
                        break;

                }
                wave = 0;
                Console.WriteLine("Continue?(Yes/No)");
                string answer = Console.ReadLine();
                if (answer == "Yes")
                {
                    wave = 1;
                }
                if (answer == "No")
                {
                    Console.WriteLine("Hope You Have A Nice Day!");
                    wave--;
                }
            }
        }
    }
}
