using WebApplication1.DTO;

namespace WebApplication1.Service;

public interface IService
{
    Task<List<GetMemberDetailsDTO>> GetMemberByMail(string email);


    Task<List<GetMemberDetailsDTO>> GetMembers();
}