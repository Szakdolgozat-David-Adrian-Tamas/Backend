using gameStore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace gameStore.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LogoutController : ControllerBase
    {
        [HttpPost("{FelhasznaloNev}")]

        /*public IActionResult Logout(string uId)
        {
            if (Program.LoggedInUsers.ContainsKey(uId))
            {
                Program.LoggedInUsers.Remove(uId);
                return Ok("Sikeres kijelentkezés.");
            }
            else
            {
                return BadRequest("Sikertelen kijelentkezés.");
            }
        }*/

        public IActionResult Logout(string FelhasznaloNev)
        {
            Felhasznalok felhasznalok= new Felhasznalok();
            if (felhasznalok.FelhasznaloNev==FelhasznaloNev)
            {
                return StatusCode(200);
            }
            else
            {
                return BadRequest("Sikertelen kijelentkezés");
            }
                    
            }
        }
    }
