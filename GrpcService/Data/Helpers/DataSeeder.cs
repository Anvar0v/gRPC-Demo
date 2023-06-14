using Microsoft.EntityFrameworkCore;

namespace GrpcServer.Data.Helpers;
public static class DataSeeder
{
    public static void SeedData(ModelBuilder builder)
    {
        for (int i = 2; i <= 200; i++)
        {
            builder.Entity<BookModel>().HasData(new BookModel
            {
                Id = i,
                Author = $"Test={i}",
                Title = $"Test={i}",
                PublishedYear = 2022,
            });
        }
    }
}
