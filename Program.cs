using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{

    class Program
    {
        private static Movie[] MovieList = new Movie[10];

        static void Main(string[] args)
        {
            while (true)
            {
                DefineList(MovieList);
                PrintGenres();
                Console.WriteLine("What category do you like? (1, 2, 3)");
                PrintMovies(Validate.CheckInput(Console.ReadLine().ToLower()));
                if (Validate.Continue() == false)
                    break;
            }
            Console.WriteLine("Goodbye!");
        }

        private static void DefineList(Movie[] MovieList)
        {
            MovieList[0] = new Movie("Star Wars", "scifi");
            MovieList[1] = new Movie("2001: A Space Odyssey", "scifi");
            MovieList[2] = new Movie("Contact", "scifi");
            MovieList[3] = new Movie("Star Trek", "scifi");
            MovieList[4] = new Movie("Saw", "horror");
            MovieList[5] = new Movie("Quarantine", "horror");
            MovieList[6] = new Movie("The Blob", "horror");
            MovieList[7] = new Movie("Princess Mononoke", "animated");
            MovieList[8] = new Movie("Howl's Moving Castle", "animated");
            MovieList[9] = new Movie("Spirited Away", "animated");
        }

        public static void PrintGenres()
        {
            Console.WriteLine(new string('*', 30));
            Console.WriteLine("{1}......................scifi");
            Console.WriteLine("{2}.....................horror");
            Console.WriteLine("{3}...................animated");
            Console.WriteLine(new string('*', 30));
            Console.WriteLine();
        }

        public static void PrintMovies(Categories genre)
        {
            ArrayList ToSort = new ArrayList();
            int i = 0;
            foreach (Movie show in MovieList)
            {
                if (genre.ToString() == show.Category)
                {
                    ToSort.Add(show.Title);
                    i++;
                }
            }
            ToSort.Sort();
            foreach(string x in ToSort)
            {
                Console.WriteLine(x);
            }
        }
    }
}
