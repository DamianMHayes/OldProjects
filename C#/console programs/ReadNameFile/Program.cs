

using static System.Console;
using System.IO;

class ReadNameFile
{
    static void Main()
    {
        FileStream file = new FileStream("Names.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(file);
        int count = 1;
        string name;

        WriteLine("Displaying all names");
        name = reader.ReadLine();
        while(name != null)
        {
            WriteLine("" + count + " " + name);
            name = reader.ReadLine();
            count++;
        }
        reader.Close();
        file.Close();
    }
}