using BrokenAPI;
using System;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            BrokenCoreAPI api = new BrokenCoreAPI("API Key");
            var resource = api.resources.Get(1175);
            int version = 0;
            int.TryParse(resource.version.Replace(".", ""), out version);
            Console.WriteLine(version);
            Console.ReadLine();
        }
    }
}
