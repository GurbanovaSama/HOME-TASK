using Newtonsoft.Json;
using System.Diagnostics;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;




namespace AsyncProgramming
{
    internal class Program
    {
        static async Task Main()
        {
            #region Task 1
            //Console.WriteLine("Non-async sorgularin umumi vaxti:");
            //NonAsyncTime();
            //Console.WriteLine("Async sorgularin umumi vaxti:");
            //await AsyncTime();
            #endregion

            #region Task 2
            string path = @"C:\Users\Sema Gurbanova\source\repos\AsyncProgramming\AsyncProgramming";
            Directory.CreateDirectory(path + @"\Models");
            Directory.CreateDirectory(path + @"\Data");

            if (!File.Exists(path + @"\Data\jsonData.json"))
            {
                File.Create(path + @"\Data\jsonData.json");
            }
            else
            {
                Console.WriteLine("Already exists");
            }

            if (!File.Exists(path + @"\Models\model.txt"))
            {
                File.Create(path + @"\Models\model.txt");
            }
            else
            {
                Console.WriteLine("Already exists");
            }

            using (File.Create(path + @"\Data\jsonData.json"))
            {

            }
            using (File.Create(path + @"\Models\model.txt"))
            {

            }



            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = "https://jsonplaceholder.typicode.com/posts";
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string jsonData = await response.Content.ReadAsStringAsync();

                    List<Post> posts = JsonConvert.DeserializeObject<List<Post>>(jsonData);
                    string jsonOutput = JsonConvert.SerializeObject(posts, Formatting.Indented);

                    string filePath = (path + @"/Data/jsonData.json");
                    await File.WriteAllTextAsync(filePath, jsonOutput);
                    Console.WriteLine("Melumatlar jsonData.json faylina daxil olundu");


                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error bas verdi" + ex.Message);
                }
            }
            #endregion
        }

        #region Task 1
        //private static readonly string[] urls = new string[] 
        //{
        //    "https://learn.microsoft.com/en-us/dotnet/csharp/",
        //    "https://www.w3schools.com/cs/index.php",
        //    "https://learn.microsoft.com/en-us/dotnet/fundamentals/networking/http/httpclient-guidelines",
        //    "https://en.wikipedia.org/wiki/C_Sharp_(programming_language)"
        //};

        //private static void NonAsyncTime()
        //{
        //    var stopwatch = Stopwatch.StartNew();

        //    using (HttpClient client = new HttpClient())
        //    {
        //        foreach (var url in urls)
        //        {
        //            var response = client.GetAsync(url).Result;
        //            Console.WriteLine($"{url}");
        //        }
        //    }
        //    stopwatch.Stop();
        //    Console.WriteLine($"Non-async sorgunun muddeti: {stopwatch.ElapsedMilliseconds}");
        //}

        //private static async Task AsyncTime()
        //{
        //    var stopwatch = Stopwatch.StartNew();

        //    using (HttpClient client = new HttpClient())
        //    {
        //        var tasks = new Task<HttpResponseMessage>[urls.Length];
        //        for (int i = 0; i < urls.Length; i++)
        //        {
        //            tasks[i] = client.GetAsync(urls[i]);
        //        }
        //        var responses = await Task.WhenAll(tasks);

        //    }
        //    stopwatch.Stop();
        //    Console.WriteLine($"Async sorgularin vaxti : {stopwatch.ElapsedMilliseconds}");

        //}
        #endregion

        #region Task 2
        public class Post
        {
            public int UserId { get; set; }
            public int Id { get; set; }
            public string Title { get; set; }

        }
        #endregion
    }
}
