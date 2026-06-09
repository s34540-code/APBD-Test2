using WebApplication1.DTO;
using WebApplication1.Entity;

namespace WebApplication1.Repository;

public interface IRepository
{
    Task<List<Members?>> findMemberByMail(string email);
    
    
    Task<List<Members?>> findMembers();
}