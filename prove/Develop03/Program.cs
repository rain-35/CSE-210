// CSE 210
// Created by Rainen Morriss
// Started 5/26/2026
// sources 
//    class material
//    google
//    AI
//    stackoverflow




using System;

class Program
{
    static void Main(string[] args)
    {

        Scripture rmScripture = new Scripture();

        string rmScriptureReference = "John 3:16-17";
        string rmScriptureText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life. 17 For God sent not his Son into the world to condemn the world; but that the world through him might be saved.";

        rmScripture.RmConstructor(rmScriptureText, rmScriptureReference);


        Console.WriteLine("Scripture Memorizer!");











        
    }
}

