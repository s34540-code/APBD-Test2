using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Entity;

namespace WebApplication1.Configure;

public class AuthorConfigure:IEntityTypeConfiguration<Authors>
{
    public void Configure(EntityTypeBuilder<Authors> builder)
    {
        builder.HasData(ReturnData());
    }


    private List<Authors> ReturnData()
    {
        return new List<Authors>
        {
            new Authors
            {
                AuthorId = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "johndoe@gmail.com",
                BirthYear = 1997,
                Country = "USA",

            },
            new Authors
            {
                AuthorId = 2,
                FirstName = "Jane",
                LastName = "Doe",
                Email = "janedoe@gmail.com",
                BirthYear = 1998,
                Country = "USA",

            },
            new Authors
            {
                AuthorId = 3,
                FirstName = "John",
                LastName = "Doe",
                Email = "johndoe@gmail.com",
                BirthYear = 1996,
                Country = "USA",
            }
            
        };
    }
}