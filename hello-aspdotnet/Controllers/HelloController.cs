using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace hello_aspdotnet.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            string html = "<form method='post'>" +
                "<input type='text' name='name' />" +
                "<select name='language'><option value='english' selected>English</option>" +
                "<option value='spanish'>Spanish</spanish>" +
                "<option value='bosnian'>Bosnian</option>" +
                "<option value='vietnamese'>Vietnamese</option>" +
                "<option value='french'>French</option></select>" +
                "<input type='submit' value='Greet Me!'/>" +
                "</form>";

            return Content(html, "text/html");

        }

        [Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string name = "World", string language = "english")
        {
            return Content(CreateMessage(name, language));

        }

        public static string CreateMessage(string name, string language)
        {
            string helloTranslation = "";
            switch (language)
            {
                case "french":
                    helloTranslation = "Bonjour ";
                    break;
                case "spanish":
                    helloTranslation = "Hola ";
                    break;
                case "bosnian":
                    helloTranslation = "Zdravo ";
                    break;
                case "vietnamese":
                    helloTranslation = "Xin Chao ";
                    break;
                case "english":
                    helloTranslation = "Hello ";
                    break;
            }
            return helloTranslation + name;

            // For a bonus mission, students can change this response text to look nicer.
            // This is subjective, but students should be modifying the HTML of the response string.

        }


    }
}
