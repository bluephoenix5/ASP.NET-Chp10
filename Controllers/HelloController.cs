using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloASPDotNET.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {    
            return View();
        }

        [HttpPost("/hello")]
        public IActionResult Welcome(string name = "World")
        {
            return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        }
        

        [HttpPost("hello/language")]
        public IActionResult CreateMessage(string language, string name)
        {
            string html = "";

            if (language == "English")
            {
                html = $"<h1> Hello {name} </h1>";
                return Content(html, "text/html");
            }
            else if (language == "German")
            {
                html = $"<h1> Hallo {name} </h1>";
                return Content(html, "text/html");
            }
            else if (language == "French")
            {
                html = $"<h1> Bonjour {name} </h1>";
                return Content(html, "text/html");
            }
            else if (language == "Italian")
            {
                html = $"<h1> Ciao {name} </h1>";
                return Content(html, "text/html");
            }
            else if (language == "Swedish")
            {
                html = $"<h1> Hej {name} </h1>";
                return Content(html, "text/html");
            }
            else
            {
                html = $"<h1> Sorry, that language is not supported </h1>";
                return Content(html, "text/html");
            }

        }
    }
}
