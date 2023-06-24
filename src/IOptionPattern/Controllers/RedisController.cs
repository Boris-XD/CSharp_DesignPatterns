using IOptionPattern.Services;
using Microsoft.AspNetCore.Mvc;

namespace IOptionPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RedisController : ControllerBase
    {
        private readonly IRedisService _redisService;

        public RedisController(IRedisService redisService)
        {
            _redisService = redisService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_redisService.GetConfigurationRedis());
        }
    }
}
