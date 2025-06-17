using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiApp1.Models;
using ApiApp1.Data;

namespace ApiApp1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FishCatchController : ControllerBase
    {
        private readonly FishDbContext _context;

        public FishCatchController(FishDbContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.FishCatchs.ToList());
        }
    }
}
