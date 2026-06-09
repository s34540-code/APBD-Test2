using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Entity;

[Table("Books")]
public class Books
{
    [Key]
    public int BookId{get;set;}
    
    [Column(TypeName = "varchar(200)")]
    public string Title{get;set;}
    
    [Column(TypeName = "varchar(13)")]
    public string ISBN{get;set;}
    
    public int PublishedYear{get;set;}
    
    public int AuthorsId{get;set;}
    
    public Authors authors{get;set;}
    
    public ICollection<Borrowings> borrowings { get; set; } = new List<Borrowings>();
    
    public ICollection<Reviews> reviews { get; set; } = new List<Reviews>();
    
}