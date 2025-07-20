using System;
using System.Threading.Tasks;

namespace AsyncAppSimulation
{
    class AppTasks
    {
        public static async Task<string> InstagramUploadAsync()
        {
            string appName = "Instagram";
            int delay = 3000;

            Console.WriteLine($"{appName}: Uploading a reel... 🎥");
            await Task.Delay(delay);
            Console.WriteLine($"{appName}: Reel uploaded in {delay / 1000} sec ✅");

            return $"{appName}: Upload successful";
        }

        public static async Task<string> WhatsAppMessageAsync()
        {
            string appName = "WhatsApp";
            int delay = 2000;

            Console.WriteLine($"{appName}: Sending a message... 💬");
            await Task.Delay(delay);
            Console.WriteLine($"{appName}: Message sent in {delay / 1000} sec ✅");

            return $"{appName}: Message delivered";
        }

        public static async Task<string> MovieStreamingAsync()
        {
            string appName = "Netflix";
            int delay = 5000;

            Console.WriteLine($"{appName}: Buffering movie... 🍿");
            await Task.Delay(delay);
            Console.WriteLine($"{appName}: Movie started in {delay / 1000} sec 🎬");

            return $"{appName}: Movie playback started";
        }
    }

    class AppTracker
    {
        public static async Task TrackAllAppTasks()
        {
            var start = DateTime.Now;

            Task<string> instaTask = AppTasks.InstagramUploadAsync();
            Task<string> whatsAppTask = AppTasks.WhatsAppMessageAsync();
            Task<string> movieTask = AppTasks.MovieStreamingAsync();

            string[] results = await Task.WhenAll(instaTask, whatsAppTask, movieTask);

            Console.WriteLine("\n📱 --- App Activity Summary ---");
            foreach (string result in results)
            {
                Console.WriteLine(result);
            }

            var end = DateTime.Now;
            Console.WriteLine($"⏱ Total time: {(end - start).TotalSeconds} sec");
        }
    }

    class Program
    {
        static async Task Main()
        {
            await AppTracker.TrackAllAppTasks();
            Console.WriteLine("✅ All tasks completed.");
        }
    }
}