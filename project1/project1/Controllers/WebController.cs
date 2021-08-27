using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project1.Controllers
{
    
    [Route("[controller]")]
    public class WebController : ControllerBase
    {
        private static List<string> studentnames = new List<string> { "A", "B", "C", "D" };

        public static List<string> Studentnames { get => studentnames; set => studentnames = value; }
        [HttpGet]
        public IEnumerable<string> GetName()
        {                                                                 

            return Studentnames;

        }
    }
}
