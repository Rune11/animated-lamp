using Newtonsoft.Json;

namespace XamarinRpg.Utils
{
    public static class Serializer
    {
        public static string SerializeToJson(object obj)
        {
            try
            {
                var json = JsonConvert.SerializeObject(obj);
                return json;
            }
            catch
            {
                System.Diagnostics.Debug.WriteLine("Serializing object failed! (Serializer.SerializeToJson)");
                throw;
            }
        }

        public static T DeserializeFromJson<T>(string jsonObj)
        {
            try
            {
                var result = JsonConvert.DeserializeObject<T>(jsonObj);
                return result;
            }
            catch
            {
                System.Diagnostics.Debug.WriteLine("Serializer.DeserializeFromJson couldn't deserialize object");
                throw;
            }
        }
    }
}
