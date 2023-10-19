using System;

public class JournalCapture
{
    public string _captureNo = "";

    public string _dateTime = "";

    public string _Questions = "";

    public string _journalCapture = "";

    public string _journalFile = "";


    public JournalCapture()
    {
    }

    public void Display()
    {
        Console.WriteLine($"\n#{_captureNo}");
        Console.WriteLine($"Date:{_captureNo}");
        Console.WriteLine($"Prompt:{_Questions}");
        Console.WriteLine($"Capture{_journalCapture}");
    }
}