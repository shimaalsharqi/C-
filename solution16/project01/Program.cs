using Microsoft.EntityFrameworkCore;

using project01.Entities;

namespace project01
{
    public class Program
    {
        static void Main(string[] args)
        {
            AppDbContext context = new AppDbContext();

            // Add Categories
            Category category1 = new Category()
            {
                Name = "Action"
            };

            Category category2 = new Category()
            {
                Name = "Comedy"
            };

            context.Categories.Add(category1);
            context.Categories.Add(category2);

            context.SaveChanges();

            Console.WriteLine("Categories Added");


            // Add Movies
            Movie movie1 = new Movie()
            {
                Title = "John Wick",
                Description = "Action Movie",
                ReleaseYear = 2014,
                CategoryId = category1.Id
            };

            Movie movie2 = new Movie()
            {
                Title = "Rush Hour",
                Description = "Comedy Action Movie",
                ReleaseYear = 1998,
                CategoryId = category2.Id
            };

            context.Movies.Add(movie1);
            context.Movies.Add(movie2);

            context.SaveChanges();

            Console.WriteLine("Movies Added");


            // Add Users
            User user1 = new User()
            {
                Name = "Ali",
                Email = "ali@gmail.com"
            };

            User user2 = new User()
            {
                Name = "Sara",
                Email = "sara@gmail.com"
            };

            context.Users.Add(user1);
            context.Users.Add(user2);

            context.SaveChanges();

            Console.WriteLine("Users Added");


            // Add Reviews
            Review review1 = new Review()
            {
                Comment = "Amazing Movie",
                Rating = 9,
                UserId = user1.Id,
                MovieId = movie1.Id
            };

            Review review2 = new Review()
            {
                Comment = "Very Funny",
                Rating = 8,
                UserId = user2.Id,
                MovieId = movie2.Id
            };

            context.Reviews.Add(review1);
            context.Reviews.Add(review2);

            context.SaveChanges();

            Console.WriteLine("Reviews Added");


            // Add Watchlist
            Watchlist watch1 = new Watchlist()
            {
                UserId = user1.Id,
                MovieId = movie2.Id,
                AddedDate = DateTime.Now
            };

            context.Watchlists.Add(watch1);

            context.SaveChanges();

            Console.WriteLine("Watchlist Added");


            // Display Movies with Categories
            var movies = context.Movies
                .Include(m => m.Category)
                .ToList();

            Console.WriteLine("===== Movies =====");

            foreach (var movie in movies)
            {
                Console.WriteLine($"{movie.Title} - {movie.Category.Name}");
            }


            // Display Reviews
            var reviews = context.Reviews
                .Include(r => r.User)
                .Where(r => r.MovieId == movie1.Id)
                .ToList();

            Console.WriteLine("===== Reviews =====");

            foreach (var review in reviews)
            {
                Console.WriteLine($"{review.User.Name} : {review.Comment}");
            }


            // Display Watchlist
            var watchlist = context.Watchlists
                .Include(w => w.Movie)
                .Where(w => w.UserId == user1.Id)
                .ToList();

            Console.WriteLine("===== Watchlist =====");

            foreach (var item in watchlist)
            {
                Console.WriteLine(item.Movie.Title);
            }


            // Update Movie
            var movieUpdate = context.Movies.Find(movie1.Id);

            movieUpdate.Title = "John Wick Chapter 1";

            context.SaveChanges();

            Console.WriteLine("Movie Updated");


            // Delete Review
            var reviewDelete = context.Reviews.Find(review1.Id);

            context.Reviews.Remove(reviewDelete);

            context.SaveChanges();

            Console.WriteLine("Review Deleted");
        }
    } 
}  
