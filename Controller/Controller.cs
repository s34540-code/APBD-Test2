using Microsoft.AspNetCore.Mvc;
using WebApplication1.Repository;
using WebApplication1.Service;

namespace WebApplication1.Controller;


[ApiController]
[Route("api/members")]
public class Controller : ControllerBase
{
    
    private readonly IService service;

    public Controller(IService service)
    {
        this.service = service;
    }

    
    [HttpGet]
    public async Task<IActionResult> getAllMembers([FromQuery] string? email)
    {

        if (!string.IsNullOrEmpty(email))
        {
             var result = await service.GetMemberByMail(email);

             if (result == null)
             {
                 return NotFound();
             }
             return Ok(result);
        }

        return Ok(await service.GetMembers());


    }
}