using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class Util
    {
        public static class JsonUtil
        {
            public static string ConvertToJson(object obj)
            {
                return JsonConvert.SerializeObject(obj);
            }
            public static T ConvertToObject<T>(string json)
            {
                return JsonConvert.DeserializeObject<T>(json);
            }
        }

        public static string GetStringMenssage(ArraySegment<byte> data)
        {
            return Encoding.UTF8.GetString(data.Array, 0, data.Count);
        }
    }
}
