// CSE 210
// Created by Rainen Morriss
// Started 5/26/2026
// sources 
//    class material
//    google
//    AI
//    stackoverflow
// Above and beyond
// I improved the code by adding the constraint of not being able to hide the same word twice




using System;

class Program
{
    static void Main(string[] args)
    {

        Scripture rmScripture = new Scripture();

        string rmScriptureReference = "John 3:16-17";
        string rmScriptureText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life. \n17 For God sent not his Son into the world to condemn the world; but that the world through him might be saved.";

        rmScripture.RmConstructor(rmScriptureText, rmScriptureReference);

        Console.WriteLine("Scripture Memorizer!");

        string input = "";

        while (input != "quit")
        {
            
            Console.WriteLine(rmScripture.RmToString());
            Console.WriteLine("Press enter to continue or type 'quit' to exit.");
            input = Console.ReadLine();
            if (input == "quit")
            {
                break;
            }
            bool finished = rmScripture.RmHideWord(3);
            if (finished == true)
            {
                Console.Clear();
                Console.WriteLine(rmScripture.RmToString());
                Console.WriteLine("");
                Console.WriteLine("All words have been hidden.");
                Console.WriteLine("Well done!");
                Console.WriteLine("The program will now exit.");
                break;
            }
            Console.Clear();
        }




        
    }
}

