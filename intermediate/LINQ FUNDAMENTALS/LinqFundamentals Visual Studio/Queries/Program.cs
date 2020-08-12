using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = MyLinq.Random().Where(n => n > 0.5).Take(10);
            foreach( var item in numbers)
            {
                Console.WriteLine(item);
            }

            var movies = new List<Movie>()
            {
                new Movie { Title = "The Dark Knight", Rating = 8.9f, Year = 2000},
                new Movie { Title = "Casablanca", Rating = 8.0f, Year = 2010},
                new Movie { Title = "Star Wars V", Rating = 8.5f, Year = 2013},
                new Movie { Title = "The Kings Speech", Rating = 8.7f, Year = 2015},
                new Movie { Title = "PHP the movie", Rating = 2.8f, Year = 1990}
            };
            var query = from movie in movies 
                        where movie.Year > 2000
                         orderby movie.Rating descending
                        select movie;

            //foreach(var movie in query)
            //{
            //    Console.WriteLine(movie.Title);
            //}

            //Console.WriteLine(query.Count());
            var enumerator = query.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.Title);
            }

            Console.ReadLine();
        }
    }
}
