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
    public class DayController : ControllerBase
    {
        private readonly DayService dayService;
        private object _context;

        public DayController(DayService dayService)
        {
            this.dayService = dayService;
        }


        // GET: api/<DayController>
        [HttpGet("[action]")]
        public IActionResult GetDay()
        {
            return Ok(dayService.GetDay());
        }

        // GET api/<DayController>/5
        [HttpGet("[action]")]
        public IActionResult GetDayById(string id)
        {
            return Ok(dayService.GetDayById(id));
        }

        // POST api/<DayController>
        [HttpPost("[action]")]
        public IActionResult AddDay([FromBody] DayDto day)
        {
            dayService.AddDay(day);
            return Ok(dayService.GetDay());
        }

        // PUT api/<DayController>/5
        [HttpPut("[action]")]
        public IActionResult UpdateDay([FromBody] DayDto day)
        {
            dayService.UpdateDay(day);
            return Ok(dayService.GetDay());
        }

        // DELETE api/<DayController>/5
        [HttpDelete("[action]")]
        public IActionResult DeleteDay(string id)
        {
            dayService.DeleteDay(id);
            return Ok(dayService.GetDay());
        }

    }
}