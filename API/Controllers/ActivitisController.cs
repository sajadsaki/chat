using System;
using Microsoft.AspNetCore.Mvc;
using Domin;
using Persistent;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MediatR;
using Application.Activitis;

namespace API.Controllers
{
    public class ActivitisController : BaseApiController
    {
  

 
        [HttpGet]
        public async Task<ActionResult<List<Activiti>>> GetActivitis(CancellationToken ct)
        {
          return await Mediator.Send(new Application.Activitis.List.Query(),ct);
        } 

         [HttpGet("{id}")]
        public async Task<ActionResult<Activiti>> GetActiviti(Guid id)
        {
         
          return await  Mediator.Send(new Details.Query{Id=id});
        } 

        [HttpPost]
        public async Task<IActionResult> CreateActivity([FromBody]Activiti activity)
        {
          return Ok(await Mediator.Send(new Create.Command{activiti=activity}));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditActiviti(Guid id,Activiti activiti)
        {
          activiti.Id=id;
          return Ok(await Mediator.Send(new Edit.Command{activiti=activiti}));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActiviti(Guid id)
        {
      
          return Ok(await Mediator.Send(new Delete.Command{id=id}));
        }
    }
}