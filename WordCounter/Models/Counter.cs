namespace WordCounter.Models
{
  public class Counter
  {
    public string CheckFor {get;set;}
    public string Sentence {get;set;}
    public Counter(Word word, Sentence sentence)
    {
      CheckFor = word.Key;
      Sentence = sentence.Value;
    }

    public string[] GenerateArray()
    {
      string[] stringArray = Sentence.Split(" ");
      return stringArray;
    }
  }
}