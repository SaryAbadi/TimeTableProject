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
    public class SubjectController : ControllerBase
    {
        private readonly SubjectService subjectService;
        private object _context;

        public SubjectController(SubjectService subjectService)
        {
            this.subjectService = subjectService;
        }


        // GET: api/<SubjectController>
        [HttpGet("[action]")]
        public IActionResult GetSubject()
        {
            return Ok(subjectService.GetSubject());
        }

        // GET api/<SubjectController>/5
        [HttpGet("[action]")]
        public IActionResult GetSubjectById(string id)
        {
            return Ok(subjectService.GetSubjectById(id));
        }

        // POST api/<SubjectController>
        [HttpPost("[action]")]
        public IActionResult AddSubject([FromBody] SubjectDto subject)
        {
            subjectService.AddSubject(subject);
            return Ok(subjectService.GetSubject());
        }

        // PUT api/<SubjectController>/5
        [HttpPut("[action]")]
        public IActionResult UpdateSubject([FromBody] SubjectDto subject)
        {
            subjectService.UpdateSubject(subject);
            return Ok(subjectService.GetSubject());
        }

        // DELETE api/<SubjectController>/5
        [HttpDelete("[action]")]
        public IActionResult DeleteSubject(string id)
        {
            subjectService.DeleteSubject(id);
            return Ok(subjectService.GetSubject());
        }

    }
}