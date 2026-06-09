using WebApplication1.DTO;
using WebApplication1.Repository;

namespace WebApplication1.Service;

public class Service:IService
{
    private readonly IRepository repository;

    public Service(IRepository repository)
    {
        this.repository = repository;
    }

    public async Task<List<GetMemberDetailsDTO>> GetMemberByMail(string email)
    {
        var member = await repository.findMemberByMail(email);

        if (member == null)
        {
            return null;
        }
        
        
        return member.Select(m => new GetMemberDetailsDTO
        {
            FirstName = m.FirstName,
            LastName = m.LastName,
            Email = m.Email,
            Phone = m.Phone,
            Borrowings = m.borrowings.Select(b => new GetBorrowingDTO
            {
                BorrowingId = b.BorrowingId,
                BorrowDate = b.BorrowDate,
                ReturnDate = b.ReturnDate,
                Status = b.Status,
                Book = new GetBookDTo
                {
                    BookId = b.BookId,
                    Title = b.Book.Title,
                    ISBN = b.Book.ISBN,
                    PublishedYear = b.Book.PublishedYear,
                    Author = new GetAuthorDTO
                    {
                        FirstName = b.Book.authors.FirstName,
                        LastName = b.Book.authors.LastName,
                        Country = b.Book.authors.Country
                    }
                }
            })
        }).ToList();
        
    }

    public async Task<List<GetMemberDetailsDTO>> GetMembers()
    {

        var member = await repository.findMembers();
        return member.Select(m => new GetMemberDetailsDTO
        {
            FirstName = m.FirstName,
            LastName = m.LastName,
            Email = m.Email,
            Phone = m.Phone,
            Borrowings = m.borrowings.Select(b => new GetBorrowingDTO
            {
                BorrowingId = b.BorrowingId,
                BorrowDate = b.BorrowDate,
                ReturnDate = b.ReturnDate,
                Status = b.Status,
                Book = new GetBookDTo
                {
                    BookId = b.BookId,
                    Title = b.Book.Title,
                    ISBN = b.Book.ISBN,
                    PublishedYear = b.Book.PublishedYear,
                    Author = new GetAuthorDTO
                    {
                        FirstName = b.Book.authors.FirstName,
                        LastName = b.Book.authors.LastName,
                        Country = b.Book.authors.Country
                    }
                }
            })
        }).ToList();

    }
}