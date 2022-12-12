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
    public class ResultController : ControllerBase
    {
        private readonly ResultService resultService;
        private object _context;

        public ResultController(ResultService resultService)
        {
            this.resultService = resultService;
        }


        // GET: api/<ResultController>
        [HttpGet("[action]")]
        public IActionResult GetResult()
        {
            return Ok(resultService.GetResult());
        }

        // GET api/<ResultController>/5
        [HttpGet("[action]")]
        public IActionResult GetResultById(string id)
        {
            return Ok(resultService.GetResultById(id));
        }

        // POST api/<ResultController>
        [HttpPost("[action]")]
        public IActionResult AddResult([FromBody] ResultDto result)
        {
            resultService.AddResult(result);
            return Ok(resultService.GetResult());
        }

        // PUT api/<ResultController>/5
        [HttpPut("[action]")]
        public IActionResult UpdateResult([FromBody] ResultDto result)
        {
            resultService.UpdateResult(result);
            return Ok(resultService.GetResult());
        }

        // DELETE api/<ResultController>/5
        [HttpDelete("[action]")]
        public IActionResult DeleteResult(string id)
        {
            resultService.DeleteResult(id);
            return Ok(resultService.GetResult());
        }

    }
}