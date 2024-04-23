using Microsoft.Extensions.Options;
using StronglyTypedConfigurations.Common;
using StronglyTypedConfigurations.Controllers;

namespace StronglyTypedConfigurations.Services
{
    public class MyService
    {
        private readonly ApiConfig _config;
        public MyService(IOptions<ApiConfig> config)
        {
            _config=config.Value;
        }
        public ApiConfig GetApiConfig()
        {
            return _config;
        }
    }
}
