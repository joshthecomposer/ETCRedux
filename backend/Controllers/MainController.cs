using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ServiceModel;
using System.ServiceModel.Syndication;
using System.Xml;
using Server.Models;
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
}