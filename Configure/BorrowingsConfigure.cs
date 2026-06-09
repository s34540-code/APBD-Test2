using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Entity;

namespace WebApplication1.Configure;

public class BorrowingsConfigure:IEntityTypeConfiguration<Borrowings>
{
    public void Configure(EntityTypeBuilder<Borrowings> builder)
    {
        builder.HasData(returnData());
        
        
        builder.HasOne(b => b.Member).WithMany(b => b.borrowings).
            HasForeignKey(b => b.MemberId).OnDelete(DeleteBehavior.Cascade);
        
        
        builder.HasOne(b => b.Book).WithMany(b => b.borrowings).
            HasForeignKey(b => b.BookId).OnDelete(DeleteBehavior.Cascade);
    }

    private List<Borrowings> returnData()
    {
        return new List<Borrowings>
        {
            new Borrowings
            {
                BorrowingId = 1,
                MemberId = 1,
                BookId = 1,
                Status = "Rejected",
                BorrowDate = new DateTime(2018, 1, 1),
                ReturnDate = new DateTime(2019, 1, 1),

            },
            new Borrowings
            {
                BorrowingId = 2,
                MemberId = 2,
                BookId = 2,
                Status = "Accepted",
                BorrowDate = new DateTime(2018, 1, 1),
                ReturnDate = new DateTime(2020, 1, 1),
            },
            new Borrowings
            {
                BorrowingId = 3,
                MemberId = 3,
                BookId = 3,
                Status = "Pending",
                BorrowDate = new DateTime(2018, 1, 1),
                ReturnDate = new DateTime(2019, 1, 1),
            }
        };
    }
}