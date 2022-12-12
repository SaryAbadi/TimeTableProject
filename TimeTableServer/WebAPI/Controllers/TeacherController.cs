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
    public class TeacherController : ControllerBase
    {
        private readonly TeacherService teacherService;
        private object _context;

        public TeacherController(TeacherService teacherService)
        {
            this.teacherService = teacherService;
        }


        // GET: api/<TeacherController>
        [HttpGet("[action]")]
        public IActionResult GetTeacher()
        {
            return Ok(teacherService.GetTeacher());
        }

        // GET api/<TeacherController>/5
        [HttpGet("[action]")]
        public IActionResult GetTeacherById(string id)
        {
            return Ok(teacherService.GetTeacherById(id));
        }

        // POST api/<TeacherController>
        [HttpPost("[action]")]
        public IActionResult AddTeacher([FromBody] TeacherDto teacher)
        {
            teacherService.AddTeacher(teacher);
            return Ok(teacherService.GetTeacher());
        }

        // PUT api/<TeacherController>/5
        [HttpPut("[action]")]
        public IActionResult UpdateTeacher([FromBody] TeacherDto teacher)
        {
            teacherService.UpdateTeacher(teacher);
            return Ok(teacherService.GetTeacher());
        }

        // DELETE api/<TeacherController>/5
        [HttpDelete("[action]")]
        public IActionResult DeleteTeacher(string id)
        {
            teacherService.DeleteTeacher(id);
            return Ok(teacherService.GetTeacher());
        }

    }
}