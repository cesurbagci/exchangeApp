using System;
using System.Collections.Generic;

namespace JsonExporterExtension {

    public static class JsonExporter
    {
        public static string ConvertToJson<T>(this List<T> items) {
            if (items is null)
            {
                throw new ArgumentNullException(nameof(items));
            }

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(items);
            Console.WriteLine(json);
            
            return json;
        }
    }

}