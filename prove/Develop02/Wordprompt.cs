using System;

public class Prompts
{

    // A array of questions
    public static string[] questions = {
        "What was the highlight of your day?",
        "What were you doing today?",
        "Did you achieve any accomplishment?",
        "Who did you meet who was interesting?",
        "Where did you go?",
        "What new thing did you learn today?"
    };

    public List<string>_Questions = new List<string>(questions);

    public Prompts()
    {

    }

    public void Display()
    {
        var random = new Random();
        int i = random.Next(_Questions.Count);
        string Questions = _Questions[i];
        Console.WriteLine($"\n{_Questions}");
    }

    public string GetQuestion()
    {
        var random = new Random();
        int i = random.Next(_Questions.Count);
        string Questions = _Questions[i];

        return Questions;
    }
}
