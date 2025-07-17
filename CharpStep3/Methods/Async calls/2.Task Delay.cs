using System;
using System.Threading;
using System.Threading.Tasks;



namespace TaskDelayNamespace
{

    
    class TaskDelayCls
    {
        static async Task Method1()
        {
            Console.WriteLine("Printinig");
            await Task.Delay(10000);
            Console.WriteLine("Method 1");
        }

        static async Task Method2()
        {
            await Task.Delay(5000);
            Console.WriteLine("Method 2");
        }

        
        static async Task Main()
        {
            await TaskDelayCls.Method1();   // wait upto get the response
            Console.WriteLine("MEthod1 is completed");


            
            await TaskDelayCls.Method2();// wait upto get the response
            Console.WriteLine("Method2 is completed");
        }
    }
}



