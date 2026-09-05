using System;
using System.IO;

namespace DemoPath;

class Program
{
    static void Main(string[] args)
    {
        string path = @"C:\Windows\Temp\Test folder - StreamWriter - C# course\Test1\Text1.txt";

        try
        {
            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());
        }
        catch (IOException e)
        {
            Console.WriteLine("Occurred a error");
            Console.WriteLine(e.Message);
        }
    }
}