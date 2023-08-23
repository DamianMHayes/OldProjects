
using static System.Console;
using System.IO;
class fileTest {
    static void Main(string[] args) {
        Console.WriteLine("Hello, World!");
        
        if (File.Exists("Program.cs"))
        {
            Console.WriteLine("File exists");
        }
        else
        {
            Console.WriteLine("File not found");
        }
    }
}




