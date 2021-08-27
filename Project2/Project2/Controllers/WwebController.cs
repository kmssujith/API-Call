using Hangfire.MemoryStorage.Dto;
using MaheApi.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nancy.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WwebController : ControllerBase
    {
        public List<String> StudentIndex()
        {
            var responseString = ApiCall.GetApi("https://localhost:44302/Web");
            var rootobject = new JavaScriptSerializer().Deserialize<List<String>>((string)responseString);
            return rootobject;
        }
    }
}
