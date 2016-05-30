using Newtonsoft.Json;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace SeenTechnology.Domain.Util
{
    public static class ExtendJson
    {
        public static void ExportToJson<T>(this T obj, string filename, string path)
        {
            using (var sw = new StreamWriter(Path.Combine(path, $"{filename}.js")))
            {
                var serializer = new JsonSerializer();
                var writer = new JsonTextWriter(sw);
                serializer.Serialize(writer, obj);
            }
        }

        public static T ImportJson<T>(string path) where T : class
        {
            var os = File.ReadAllText(path);

            var ser = new DataContractJsonSerializer(typeof(T));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(os));
            var obj = (T)ser.ReadObject(ms);

            return obj;
        }
    }
}
