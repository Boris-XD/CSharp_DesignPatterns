using IOptionPattern.Configuration;

namespace IOptionPattern.Services
{
    public interface IRedisService
    {
        RedisConfiguration GetConfigurationRedis();
    }
}
