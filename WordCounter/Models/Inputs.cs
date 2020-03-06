namespace WordCounter.Models
{
  public class Word
  {
    public string Key { get;set; }
    public Word(string keyword)
    {
      Key = keyword;
    }

  }
}