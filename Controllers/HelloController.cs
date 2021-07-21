using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method= 'post' action= '/helloworld/language/'>" + 
                "<input type= 'text' name= 'name' />" +  
                "<select name='language' id='language'> <option value=''> Choose a language </option> <option value='english'> English </option> <option value='german'> German </option> <option value='french'> French </option> <option value='italian'> Italian </option> <option value='swedish'> Swedish </option>" + 
                "</select>" + 
                "<input type= 'submit' value= 'Greet Me!' />" + 
                "</form>";
        
            return Content(html, "text/html");
        }

        [HttpGet("welcome/{name?}")]
        [HttpPost("welcome")]
        public IActionResult Welcome(string name = "World")
        {
            return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        }
        

        [HttpGet("language/")]
        [HttpPost("language")]
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
