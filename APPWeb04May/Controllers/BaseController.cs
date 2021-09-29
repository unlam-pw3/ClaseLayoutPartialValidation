using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APPWeb04May.Controllers
{
    public class BaseController : Controller
    {

        public BaseController()
        {
            ViewData["General"] = "Mensaje PAra ViewData";
        }
    }
}
