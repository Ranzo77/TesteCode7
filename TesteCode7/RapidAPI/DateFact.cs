using Nancy.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TesteCode7.RapidAPI
{
    public class DateFact
    {
        public string text { get; set; }

        public int year { get; set; }

        public DateFact DeserializeDateFactJson(string json)
        {
            var serializer = new JavaScriptSerializer();

            return serializer.Deserialize<DateFact>(json);
        }
    }
}
