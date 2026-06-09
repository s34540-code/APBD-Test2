using Microsoft.EntityFrameworkCore;
using WebApplication1.Context;
using WebApplication1.DTO;
using WebApplication1.Entity;

namespace WebApplication1.Repository;

public class Repository:IRepository
{
    private readonly AppDbContext dbContext;

    public Repository(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<List<Members?>>  findMemberByMail(string email)
    {
        
        return await dbContext.Members.Include(m => m.borrowings).
            ThenInclude(m => m.Book).ThenInclude(b => b.authors).ToListAsync();
        
        
    }

    public async Task<List<Members?>> findMembers()
    {
        return await dbContext.Members.ToListAsync();
    }
}