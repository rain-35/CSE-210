using System;

class Program
{
    static void Main(string[] args)
    {
        string filename = "prepare_copy/write_joke_to_file/myFile.txt";

        string joke1 = "I heard they are making land mines disguised as prayer mats";
        string joke2 = "Prophets are going through the roof";

        WriteJoke(filename, joke1, joke2);
        ReadJoke(filename);

        
    }

    static void WriteJoke(string filename, string joke1, string joke2)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            
            outputFile.WriteLine(joke1);
        
            outputFile.WriteLine(joke2);
        }
        
    }

    static void ReadJoke(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
        
    }
}