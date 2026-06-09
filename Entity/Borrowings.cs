using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Entity;

[Table("Borrowings")]
public class Borrowings
{
    
    [Key]
    public int BorrowingId { get; set; }
    
    [Column(TypeName = "datetime")]
    public DateTime BorrowDate { get; set; }
    
    [Column(TypeName = "datetime")]
    public DateTime? ReturnDate { get; set; }
    
    
    [Column(TypeName = "varchar(50)")]
    public string Status { get; set; }
    
    
    public int MemberId { get; set; }
    
    
    public Members Member { get; set; }
    
    
    public int BookId { get; set; }
    
    
    public Books Book { get; set; }
}