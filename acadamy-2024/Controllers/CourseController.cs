using acadamy_2024.Controllers.Models;
using acadamy_2024.Controllers.Repositories;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace acadamy_2024.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private Courserepository _courserepository;
        public CourseController()
        {
            _courserepository = new Courserepository();
        }
        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<Course> Get()
        {
            return _courserepository.GetAll();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public ActionResult<Course> Get(int id)
        {
            var course = _courserepository.GetById(id);
            return course == null ? NotFound() : course;
        }

        // POST api/<UsersController>
        [HttpPost]
        public ActionResult Post([FromBody] Course data)
        {
            _courserepository.Create(data);
            return NoContent();
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Course data)
        {
            var course = _courserepository.Update(id, data);
            return course == null ? NotFound() : NoContent();
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return _courserepository.Delete(id) ? NoContent() : NotFound();
        }
    }
}
