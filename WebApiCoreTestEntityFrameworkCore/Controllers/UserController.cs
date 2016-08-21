using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ConsoleApplication
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IRepository<User> _userReporitory;
        private ILogger<UserController> _logger;
        public UserController(IRepository<User> userReporitory,ILogger<UserController> logger){
            _userReporitory = userReporitory;
            _logger = logger;
        }
        [HttpGet]
        public IActionResult GetAll(){
           var list = _userReporitory.GetAllList();
           return new ObjectResult(list);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var user = _userReporitory.Get(id);
            return new ObjectResult(user);
        }
        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            if(user == null)
			{
                return BadRequest();
            }
            user.Id = new Random().Next(1, 999);
            return CreatedAtAction("Get", new { id = user.Id}, user);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id,[FromBody] User user)
		{
             if(user == null)
			 {
                return BadRequest();
            }
            return new NoContentResult();
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
		{
            
        }
    }
}