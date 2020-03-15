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
        //constructing the condition for every individual char
        bool condition = true;
        for(int j = 0; j < expressionsToIgnore.Count; j++)
        {
          // if any of the characters are an expression, condition is false
          if (expressionsToIgnore.Contains(chars[i])) 
          {
            condition = false;
          }
        }
        //the condition
        if (condition)
        {
          string currentChar = Char.ToString(chars[i]);
          potentialNewSentence.Add(currentChar);
        }
      }
      //turn new list into a singular string
      string newSentence = String.Join("", potentialNewSentence.ToArray());
      //Sentence is now equal to that string
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