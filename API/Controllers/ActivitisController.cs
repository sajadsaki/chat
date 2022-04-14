using System;
using Microsoft.AspNetCore.Mvc;
using Domin;
using Persistent;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace API.Controllers
{
    public class ActivitisController : BaseApiController
    {
        private readonly DataContext _context;
        public ActivitisController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Activiti>>> GetActivitis()
        {
          return await _context.Activities.ToListAsync();
        } 

         [HttpGet("{id}")]
        public async Task<ActionResult<Activiti>> GetActiviti(Guid id)
        {
          return await _context.Activities.FindAsync(id);
        } 
    }
}