namespace WebApplication1.DTO;

public class GetMemberDetailsDTO
{
    public string FirstName { get; set; }
    
    
  
    public string LastName { get; set; }
    
    
    public string Email { get; set; }
    
    
    
    public string Phone { get; set; }
    
    
    public IEnumerable<GetBorrowingDTO> Borrowings { get; set; } = new List<GetBorrowingDTO>();
}