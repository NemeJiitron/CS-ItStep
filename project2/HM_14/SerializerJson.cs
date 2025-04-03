using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace project2.HM_14
{
    internal class SerializerJson
    {
        public static void Save<T>(T val, string path)
        {
            string serializedFracs = JsonSerializer.Serialize(val);
            Console.WriteLine(serializedFracs);
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(serializedFracs);
            }
        }
        public static T Load<T>(string path)
        {
            T val;
            using (StreamReader sr = new StreamReader(path))
            {
                val = JsonSerializer.Deserialize<T>(sr.ReadToEnd());
            }
            return val;
        }
    }
}
