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
      Console.WriteLine("WordCounter");
      Console.WriteLine("Where you can enter a sentence, a word you want to count, and we'll count it for you!");
    }
    public static void Start()
    {
      Console.WriteLine("Wound you like to go enter word or exit the application");
      Console.Write("Continue [C]     Exit [E]    ");
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
      Console.Write("Please enter the word to check for:   ");
      string usersWord = Console.ReadLine();
      Console.Write("Please enter the sentence to check:   ");
      string usersSentence = Console.ReadLine();
      Input userInputs = new Input(usersWord ,usersSentence);
      Counter newCounter = new Counter(userInputs);

      string[] list = newCounter.GenerateArray();
      newCounter.Counting(list);

      Console.WriteLine($"Your word {userInputs.Key} is in that sentence {newCounter.Count} times");
      Start();
    }
  }
}