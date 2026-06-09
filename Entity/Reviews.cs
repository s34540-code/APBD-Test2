using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Entity;

[Table("Reviews")]
public class Reviews
{
    public int MemberId { get; set; }
    
    public Members Member { get; set; }
    
    public int BookId { get; set; }
    
    public Books Book { get; set; }
    
    
    public int Rating { get; set; }
    
    [Column(TypeName = "varchar(500)")]
    public string Comment { get; set; }
    
    
    public DateTime ReviewDate { get; set; }
    
    
    
}