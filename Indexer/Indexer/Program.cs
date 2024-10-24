namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "Shaki", "Baku", "Guba", "Khacmaz" };

            StringList stringList = new StringList(cities);

            Console.WriteLine(stringList["Baku"]);
            Console.WriteLine(stringList["Shaki"]);
            Console.WriteLine(stringList["Guba"]);
            Console.WriteLine(stringList["Khacmaz"]);
            Console.WriteLine(stringList["Ganca"]);
        }
    }
}
