using Nancy.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TesteCode7
{
    public class GoogleAccountJson
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Key { get; set; }

        public List<DataNascimento> DataNascimento { get; set; }

        public string PhoneNumber { get; set; }

        public string Gender { get; set; }

        public GoogleAccountJson DeserializeCode7Json()
        {
            var reader = new StreamReader(@"C:\Users\Felipe\source\repos\TesteCode7\Testes\GoogleAccount.json");
            var jsonFile = reader.ReadToEnd();
            var serializer = new JavaScriptSerializer();

            return serializer.Deserialize<GoogleAccountJson>(jsonFile);
        }
    }

    public class DataNascimento
    {
        public string Day { get; set; }

        public string Month { get; set; }

        public string Year { get; set; }
    }
}
