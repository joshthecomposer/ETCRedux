using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ServiceModel;
using System.ServiceModel.Syndication;
using System.Xml;
using Server.Models;
using Microsoft.AspNetCore.Identity;
namespace Server.Controllers;
[Route("api")]
[ApiController]
public class MainController : ControllerBase
{
    private ETContext _context;
    public MainController(ETContext context)
    {
        _context = context;
    }

    [HttpGet(template:"hello")]
    public Dictionary<string, string> getHello()
    {
        Dictionary<string, string> hello = new Dictionary<string, string>();
        hello.Add("user", "hello");
        return hello;
    }

    [HttpGet(template:"{id}")]
    [ActionName(nameof(GetOneUser))]
    public async Task<ActionResult<User>> GetOneUser(int id)
    {
        //TODO: Return everything but PConfirm
        var user = await _context.Users.FindAsync(id);
        if (user == null)
        {
            return NotFound();
        }
        return user;
    }

    [HttpPost(template:"user/create")]
    public async Task<ActionResult<User>> CreateUser([FromBody]User user)
    {
        if (ModelState.IsValid)
        {
            PasswordHasher<User> Hasher = new PasswordHasher<User>();
            user.Password = Hasher.HashPassword(user, user.Password);

            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return CreatedAtAction(
                nameof(GetOneUser),
                new { id = user.UserId },
                user.UserId
            );
        }
        else
        {
            return BadRequest(ModelState);
        }
    }
}