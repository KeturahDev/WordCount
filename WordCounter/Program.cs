using System;
using WordCounter.Models;

namespace WordCounter
{
  public class Program
  {
    static void Main()
    {
      Welcome();
      Start();
    }
    public static void Welcome()
    {
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine(@"██╗    ██╗ ██████╗ ██████╗ ██████╗  ██████╗ ██████╗ ██╗   ██╗███╗   ██╗████████╗███████╗██████╗ 
██║    ██║██╔═══██╗██╔══██╗██╔══██╗██╔════╝██╔═══██╗██║   ██║████╗  ██║╚══██╔══╝██╔════╝██╔══██╗
██║ █╗ ██║██║   ██║██████╔╝██║  ██║██║     ██║   ██║██║   ██║██╔██╗ ██║   ██║   █████╗  ██████╔╝
██║███╗██║██║   ██║██╔══██╗██║  ██║██║     ██║   ██║██║   ██║██║╚██╗██║   ██║   ██╔══╝  ██╔══██╗
╚███╔███╔╝╚██████╔╝██║  ██║██████╔╝╚██████╗╚██████╔╝╚██████╔╝██║ ╚████║   ██║   ███████╗██║  ██║
 ╚══╝╚══╝  ╚═════╝ ╚═╝  ╚═╝╚═════╝  ╚═════╝ ╚═════╝  ╚═════╝ ╚═╝  ╚═══╝   ╚═╝   ╚══════╝╚═╝  ╚═╝");
      Console.ForegroundColor = ConsoleColor.DarkBlue;
      Console.WriteLine("Where you can enter a sentence, a word you want to count, and we'll count it for you!");
    }
    public static void Start()
    {
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("================================================================================================");
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine("Wound you like to go enter word or exit the application");
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.Write("Continue [C]     Exit [E]    ");
      Console.ForegroundColor = ConsoleColor.Green;
      string response = Console.ReadLine().ToLower();

      if(response == "c")
      {
        CountWord();
      }
      else if (response == "e")
      {
        Console.WriteLine("Goodbye!");
      }
      else
      {
        Start();
      }
    }
    public static void CountWord()
    {
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.Write("Please enter the word to check for:   ");
      Console.ForegroundColor = ConsoleColor.Green;
      string usersWord = Console.ReadLine();
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.Write("Please enter the sentence to check:   ");
      Console.ForegroundColor = ConsoleColor.Green;
      string usersSentence = Console.ReadLine().ToLower();
      Input userInputs = new Input(usersWord ,usersSentence);
      Counter newCounter = new Counter(userInputs);
      newCounter.IgnoreExpressions();
      // Console.WriteLine($">>>>   SENTENCE AFTER IEMETHOD:{newCounter.Sentence}");
      string[] list = newCounter.GenerateArray();
      newCounter.Counting(list);

      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.WriteLine($"Your word {userInputs.Key} is in that sentence {newCounter.Count} times");
      Start();
    }
  }
}