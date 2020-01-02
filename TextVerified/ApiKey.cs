using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace TextVerified
{
    class ApiKey
    {
        public string apikey { get; set; }

        public string apisecret { get; set; }

        public static void WriteJson()
        {
            List<ApiKey> _data = new List<ApiKey>();
            _data.Add(new ApiKey()
            {
                apikey = "test",
                apisecret = "test"
            });

            using (StreamWriter file = File.CreateText("API.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Formatting = Formatting.Indented;
                serializer.Serialize(file, _data);
            }
        }

        public static dynamic ReadJson()
        {
            using (StreamReader r = new StreamReader("API.json"))
            {
                string json = r.ReadToEnd();
                List<ApiKey> APIInfo = JsonConvert.DeserializeObject<List<ApiKey>>(json);
                return APIInfo;
            }
            
        }

    }
}