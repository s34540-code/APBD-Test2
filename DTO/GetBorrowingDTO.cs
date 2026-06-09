namespace WebApplication1.DTO;

public class GetBorrowingDTO
{
    public int BorrowingId { get; set; }
    
    
    public DateTime BorrowDate { get; set; }
    
    
    public DateTime? ReturnDate { get; set; }
    
    public GetBookDTo Book { get; set; }
    
    public string Status { get; set; }
}