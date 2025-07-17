using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsynCalls
{
    class Person
    {
        public static async Task VideoDownloading()
        {
            Console.WriteLine("VideoDownloading Started");
            var startTime = DateTime.Now;
            await Task.Delay(5000); // please wait....to telling to the compiler
            var endTime = DateTime.Now;
            var elapsedTime = endTime - startTime;
            Console.WriteLine($"Video download completion Time: {elapsedTime.Milliseconds} ms.");

        }

        public static async Task InstagramReels()
        {
            Console.WriteLine("Instagram watching Started");
            var startTime = DateTime.Now;
            await Task.Delay(8000); // please wait....to telling to the compiler
            var endTime = DateTime.Now;
            var elapsedTime = endTime - startTime;
            Console.WriteLine($"Instagram Watching Time: {elapsedTime.Milliseconds} ms.");

        }

        public static async Task ChatWithFriends()
        {
            Console.WriteLine("Chating Started");
            var startTime = DateTime.Now;
            await Task.Delay(3000); // please wait....to telling to the compiler
            var endTime = DateTime.Now;
            var elapsedTime = endTime - startTime;
            Console.WriteLine($"Chating time With Friends: {elapsedTime.Milliseconds} ms.");

        }
    }

    class Details
    {
        public static async Task Performance()
        {
            await Person.VideoDownloading();

            await Person.InstagramReels();

            await Person.ChatWithFriends();

            Task first = Person.VideoDownloading();

            Task second = Person.InstagramReels();

            Task third = Person.ChatWithFriends();


            await first;
            await second;
            await third;

            first.Wait();
            second.Wait();
            third.Wait();
        }
    }

    class Program
    {
        static async Task Main()
        {
            await Details.Performance();
        }
    }
}