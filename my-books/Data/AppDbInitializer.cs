using my_books.Data.Models;

namespace my_books.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Books.Any())
                {
                    context.Books.AddRange(new Book()
                    {
                        Title = "1st Book title",
                        Description = "1st Book Description",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genre = "Biology",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now
                    },
                    new Book()
                    {
                        Title = "2nd Book title",
                        Description = "2nd Book Description",
                        IsRead = false,
                        Genre = "Biology",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now
                    },
                    new Book()
                    {
                        Title = "3rd Book title",
                        Description = "3rd Book Description",
                        Rate = 3,
                        Genre = "Math",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}
