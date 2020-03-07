using System.Collections.Generic;
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
      List<char> potentialNewSentence = new List<char> {};
      char[] chars = Sentence.ToCharArray();
      for(int i = 0; i < chars.Length; i++)
      {
        
      for(int j = 0; j < expressionsToIgnore.Length; j++)
      {
        if (!! chars[i].Countains(expressionsToIgnore[j])) 
        {
          
        }
      }
      }
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