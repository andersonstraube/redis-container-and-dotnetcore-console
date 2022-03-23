using StackExchange.Redis;
using System;
using System.Timers;
using System.Threading.Tasks;

namespace Redis
{
    class Program
    {
        static void Main(string[] args)
        {
            var redis = ConnectionMultiplexer.Connect("localhost,port: 6379,password=@anderson");
            var db = redis.GetDatabase();
            db.StringSet("message", "It's worked");
            
            Console.WriteLine(db.StringGet("message"));

            Console.ReadLine();
        }
    }
}