using acadamy_2024.Controllers.Models;
using acadamy_2024.Controllers.Repositories;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace acadamy_2024.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private Userrepository _userrepository;
        public UsersController()
        {
            _userrepository = new Userrepository();
        }
        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _userrepository.GetAll();
        }
        
        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            var user = _userrepository.GetById(id);
            return user== null ? NotFound(): user;
        }

        // POST api/<UsersController>
        [HttpPost]
        public ActionResult Post([FromBody] User data)
        {
            _userrepository.Create(data);
            return NoContent();
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] User data)
        {
            var user = _userrepository.Update(id, data);
            return user == null ? NotFound(): NoContent();
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return _userrepository.Delete(id) ? NoContent() : NotFound();
        }
    }
}
