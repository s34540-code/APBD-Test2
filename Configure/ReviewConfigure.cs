using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Entity;

namespace WebApplication1.Configure;

public class ReviewConfigure:IEntityTypeConfiguration<Reviews>
{
    public void Configure(EntityTypeBuilder<Reviews> builder)
    {
        builder.HasKey(r => new{r.MemberId,r.BookId});
        
        
        builder.HasOne(r => r.Book).WithMany(b => b.reviews).
            HasForeignKey(r => r.BookId).OnDelete(DeleteBehavior.Cascade);
        
        builder.HasOne(r => r.Member).WithMany(b => b.reviews).
            HasForeignKey(r => r.MemberId).OnDelete(DeleteBehavior.Cascade);
        
        builder.HasData(returnData());
    }

    private List<Reviews> returnData()
    {
        return new List<Reviews>
        {
            new Reviews
            {
                MemberId = 1,
                BookId = 1,
                Rating = 3,
                Comment = "Comment1",
                ReviewDate = new DateTime(2018, 6, 1),
            },
            new Reviews
            {
                MemberId = 2,
                BookId = 2,
                Rating = 4,
                Comment = "Comment2",
                ReviewDate = new DateTime(2018, 7, 1),
            },
            new Reviews
            {
                MemberId = 3,
                BookId = 3,
                Rating = 5,
                Comment = "Comment3",
                ReviewDate = new DateTime(2018, 8, 1),

            }
        };
    }
}