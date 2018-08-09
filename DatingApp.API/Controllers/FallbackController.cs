using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace DatingApp.API.Controllers
{
  public class FallbackController : Controller
  {
    public IActionResult Index()
    {
      var root = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "index.html");
      return PhysicalFile(root, "text/HTML");
    }
  }
}
