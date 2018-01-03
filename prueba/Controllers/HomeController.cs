using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using prueba.Models;

namespace prueba.Controllers
{
    public class HomeController : Controller
    {

        // 
        // GET: /HelloWorld/

        

        // 
        // GET: /Home/Welcome/ 

        public string Welcome(String name)
        {
            //return "This is the Welcome action method... hola: "+name;
            return System.Text.Encodings.Web.HtmlEncoder.Default.Encode("nane: {name}");
        }  
        public IActionResult Index(){
            return View();
        }   
    }
}
