using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Entity;


[Table("Authors")]
public class Authors
{
    [Key]
    public int AuthorId { get; set; }
    
    
    [Column(TypeName = "varchar(50)")]
    public string FirstName { get; set; }
    
    
    [Column(TypeName = "varchar(100)")]
    public string LastName { get; set; }
    
    
    
    [Column(TypeName = "varchar(100)")]
    public string Email { get; set; }
    
    
    [Column(TypeName = "varchar(50)")]
    public string Country { get; set; }
    
    
    public int BirthYear { get; set; }
    
    
    public ICollection<Books> books { get; set; } = new List<Books>();
    
}