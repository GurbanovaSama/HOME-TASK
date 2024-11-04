using System.Diagnostics;



namespace AsyncProgramming
{
    internal class Program
    {
        static async Task Main()
        {
            Console.WriteLine("Non-async sorgularin umumi vaxti:");
            NonAsyncTime();
            Console.WriteLine("Async sorgularin umumi vaxti:");
            await AsyncTime();  
        }

        private static readonly string[] urls = new string[] 
        {
            "https://learn.microsoft.com/en-us/dotnet/csharp/",
            "https://www.w3schools.com/cs/index.php",
            "https://learn.microsoft.com/en-us/dotnet/fundamentals/networking/http/httpclient-guidelines",
            "https://en.wikipedia.org/wiki/C_Sharp_(programming_language)"
        };




        private static void NonAsyncTime()
        {
            var stopwatch = Stopwatch.StartNew();

            using (HttpClient client = new HttpClient())
            {
                foreach (var url in urls)
                {
                    var response = client.GetAsync(url).Result;
                    Console.WriteLine($"{url}");
                }
            }
            stopwatch.Stop();
            Console.WriteLine($"Non-async sorgunun muddeti: {stopwatch.ElapsedMilliseconds}");
        }




        private static async Task AsyncTime()
        {
            var stopwatch = Stopwatch.StartNew();

            using (HttpClient client = new HttpClient())
            {
                var tasks = new Task<HttpResponseMessage>[urls.Length];
                for (int i = 0; i < urls.Length; i++)
                {
                    tasks[i] = client.GetAsync(urls[i]);
                }
                var responses = await Task.WhenAll(tasks);

            }
            stopwatch.Stop();
            Console.WriteLine($"Async sorgularin vaxti : {stopwatch.ElapsedMilliseconds}");
        }
    }
}
