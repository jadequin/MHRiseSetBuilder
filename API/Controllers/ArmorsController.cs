using System.Collections.Generic;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
  public class ArmorsController : BaseApiController
  {
    private readonly DataContext _context;
    public ArmorsController(DataContext context)
    {
      _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Armor>>> GetArmors()
    {
        return await _context.Armors.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Armor>> GetArmor(int id)
    {
        return await _context.Armors.FindAsync(id);
    }
  }
}