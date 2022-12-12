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
    public class LessonController : ControllerBase
    {
        private readonly LessonService lessonService;
        private object _context;

        public LessonController(LessonService lessonService)
        {
            this.lessonService = lessonService;
        }


        // GET: api/<LessonController>
        [HttpGet("[action]")]
        public IActionResult GetLesson()
        {
            return Ok(lessonService.GetLesson());
        }

        // GET api/<LessonController>/5
        [HttpGet("[action]")]
        public IActionResult GetLessonById(string id)
        {
            return Ok(lessonService.GetLessonById(id));
        }

        // POST api/<LessonController>
        [HttpPost("[action]")]
        public IActionResult AddLesson([FromBody] LessonDto lesson)
        {
            lessonService.AddLesson(lesson);
            return Ok(lessonService.GetLesson());
        }

        // PUT api/<LessonController>/5
        [HttpPut("[action]")]
        public IActionResult UpdateLesson([FromBody] LessonDto lesson)
        {
            lessonService.UpdateLesson(lesson);
            return Ok(lessonService.GetLesson());
        }

        // DELETE api/<LessonController>/5
        [HttpDelete("[action]")]
        public IActionResult DeleteLesson(string id)
        {
            lessonService.DeleteLesson(id);
            return Ok(lessonService.GetLesson());
        }

    }
}