using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Entity;

namespace WebApplication1.Configure;

public class BooksConfigure:IEntityTypeConfiguration<Books>
{
    public void Configure(EntityTypeBuilder<Books> builder)
    {
       builder.HasOne(b => b.authors).WithMany(a => a.books).
           HasForeignKey(b => b.AuthorsId);


       builder.HasData(returnData());

    }

    private List<Books> returnData()
    {
        return new List<Books>
        {
            new Books
            {
                BookId = 1,
                Title = "Title1",
                ISBN = "ISBN1",
                PublishedYear = 2008,
                AuthorsId = 1
            },
            new Books
            {
                BookId = 2,
                Title = "Title2",
                ISBN = "ISBN2",
                PublishedYear = 2009,
                AuthorsId = 2
            },
            new Books
            {
                BookId = 3,
                Title = "Title3",
                ISBN = "ISBN3",
                PublishedYear = 1999,
                AuthorsId = 3
            }
        };
    }
}