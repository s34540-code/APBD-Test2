using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Entity;

[Table("Members")]
public class Members
{
    
    [Key]
    public int MemberId { get; set; }
    
    [Column(TypeName = "varchar(50)")]
    public string FirstName { get; set; }
    
    
    [Column(TypeName = "varchar(100)")]
    public string LastName { get; set; }
    
    [Column(TypeName = "varchar(100)")]
    public string Email { get; set; }
    
    
    [Column(TypeName = "varchar(9)")]
    public string Phone { get; set; }
    
    
    public ICollection<Borrowings> borrowings { get; set; } = new List<Borrowings>();
    
    
    public ICollection<Reviews> reviews { get; set; } = new List<Reviews>();
}