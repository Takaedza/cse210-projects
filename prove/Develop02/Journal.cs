using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace Develop02
{
    class Journal
    {
        private string JournalFile = "MyJournal.txt";
        private string TitleArt = @"(\
(\ 
\'\ 
 \'\     __________  
 / '|   ()_________)
 \ '/    \ ~~~~~~~~ \
   \       \ ~~~~~~   \
   ==).      \__________\
  (__)       ()__________)";

        public void Run()
        {
            Title = "Journal ";
                DisplayIntro();
                CreateJournalFile();
                RunMenu();
                     
                DisplayOutro();
        }

        private void RunMenu()
        {
            string choice;
            do
            {
                choice = GetChoice();
                switch (choice)
                {
                    case "1":
                        DisplayJournalContents();
                        break;
                    case "2":
                        ClearFile();
                        break;
                    case "3":
                        AddEntry();
                        break;
                    default:
                        break;
                }
            } while (choice != "4");
            
            
        }

        private string GetChoice()
        {
            bool isChoiceVlid = false;
            string choice = "";

            do
            {
                Clear();
                ForegroundColor = ConsoleColor.DarkGray;
                WriteLine(TitleArt);
                ForegroundColor = ConsoleColor.Black;
                WriteLine("\nWhat would you like to do? ");
                WriteLine(" > 1 - Read the journal.");
                WriteLine(" > 2 - Clear the journal.");
                WriteLine(" > 3 - Add t the journal.");
                WriteLine(" > 4 -  Exit.");

                ForegroundColor = ConsoleColor.DarkCyan;
                choice = ReadLine().Trim();
                ForegroundColor = ConsoleColor.Black;

                if (choice == "1" || choice == "2" || choice == "3" || choice == "4")
                {
                    isChoiceVlid = true;
                }

                else
                {
                    ForegroundColor = ConsoleColor.DarkRed;
                    WriteLine($"\"{choice}\" is not a valid option. Please choose 1-4");
                    WaitForKey();
                }

            } while(!isChoiceVlid);

            
            return choice;
        }

        private void CreateJournalFile()
            {
               WriteLine($"Does file exist? {File.Exists("MyJournal.txt")}");
               if (File.Exists("MyJournal.txt"))
               {
                File.CreateText("MyJournal.txt");
               }

            }

        private void DisplayIntro() 
        {
            ForegroundColor = ConsoleColor.Black;
            BackgroundColor = ConsoleColor.White;
            Clear();
            WriteLine(TitleArt);
            WriteLine ("\nWelcome to the only journal");
            WaitForKey();
        }

        private void DisplayOutro() 
        {
            WriteLine("\nArt from: https://www.asciiart.eu/books/books");
            WriteLine ("\nThank you for adding an Entry");
            WaitForKey();
        }

        private void WaitForKey()
        {
            ForegroundColor = ConsoleColor.DarkGray;
            WriteLine("\nPress any key...");
            ReadKey(true);
        }

        private void DisplayJournalContents() 
        {
            string journalText = File.ReadAllText(JournalFile);
            WriteLine("\n*** Journal ***");
            WriteLine(journalText);
            WriteLine("*******************************************************");
            WaitForKey();
        }

        private void ClearFile() 
        {
            ForegroundColor = ConsoleColor.Black;
            File.WriteAllText(JournalFile, "");
            WriteLine("\nJournal Cleared!");
            WaitForKey();
        }

        private void AddEntry() 
        {
            ForegroundColor = ConsoleColor.Black;
            
            Wordprompt myQuestion = new Wordprompt();
            myQuestion.Run();
            //WriteLine(myQuestion);
            //WriteLine("\nWhat would you like to add: ");
            ForegroundColor = ConsoleColor.DarkBlue;
            string newLine = ReadLine();
            File.AppendAllText(JournalFile, $"\nEntry:\n> {newLine}\n");
            ForegroundColor = ConsoleColor.Black;
            WriteLine( "The journal has been modified!");
            WaitForKey();
        }
        
    }
}