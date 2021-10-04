using Nancy.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TesteCode7
{
    public class Code7Json
    {
        public string FirstName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public Code7Json DeserializeCode7Json()
        {
            var reader = new StreamReader(@"C:\Users\Felipe\source\repos\TesteCode7\Testes\Code7.json");
            var jsonFile = reader.ReadToEnd();
            var serializer = new JavaScriptSerializer();

            return serializer.Deserialize<Code7Json>(jsonFile);
        }
    }
}
