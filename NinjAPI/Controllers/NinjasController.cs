using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NinjAPI.Data;
using NinjAPI.Models;

namespace NinjAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NinjasController : ControllerBase
    {
        private readonly GymContext _context;

        public NinjasController(GymContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "GetNinja")]
        // GET: Ninjas
        public IActionResult Index()
        {
            return Ok(); //TODO GetNinjas from db
        }

        //TODO create new ninja 
        [HttpPost(Name = "AddNinja")]
        public IActionResult Post(Ninja ninja)
        {
            ninja.NinjaTraining ??= Array.Empty<NinjaTraining>();   

            if (!ModelState.IsValid) return BadRequest(ModelState);

            //var ninja = new Ninja();
            //ninja.Name = "Henkie";
            //ninja.DateOfBirth = new DateOnly(2000, 2, 12);
            //ninja.Specialization = 0;
            //ninja.Role = "Trainer";
            _context.Ninjas.Add(ninja);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete(Name = "DeleteNinja")]

        public async Task<IActionResult> DeleteById(Guid ninjaId)
        {
            if (ninjaId == Guid.Empty) return BadRequest("Id is invalid");

            var ninja = await _context.Ninjas.FindAsync(ninjaId);
            _context.Ninjas.Remove(ninja);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
