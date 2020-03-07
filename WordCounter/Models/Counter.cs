using System.Collections.Generic;
using System; 
namespace WordCounter.Models
{
  public class Counter
  {
    public string KeyWord {get;set;}
    public string Sentence {get;set;}
    public int Count {get;set;}
    public Counter(Input input)
    {
      KeyWord = input.Key;
      Sentence = input.Value;
      Count = 0;
    }
    public void IgnoreExpressions()
    {
      List<char> expressionsToIgnore = new List<char> {'!','?','.',',','/','-',':',';'};
      List<string> potentialNewSentence = new List<string> {};
      char[] chars = Sentence.ToCharArray();
      for(int i = 0; i < chars.Length; i++)
      {
        bool condition = true;
        for(int j = 0; j < expressionsToIgnore.Count; j++)
        {
          if (expressionsToIgnore.Contains(chars[i])) 
          // if (!chars[i].Countains(expressionsToIgnore[j])) 
          {
            condition = false;
          }
        }
        if (condition)
        {
          // string currentChar = Char.ToString(chars[i]);
          string currentChar = "bull";
          // Console.Write($"{GetType(currentChar)}");
          potentialNewSentence.Add(currentChar);
        }
      }
      string newSentence = new String(potentialNewSentence);
      Sentence = newSentence;
    }
    public string[] GenerateArray()
    {
      string[] stringArray = Sentence.Split(" ");
      return stringArray;
    }
    public void Counting(string[] listOfWords)
    {
      foreach (string word in listOfWords)
      {
        if(word == KeyWord)
        {
          Count = Count += 1;
        }
      }
    }
  }
}