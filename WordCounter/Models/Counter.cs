namespace WordCounter.Models
{
  public class Counter
  {
    public string CheckFor {get;set;}
    public string Sentence {get;set;}
    public int Count {get;set;}
    public Counter(Word word, Sentence sentence)
    {
      CheckFor = word.Key;
      Sentence = sentence.Value;
      Count = 0;
    }

    public string[] GenerateArray()
    {
      string[] stringArray = Sentence.Split(" ");
      return stringArray;
    }
    public void Counting(string[] listOfWords)
    {
      Count = Count += 0;
    }
  }
}