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
    public class GradeController : ControllerBase
    {
        private readonly GradeService gradeService;
        private object _context;

        public GradeController(GradeService gradeService)
        {
            this.gradeService = gradeService;
        }


        // GET: api/<GradeController>
        [HttpGet("[action]")]
        public IActionResult GetGrade()
        {
            return Ok(gradeService.GetGrade());
        }

        // GET api/<GradeController>/5
        [HttpGet("[action]")]
        public IActionResult GetGradeById(string id)
        {
            return Ok(gradeService.GetGradeById(id));
        }

        // POST api/<GradeController>
        [HttpPost("[action]")]
        public IActionResult AddGrade([FromBody] GradeDto grade)
        {
            gradeService.AddGrade(grade);
            return Ok(gradeService.GetGrade());
        }

        // PUT api/<GradeController>/5
        [HttpPut("[action]")]
        public IActionResult UpdateGrade([FromBody] GradeDto grade)
        {
            gradeService.UpdateGrade(grade);
            return Ok(gradeService.GetGrade());
        }

        // DELETE api/<GradeController>/5
        [HttpDelete("[action]")]
        public IActionResult DeleteGrade(string id)
        {
            gradeService.DeleteGrade(id);
            return Ok(gradeService.GetGrade());
        }

    }
}