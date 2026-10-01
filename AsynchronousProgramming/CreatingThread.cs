using System;

namespace AsynchronousProgramming
{
    class CreatingThread
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(DoWork));
            thread.Start();

            Console.WriteLine("Main thread does some work, then waits.");
            thread.Join();
        }

        private static void DoWork()
        {
            Console.WriteLine("Working on a thread.");
        }

        // async & await
         static async Task Main(){
            Console.WriteLine("Main thread does some work, then waits.");
            await TaskMethodAsync();
        }
        static async Task TaskMethodAsync()
        {
            await Task.Delay(1000);
            Console.WriteLine("Task completed.");
        }

        static async Task Main()
        {
            Console.WriteLine("task1 started");
            await DownloadPageAsync();
        }

        private static async Task DownloadPageAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync("https://www.example.com");
                Console.WriteLine(result);
            }
            throw new NotImplementedException();
        }
    }
}