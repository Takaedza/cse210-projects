using System;

public class Tasks
{
    // Attributes
    private string _tasksName;
    private int _tasksTime;
    private string _message = "You may begin in...";

    // Constructors
    public Tasks(string tasksName, int tasksTime)
    {
        _tasksName = tasksName;
        _tasksTime = tasksTime;
    }
    public void GetTasksName()
    {
        Console.WriteLine($"Welcome to the {_tasksName} Activity\n");
    }
    public void SetTasksName(string tasksName)
    {
        _tasksName = tasksName;
    }
    public int GetTasksTime()
    {
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        int userSeconds = Int32.Parse(Console.ReadLine());
        _tasksTime = userSeconds;
        return userSeconds;
    }
    public void SetTasksTime(int tasksTime)
    {
        _tasksTime = tasksTime;
    }

    // Methods
    public void GetReady()
    {
        Console.Clear();
        Spinner spinner = new Spinner();
        spinner.Stopwatch();
    }

    public void GetDone()
    {
        Spinner spinner = new Spinner();
        spinner.ShowPercentage();
        Console.WriteLine($"\nYou have completed another {_tasksTime} seconds of the {_tasksName} Activity!");
        spinner.Stopwatch();
    }
    public void CountDown(int time)
    {
        Console.WriteLine();  //insert blank line to start
        for (int i = time; i > 0; i--)
        {
            Console.Write($"{_message}{i}");
            Thread.Sleep(1000);
            string blank = new string('\b', (_message.Length + 5));  // Overwrite line
            Console.Write(blank);
        }
        Console.WriteLine($"Go:                                  ");  // last prompt
    }


}