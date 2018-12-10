using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SampleWebApi.Controllers
{
[Route("api/[controller]")]
    [ApiController]
    public class GreetController : ControllerBase
    {
    [HttpGet]
        public string Index()
        {
            return "Hello! Welcome to azure devops...";
        }
    }
}
