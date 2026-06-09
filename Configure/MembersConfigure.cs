using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Entity;

namespace WebApplication1.Configure;

public class MembersConfigure:IEntityTypeConfiguration<Members>
{
    public void Configure(EntityTypeBuilder<Members> builder)
    {
        builder.HasData(ReturnData());
    }

    private List<Members> ReturnData()
    {
        return new List<Members>
        {
            new Members
            {
                MemberId = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@gmail.com",
                Phone = "088888888",
            },
            new Members
            {
                MemberId = 2,
                FirstName = "Jane",
                LastName = "Doe",
                Email = "jane.doe@gmail.com",
                Phone = "088888881",

            },
            new Members
            {
                MemberId = 3,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@gmail.com",
                Phone = "088888288",
            }
        };
    }
}