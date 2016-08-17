using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ConsoleApplication
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private ILogger<UserController> _logger;
        public UserController(ILogger<UserController> logger){
            _logger = logger;
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            _logger.LogInformation("This is Information Log!");
            _logger.LogWarning("This is Warning Log!");
            _logger.LogError("This is Error Log!");

            var user = new User() { Id = id, Name = "name" + id, Sex = "Male" };
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