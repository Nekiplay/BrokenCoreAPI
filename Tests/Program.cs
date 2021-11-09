using BrokenAPI;
using System;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            BrokenCoreAPI api = new BrokenCoreAPI("");
            var user = api.threads.posts.Get(23553);
            foreach (var u in user)
            {
                Console.WriteLine("Message: " + u.message);
                Console.WriteLine("Author: " + u.username);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
