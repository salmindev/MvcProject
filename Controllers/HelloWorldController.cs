using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
  public class HelloWorldController : Controller
  {
       public IActionResult Index()
       {
         return View();
       }
       public IActionResult Welcome(string name, int numtimes= 1)
       {
         ViewData["message"] = "Habari" + name;
         ViewData["NumTimes"] = numtimes;
         return View();
       }
  }
}