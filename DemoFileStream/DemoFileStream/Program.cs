namespace DemoFileStream;

class Program
{
    static void Main(string[] args)
    {
        string path = @"C:\Windows\Temp\DemoFileInfo - Using FileStream and StreamReader - C# course.txt";
        FileStream fs = null;
        StreamReader sr = null;

        try
        {
            fs = new FileStream(path, FileMode.Open); //File.OpenRead(path);
            sr = new StreamReader(fs);
            string line = sr.ReadLine();
            Console.WriteLine(line);
        }
        catch (IOException e)
        {
            Console.WriteLine("Occurred a error");
            Console.WriteLine(e.Message);
        }
        finally
        {
            if (sr != null) sr.Close();
            if (fs != null) fs.Close();
        }
    }
}