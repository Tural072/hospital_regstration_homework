using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_regstration_homework
{
    class JsonF
    {

        public static void JsonSerializer(object obj) {
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter("Hospital.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, obj);
                }
            }
        }

    }
}
