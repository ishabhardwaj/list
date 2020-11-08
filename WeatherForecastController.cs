using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Web;
using System.Net.Http;


namespace Webdemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
     static List<string> names = new List<string>()
         {
            "harshit","naina","isha"
         };
        public IEnumerable<string> Get()
        {
            return names;
        }
        public string Get (int id) {
            return names[id];
        }
        public void Post([FromBody]string value)
        {
            names.Add(value);
        }
        public void Put(int id,[FromBody]string value)
        {
            names[id] = value;
        }
        public void Delete(int id) 
        {
            names.RemoveAt(id);
        }
        
    }
}
