using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EaFrameWork.Config
{
    public class ConfigReader
    {
        public static TestSettings ReadConfig()
        {
            var configFile = File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)+"/appsettings.json");
            var jsonSerializationOptions = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true,
            };
            jsonSerializationOptions.Converters.Add(item: new JsonStringEnumConverter());
            return JsonSerializer.Deserialize<TestSettings>(configFile, jsonSerializationOptions);

        }
    }
}
