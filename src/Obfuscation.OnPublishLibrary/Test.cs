using System;
using Newtonsoft.Json.Linq;

namespace Obfuscation.OnPublishLibrary
{
    public class Test
    {
        public void Run()
        {
            JObject json = new();
            json["Name"] = "Allen.Cai";
            json["CreatedDate"] = DateOnly.FromDateTime(DateTime.Now).ToString();
            json["TypeName"] = typeof(Test).Name;
            Console.WriteLine(json);
            Console.Write("Press <Enter> to exit... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}