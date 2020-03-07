namespace WordCounter.Models
{
  public class Input
  {
    public string Key { get;set; }
    public string Value {set;get;}
    public Input(string keyword, string value)
    {
      Key = keyword;
      Value = value;
    }
  }
}