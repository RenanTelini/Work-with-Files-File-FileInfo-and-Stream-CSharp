namespace DemoFileInfo;

class Program
{
    static void Main(string[] args)
    {
        string sourcePath = @"C:\Windows\Temp\DemoFileInfo - Using functions from FileInfo class - C# course.txt";
        string targetPath = @"C:\Windows\Temp\DemoFileInfo - Using functions from FileInfo class - C# course.txt - 2";

        try
        {
            FileInfo fileInfo = new FileInfo(sourcePath);
            fileInfo.CopyTo(targetPath);
            string[] lines = File.ReadAllLines(sourcePath);
            foreach(string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        catch(IOException e)
        {
            Console.WriteLine("Occurred a error");
            Console.WriteLine(e.Message);
        }
    }
}