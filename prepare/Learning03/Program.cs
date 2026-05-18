using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction rmFraction1 = new Fraction();
        rmFraction1.FractionInit();
        Console.WriteLine(rmFraction1.GetFractionString());

        Fraction rmFraction2 = new Fraction();
        rmFraction2.FractionOverOne(6);
        Console.WriteLine(rmFraction2.GetFractionString());

        Fraction rmFraction3 = new Fraction();
        rmFraction3.FractionFull(6, 7);
        Console.WriteLine(rmFraction3.GetFractionString());

        Fraction rmFraction4 = new Fraction();
        rmFraction4.SetTop(3);
        rmFraction4.SetBottom(4);
        Console.WriteLine(rmFraction4.GetFractionString());
        Console.WriteLine(rmFraction4.GetDecimalValue());

        // Random
        Fraction rmFractionRandom = new Fraction();
        for (int i = 0; i < 20; i++)
        {
            int rmTopNumber = new Random().Next(1, 100);
            int rmBottomNumber = new Random().Next(1, 100);
            rmFractionRandom.SetTop(rmTopNumber);
            rmFractionRandom.SetBottom(rmBottomNumber);
            
            Console.WriteLine($"Fraction {i + 1}: string: {rmFractionRandom.GetFractionString()} decimal: {rmFractionRandom.GetDecimalValue()}");

        }
        
    }
}