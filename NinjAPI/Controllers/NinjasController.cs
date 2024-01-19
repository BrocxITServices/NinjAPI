using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NinjAPI.Data;
using NinjAPI.Models;

namespace NinjAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NinjasController : ControllerBase
    {
        private readonly GymContext _dbContext;

        public NinjasController(GymContext context)
        {
            _dbContext = context;
        }

        //TODO create new ninja 
        [HttpPost(Name = "AddNinja")]
        public IActionResult Post(Ninja ninja)
        {
            ninja.NinjaTraining ??= Array.Empty<NinjaTraining>();   

            if (!ModelState.IsValid) return BadRequest(ModelState);

            _dbContext.Ninjas.Add(ninja);
            _dbContext.SaveChanges();
            return Ok();
        }

        [HttpDelete(Name = "DeleteNinja")]

        public async Task<IActionResult> DeleteById(Guid ninjaId)
        {
            if (ninjaId == Guid.Empty) return BadRequest("Id is invalid");

            var ninja = await _dbContext.Ninjas.FindAsync(ninjaId);
            _dbContext.Ninjas.Remove(ninja);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpGet(Name = "GetNinjaById")]
        public async Task<IActionResult> GetById(Guid ninjaId)
        {
            if (ninjaId == Guid.Empty) return BadRequest("Id is invalid");

            var foundEntity = await _dbContext.Ninjas.FirstOrDefaultAsync(c => c.Id == ninjaId);
            return Ok(foundEntity);
        }

        [HttpPut(Name = "UpdateNinja")]
        public async Task<IActionResult> PutNinja(Ninja? ninja)
        {
            if (ninja.Id == Guid.Empty) return BadRequest("Id is invalid");

            _dbContext.Entry(ninja).State = EntityState.Modified; //Tells EF that entity has been modified and needs to be updated in DB
            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NinjaExists(ninja.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Ok();
        }

        private bool NinjaExists(Guid ninjaId)
        {
            return (_dbContext.Ninjas?.Any(e => e.Id == ninjaId)).GetValueOrDefault();
        }

    }
}
