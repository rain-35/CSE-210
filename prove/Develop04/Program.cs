using System;

class Program
{
    static void Main(string[] args)
    {

        Breathing b1 = new Breathing();

        b1.DisplayStartingMessage();
        b1.BreathInOut();
        b1.DisplayEndingMessage();
        
    }
}