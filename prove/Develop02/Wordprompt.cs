using System;

namespace Develop02
{
class Wordprompt
{
public void Run()
{
// A array of questions
string[] questions = {
    "What was the highlight of your day?",
    "What were you doing today?",
    "Did you achieve any accomplishment?",
    "Who did you meet who was interesting?",
    "Where did you go?",
    "What new thing did you learn today?"
    };

// Create a Random object
Random rand = new Random();
// Generate a random index less than the size of the array.
int index = rand.Next(questions.Length);
// Display the result.
Console.WriteLine($"{questions[index]}");

Console.ReadKey();
}
}
}