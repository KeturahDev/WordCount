using System.Collections.Generic;
namespace WordCounter.Models
{
  public class Counter
  {
    public List<string> listOfWords = new List<string> {"fail"};
    public string CheckFor {get;set;}
    public string Checking {get;set;}
    public Counter(Word word, Sentence sentence)
    {
      CheckFor = word.Key;
      Checking = sentence.Value;
    }

    public List<string> GenerateList()
    {
      return listOfWords;
    }
  }
}