using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC_APP.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/\
        //GIVES US A RESULT OF METHOD ACTIONED
        public IActionResult Index()
        {
            return View(); // Index() speaks to a file with the same name as our controller in the views folder
            // the views folder
            //Views/Hello: by default it looks for index like any web server
            //View = the name of the method if it matches the views/'insertnamehere'
        }

        public IActionResult About()
        {
            return View();
            //View is looking inside of the Views folder - looking for About.cshtml and if finds it it renders it
        }
        /*
         * localhost:{PORT}/Hello/anythingwewant e.g Wassup
         
         */

        //This is our GET: /Hello/
        //public string Index() // our home for the controller
        //{
        //    return "This is my go to for the controller";
        ////}

        //// GET: /Hello/Wassup
        //public string Wassup() // 'sub-view' of our Hello controller
        //{
        //    return "Wassupppp";
        //}

        //// GET: /Hello/Demo
        //public string Demo(string name, int ID) // 'sub-view' of our Hello controller
        //{
        //    //return "demo";
        //    //name = "Emma";
        //    //ID = 1;
        //    return HtmlEncoder.Default.Encode($"Hello, {name}. Your ID number is: {ID}"); //use csharp in of html
        //}

    }
}
