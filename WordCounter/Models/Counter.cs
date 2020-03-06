namespace WordCounter.Models
{
  public class Counter
  {
    public string KeyWord {get;set;}
    public string Sentence {get;set;}
    public int Count {get;set;}
    public Counter(Word word, Sentence sentence)
    {
      KeyWord = word.Key;
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