using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ViewModel.ModelsDto;
using BLL;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectForCycleController : ControllerBase
    {
        private readonly SubjectForCycleService subjectForCycleService;
        private object _context;

        public SubjectForCycleController(SubjectForCycleService subjectForCycleService)
        {
            this.subjectForCycleService = subjectForCycleService;
        }


        // GET: api/<SubjectForCycleController>
        [HttpGet("[action]")]
        public IActionResult GetSubjectForCycle()
        {
            return Ok(subjectForCycleService.GetSubjectForCycle());
        }

        // GET api/<SubjectForCycleController>/5
        [HttpGet("[action]")]
        public IActionResult GetSubjectForCycleById(string id)
        {
            return Ok(subjectForCycleService.GetSubjectForCycleById(id));
        }

        // POST api/<SubjectForCycleController>
        [HttpPost("[action]")]
        public IActionResult AddSubjectForCycle([FromBody] SubjectForCycleDto subjectForCycle)
        {
            subjectForCycleService.AddSubjectForCycle(subjectForCycle);
            return Ok(subjectForCycleService.GetSubjectForCycle());
        }

        // PUT api/<SubjectForCycleController>/5
        [HttpPut("[action]")]
        public IActionResult UpdateSubjectForCycle([FromBody] SubjectForCycleDto subjectForCycle)
        {
            subjectForCycleService.UpdateSubjectForCycle(subjectForCycle);
            return Ok(subjectForCycleService.GetSubjectForCycle());
        }

        // DELETE api/<SubjectForCycleController>/5
        [HttpDelete("[action]")]
        public IActionResult DeleteSubjectForCycle(string id)
        {
            subjectForCycleService.DeleteSubjectForCycle(id);
            return Ok(subjectForCycleService.GetSubjectForCycle());
        }

    }
}