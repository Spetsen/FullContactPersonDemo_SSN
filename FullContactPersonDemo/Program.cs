using System;
using Newtonsoft.Json;
using Nito.AsyncEx;

namespace FullContactPersonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                AsyncContext.Run(() => MainAsync(args));
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                Console.Error.WriteLine("Exiting");
            }
        }

        private static async void MainAsync(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Please provide your FullContact API key as argument.");
                return;
            }

            JsonConvert.DefaultSettings =
                () => new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, Formatting = Formatting.Indented };

            var api = new FullContactApi.FullContactApi(args[0]);
            string mail;
            Console.WriteLine("Write an e-mail address followed by pressing the enter key to get contact info.");
            Console.WriteLine("Press Enter without writing anything to exit.");
            Console.WriteLine();

            while ((mail = Console.ReadLine()) != string.Empty)
            {
                var task = api.LookupPersonByEmailAsync(mail);
                Console.WriteLine("Getting contact information for {0}.", mail);

                // Uncomment next line to demonstrate the asynchronous lookup of e-mail (Please wait not printed)
                //await Task.Delay(1000);
                
                if (!task.IsCompleted)
                {
                    Console.WriteLine("Please wait...");
                }
                Console.WriteLine();
                Console.WriteLine(JsonConvert.SerializeObject(await task));
                Console.WriteLine();
                Console.WriteLine("Write a new e-mail address or press Enter to exit.");
                Console.WriteLine();
            } 
        }
    }
}
