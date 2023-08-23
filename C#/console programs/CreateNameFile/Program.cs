

using System;
using System.IO;

class CreateNameFile
{

    static void Main()
    {
        FileStream file = new FileStream("Names.txt", FileMode.Create, FileAccess.Write);
        StreamWriter writer = new StreamWriter(file);

        string[] names = {"Anthony ",
                          "Belle   ",
                          "Carolyn ",
                          "David   ",
                          "Edwin   ",
                          "Frannie ",
                          "Gina    ",
                          "Hannah  ",
                          "Inaz    ",
                          "Juan    ",};

        for(int x = 0; x < names.Length; x++)
        {
            writer.WriteLine(names[x]);
        }

        writer.Close();
        file.Close();
    }
}