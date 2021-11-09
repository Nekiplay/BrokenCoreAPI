using BrokenAPI;
using System;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            BrokenCoreAPI api = new BrokenCoreAPI("");
            var user = api.threads.Get();
            foreach (var u in user)
            {
                Console.WriteLine(u.title);
                Console.WriteLine(u.username);
                Console.WriteLine(u.Forum.title);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
