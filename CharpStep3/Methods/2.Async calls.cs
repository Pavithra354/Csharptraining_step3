using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronousCalls
{
    class WorkItems
    {
        public static async Task PrepareWordDocumentationAsync()
        {
            var startTime = DateTime.Now;
            await Task.Delay(1000);   // please wait....to telling to the compiler
            var endTime = DateTime.Now;
            var elapsedTime = endTime - startTime;
            Console.WriteLine($"Completed the Doucumentation Elapsed time: {elapsedTime.Milliseconds} ms.");
        }

        public static async Task PreparePPTAsync()
        {
            var startTime = DateTime.Now;
            await Task.Delay(5000);   // please wait....to telling to the compiler
            var endTime = DateTime.Now;
            var elapsedTime = endTime - startTime;
            Console.WriteLine($"Completed the Doucumentation Elapsed time: {elapsedTime.Milliseconds} ms.");
        }

        public static async Task PrepareNotesAsync()
        {
            var startTime = DateTime.Now;
            await Task.Delay(4000);   // please wait....to telling to the compiler
            var endTime = DateTime.Now;
            var elapsedTime = endTime - startTime;
            Console.WriteLine($"Completed the Doucumentation Elapsed time: {elapsedTime.Milliseconds} ms.");
        }
    }

    class Trainer
    {
        public static async Task Works()
        {
            Console.WriteLine("Concurrent Works - Running All Tasks Simultaneously");

            var startTime = DateTime.Now;
            // 10 secs


            //await WorkItems.PrepareWordDocumentationAsync(); 
            //await WorkItems.PreparePPTAsync();
            //await WorkItems.PrepareNotesAsync();



            Task documentTask = WorkItems.PrepareWordDocumentationAsync();

            Task PPTTask = WorkItems.PreparePPTAsync();

            Task notesTask = WorkItems.PrepareNotesAsync();

            await Task.WhenAll(documentTask, PPTTask, notesTask); // wait for all tasks

            


            var endTime = DateTime.Now;

            var totaltime = endTime - startTime;

            Console.WriteLine($"Now my Tasks are completed{totaltime}");


        }
    }


    class Program
    {
        static async Task Main()
        {
            await Trainer.Works();
        }
    }
}

