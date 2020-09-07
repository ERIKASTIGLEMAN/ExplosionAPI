using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/Explosion")]
    [ApiController]
    public class ExplosionController : ControllerBase
    {
        [HttpGet]
        public string RunExplosion(string s)
        {
            var expString = "";

            for (var i = 0; i < s.Length; i++)
            {
                var numChar = s[i].ToString();

                var num = int.Parse(numChar);

                for (var j = 0; j < num; j++)
                {
                    expString += numChar;
                }
            }
            return expString;
        }
    }
}