using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace SupportClasses
{
    public static class Helpers
    {
        public static string Serialize(this object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public static T Deserialize<T>(this string obj) where T : class
        {
            return JsonConvert.DeserializeObject<T>(obj);
        }
    }
}
