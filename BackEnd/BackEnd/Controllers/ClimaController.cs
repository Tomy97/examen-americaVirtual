using BackEnd.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClimaController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public ClimaController(AplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Clima/Paises
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> Paises()
        {
            try
            {
                var listPaises = await _context.Paises.ToListAsync();
                return Ok(listPaises);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            };
        }
        
        // GET: api/Clima/Ciudades/3
        [HttpGet]
        [Route("[action]/{paisId}")]
        public async Task<IActionResult> Ciudades(int paisId)
        {
            try
            {
                var listCiudades = await _context.Ciudades.Where(c => c.PaisId == paisId).ToListAsync();
                return Ok(listCiudades);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            };
        }
    }
}
