using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SampleWebApi.Controllers
{
    public class GreetController : Controller
    {
        public string Index()
        {
            return "Hello! Welcome to azure devops...";
        }
    }
}