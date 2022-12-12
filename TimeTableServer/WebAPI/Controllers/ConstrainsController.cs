using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ViewModel.ModelsDto;
using BLL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConstrainsController : ControllerBase
        {
        private readonly ConstrainsService constrainsService;
        private object _context;

        public ConstrainsController(ConstrainsService constrainsService)
        {
            this.constrainsService = constrainsService;
        }


        // GET: api/<ConstrainsController>
        [HttpGet("[action]")]
        public IActionResult GetContrains()
        {
            return Ok(constrainsService.GetConstrains());
        }

        // GET api/<ConstrainsController>/5
        [HttpGet("[action]")]
        public IActionResult GetConstrainsById(string id)
        {
            return Ok(constrainsService.GetConstrainsById(id));
        }

        // POST api/<ConstrainsController>
        [HttpPost("[action]")]
        public IActionResult AddConstrains([FromBody] ConstrainsDto constrains)
        {
            constrainsService.AddConstrains(constrains);
            return Ok(constrainsService.GetConstrains());
        }

        // PUT api/<ConstrainsController>/5
        [HttpPut("[action]")]
        public IActionResult UpdateConstrains([FromBody] ConstrainsDto constrains)
        {
            constrainsService.UpdateConstrains(constrains);
            return Ok(constrainsService.GetConstrains());
        }

        // DELETE api/<ConstrainsController>/5
        [HttpDelete("[action]")]
        public IActionResult DeleteConstrains(string id)
        {
            constrainsService.DeleteConstrains(id);
            return Ok(constrainsService.GetConstrains());
        }

    }
}
