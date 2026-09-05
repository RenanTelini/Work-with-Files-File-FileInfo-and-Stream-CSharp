namespace DemoFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Windows\Temp\DemoFile - Using static members from File - C# course.txt";
            string targetPath = @"C:\Windows\Temp\DemoFile - Using static members from File - C# course - 2.txt";

            try
            {
                File.Copy(sourcePath, targetPath);
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
}