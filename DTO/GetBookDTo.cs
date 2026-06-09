namespace WebApplication1.DTO;

public class GetBookDTo
{
    public int BookId{get;set;}
    
    
    public string Title{get;set;}
    
   
    public string ISBN{get;set;}
    
    public int PublishedYear{get;set;}
    
    public GetAuthorDTO Author{get;set;}

}