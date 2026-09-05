namespace DemoStreamReader;

class Program
{
    static void Main(string[] args)
    {
        string path = @"C:\Windows\Temp\DemoFileInfo - Using FileStream and StreamReader - C# course.txt";
        StreamReader sr = null;

        try
        {
            sr = File.OpenText(path);
            
            while(!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("Occurred a error");
            Console.WriteLine(e.Message);
        }
        finally
        {
            sr?.Close();
        }
    }
}