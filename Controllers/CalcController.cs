using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWatcher.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcController : ControllerBase
    { 
        [Route("[action]")]
        public ActionResult<string> Sum(
            [FromQuery(Name = "num1")] double num1,
            [FromQuery(Name = "num2")] double num2)
        {
            var sum = (num1 + num2).ToString();
            return $"The sum of numbers {num1} and {num2} is {sum}.";
        }

        [Route("[action]")]
        public ActionResult<string> SumInts(
            [FromQuery(Name = "num1")] int num1,
            [FromQuery(Name = "num2")] int num2)
        {
            var sum = (num1 + num2).ToString();
            return $"The sum of ints {num1} and {num2} is {sum}.";
        }

        [Route("[action]")]
        public ActionResult<string> SumDoubles(
            [FromQuery(Name = "num1")] double num1,
            [FromQuery(Name = "num2")] double num2)
        {
            var sum = (num1 + num2).ToString();
            return $"The sum of doubles {num1} and {num2} is {sum}.";
        }
    }
}
