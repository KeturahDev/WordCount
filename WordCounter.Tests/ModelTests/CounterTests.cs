using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class CounterTests 
  {
    [TestMethod]
    public void InstantiateCounter_InstanceOfCounterIsCreated_Counter()
    {
      string keyWord = "orange";
      string sentence = "orange you glad I made a constructor test?";
      Input newInput = new Input(keyWord, sentence);

      Counter newCounter = new Counter(newInput);

      Assert.AreEqual(newInput.Key, newCounter.KeyWord);
    }
    [TestMethod]
    public void GenerateArray_TurnSentenceIntoArray_StringArray()
    {
      string lyrics = "If I were a rich man";
      string usersKeyWord = "rich";
      Input userInputs = new Input( usersKeyWord, lyrics);
      Counter newCounter = new Counter(userInputs);
      string[] comparison = {"If", "I", "were", "a", "rich", "man"};
      string[] result = newCounter.GenerateArray();

      CollectionAssert.AreEqual(comparison, result);
    }
    [TestMethod]
    public void Counting_CountsOccurancesOfKeyInSentence_int()
    {
      string usersSentence = "If I were a rich man la la la la la la la la la la la";
      string usersKeyWord = "la";
      Input newInput = new Input(usersKeyWord, usersSentence);
      Counter newCounter = new Counter(newInput);
      string[] list = newCounter.GenerateArray();
      newCounter.Counting(list);

      int numberOfOccurences = newCounter.Count;

      Assert.AreEqual(11, numberOfOccurences);
    }
    [TestMethod]
    public void ExpressionsIgnored_ExpressionsAreCutBeforeListIsCreated_string()
    {
      string usersSentence = "If I were a rich man, la la la la la la, la la la la la la la, la la!";
      string usersKeyWord = "la";
      Input newInput = new Input(usersKeyWord, usersSentence);
      Counter newCounter = new Counter(newInput);
      newCounter.IgnoreExpressions();
      string[] list = newCounter.GenerateArray();
      newCounter.Counting(list);

      int numberOfOccurences = newCounter.Count;

      Assert.AreEqual(15, numberOfOccurences);
    }
  }
}