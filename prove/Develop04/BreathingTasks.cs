using System;

public class BreathingTasks : Tasks
{
    // Attributes 
    private string _firstMessage = "Breathe in...";
    private string _secondMessage = "Breathe out...";
    private string _tasksDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    // Constructors
    // Methods
    public BreathingTasks(string tasksName, int tasksTime) : base(tasksName, tasksTime)
    {

    }
    public void GetTasksDescription()
    {
        Console.WriteLine(_tasksDescription);
    }

    public void Breathing(int seconds)
    {
        Console.WriteLine();  //insert blank line to start
        int secondsTimer = 0;
        while (secondsTimer < seconds)
        {
            Console.WriteLine();  //insert blank line to start
            for (int i = 4; i > 0; i--)
            {
                Console.Write($"{_firstMessage}{i}");
                Thread.Sleep(1000);
                string blank = new string('\b', (_firstMessage.Length + 2));  // Overwrite line
                Console.Write(blank);
                secondsTimer += 1;
            }
            Console.WriteLine($"{_firstMessage}  ");  // last prompt
            for (int i = 5; i > 0; i--)
            {
                Console.Write($"{_secondMessage}{i}");
                Thread.Sleep(1000);
                string blank = new string('\b', (_secondMessage.Length + 2));  // Overwrite line
                Console.Write(blank);
                secondsTimer += 1;
            }
            Console.WriteLine($"{_secondMessage}  ");  // last prompt
        }
    }
}







