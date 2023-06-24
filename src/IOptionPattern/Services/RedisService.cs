using IOptionPattern.Configuration;
using Microsoft.Extensions.Options;

namespace IOptionPattern.Services
{
    public class RedisService : IRedisService
    {
        private readonly RedisConfiguration _optionConfiguration;

        public RedisService(IOptions<RedisConfiguration> optionConfiguration)
        {
            _optionConfiguration = optionConfiguration.Value;
        }

        public RedisConfiguration GetConfigurationRedis()
        {
            return _optionConfiguration;
        }
    }
}
