using System;
using Newtonsoft.Json.Linq;

namespace Obfuscation.AfterBuild
{
    class Program
    {
        static void Main(params string[] args)
        {
            JObject json = new();
            json["Name"] = "Allen.Cai";
            json["CreatedDate"] = DateOnly.FromDateTime(DateTime.Now).ToString();
            json["TypeName"] = typeof(Program).Name;
            Console.WriteLine(json);
            Console.Write("Press <Enter> to exit... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}