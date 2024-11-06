using Newtonsoft.Json;



namespace DirectoryFileTask
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string path = @"C:\Users\Sema Gurbanova\source\repos\DirectoryFileTask\DirectoryFileTask";
            Directory.CreateDirectory(path + @"\Models");
            Directory.CreateDirectory(path + @"\Data");

            if(!File.Exists(path + @"\Data\jsonData.json"))
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
        }
    }
    public class Post
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
      
    }

}

