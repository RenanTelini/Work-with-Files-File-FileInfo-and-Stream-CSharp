namespace DemoStreamWriter;

class Program
{
    static void Main(string[] args)
    {
        string path = @"C:\Windows\Temp\Test folder - StreamWriter - C# course";

        try
        {
            //IEnumerable<string> folders = Directory.EnumerateDirectories(path);
            var folders = Directory.EnumerateDirectories(path);
            Console.WriteLine("FOLDERS:");
            foreach(string s in folders)
            {
                Console.WriteLine(s);
            }

            //IEnumerable<string> files = Directory.EnumerateFiles(path);
            var files = Directory.EnumerateFiles(path);
            Console.WriteLine("FILES:");
            foreach(string s in files)
            {
                Console.WriteLine(s);
            }

            Directory.CreateDirectory(path + @"\newfolder");
        }
        catch (IOException e)
        {
            Console.WriteLine("Occurred a error");
            Console.WriteLine(e.Message);
        }
    }
}