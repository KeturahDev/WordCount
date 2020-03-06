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
  public class Sentence
  {
    public string Value {set;get;}
    public Sentence(string value)
    {
      Value = value;
    }
  }
}