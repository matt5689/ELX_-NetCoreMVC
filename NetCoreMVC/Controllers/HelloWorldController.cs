using Microsoft.AspNetCore.Mvc;
using NetCoreMVC.Models;

namespace NetCoreMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View(new HelloWorldModel 
            { 
                HelloWorldModelString = "Hello World Model String Value" 
            });
        }
    }
}
