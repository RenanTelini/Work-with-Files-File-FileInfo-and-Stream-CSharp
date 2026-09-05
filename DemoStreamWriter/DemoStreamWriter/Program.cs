namespace DemoStreamWriter;

class Program
{
    static void Main(string[] args)
    {
        string sourcePath = @"C:\Windows\Temp\DemoFileInfo - Using StreamWriter - C# course.txt";
        string targetPath = @"C:\Windows\Temp\DemoFileInfo - Using StreamWriter - C# course - 2.txt";

        try
        {
            string[] lines = File.ReadAllLines(sourcePath);

            using (StreamWriter sw = File.AppendText(targetPath))
            {
                foreach(string line in lines)
                {
                    sw.WriteLine(line.ToUpper());
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