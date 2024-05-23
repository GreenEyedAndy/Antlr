namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        var filter = UrlFilterToBsonDocument.UrlFilterConverter.ConvertToBson(
            """
            ((name eq Andy or name eq "Igor") and _age gte 0.46) and flag eq true or lastModified lt 2023-07-19T14:35:31.347Z
            """
        );
        Console.WriteLine(filter);
       //Console.ReadLine();
    }
}