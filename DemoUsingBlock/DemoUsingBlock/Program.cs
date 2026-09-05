namespace DemoUsingBlock;

class Program
{
    static void Main(string[] args)
    {
        string path = @"C:\Windows\Temp\DemoFileInfo - Using FileStream and StreamReader - C# course.txt";

        try
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
            {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("Occurred a error");
            Console.WriteLine(e.Message);
        }
    }
}