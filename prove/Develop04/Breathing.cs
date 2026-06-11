public class Breathing : Activity
{
    public Breathing() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {}


    public void BreathInOut()
    {
        {
            Console.Clear();
            Console.Write("\nBreathe in...  ");
            ShowSpinner(4);
            Console.Clear();
            Console.Write("\nHold");
            ShowSpinner(7);
            Console.Clear();
            Console.Write("\nBreathe out...  ");
            ShowSpinner(8);
        }

    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_rm_duration);
        while (DateTime.Now < endTime)
        {
            BreathInOut();
        }
        DisplayEndingMessage();

    }



}