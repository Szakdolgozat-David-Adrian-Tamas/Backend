using gameStore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class jatekController : ControllerBase
    {
        [HttpGet("kategoria/{kategoria}")]

        public IActionResult GetEgyjatek(string kategoria)
        {
            using (var context = new jatekshopContext())
            {
                try
                {
                    return Ok(context.Osszesjateks.Where(v => v.Kategoria == kategoria).ToList());
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
        }

        /*[HttpPut("{id:int}")]
        public IActionResult Kosar(Osszesjatek osszesjatek, int id)
        {
            using (var context = new jatekshopContext())
            {
                try
                {
                    if (id != osszesjatek.Id)
                    {
                        return BadRequest("Ilyen id-vel rendelkező játék nem található.");
                    }

                    if (id == osszesjatek.Id)
                    {
                        context.Osszesjateks.Update(osszesjatek);
                        context.SaveChanges();
                        return StatusCode(290, "A játék adatainak a módosítása sikeresen megtörtént.");
                    }

                    else
                    {
                        return BadRequest(400);
                    }

                }
                catch (Exception ex)
                {
                    return BadRequest("A játék módosítása sikertelen." + ex.Message);
                }
            }
        }*/

        /*[HttpGet("{id}")]

        public IActionResult GetEgyjatek(int id)
        {
            using (var context = new jatekshopContext())
            {
                    try
                    {
                        return Ok(context.Osszesjateks.Where(v => v.Id == id).ToList());
                    }
                    catch (Exception ex)
                    {
                        return BadRequest(ex.Message);
                    }
            }
        }*/

        [HttpGet("{id}/{egyediId}")]

        public IActionResult GetEgyjatek(int id, int egyediId)
        {
            using (var context = new jatekshopContext())
            {
                try
                {
                    return Ok(context.Osszesjateks.Where(v => v.Id == id).ToList());
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
        }

        [HttpGet]

        public IActionResult Get()
        {
            List<Osszesjatek> list = new List<Osszesjatek>();
            using (var context = new jatekshopContext())
            {
                try
                {
                    return StatusCode(200, context.Osszesjateks.ToList());
                }
                catch (Exception ex)
                {

                    return BadRequest(ex.Message);
                }
            }
        }

        [HttpPost]

        public IActionResult Post(Osszesjatek osszesjatek)
        {
            using (var context = new jatekshopContext())
            {
                try
                {
                    context.Osszesjateks.Add(osszesjatek);
                    context.SaveChanges();
                    return StatusCode(201, "A játék hozzáadása sikeresen megtörtént.");
                }
                catch (Exception ex)
                {
                    return BadRequest("A játék hozzáadása sikertelen." + ex.Message);
                }
            }
        }


        [HttpDelete]

        public IActionResult Delete(int Id)
        {
            using (var context = new jatekshopContext())
            {
                try
                {
                    Osszesjatek osszesjatek = new Osszesjatek();
                    osszesjatek.Id = Id;
                    context.Osszesjateks.Remove(osszesjatek);
                    context.SaveChanges();
                    return StatusCode(204, "A játék adatainak törlése sikeresen megtörtént.");
                }
                catch (Exception ex)
                {
                    return BadRequest("A játék törlése sikertelen." + ex.Message);
                }
            }
        }
    }
}