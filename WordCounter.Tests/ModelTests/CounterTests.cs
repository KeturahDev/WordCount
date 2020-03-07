using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class CounterTests 
  {
    [TestMethod]
    public void GenerateArray_TurnSentenceIntoList_ArrayOfWords()
    {
      string lyrics = "If I were a rich man";
      string usersKeyWord = "rich";
      Input userInputs = new Input( usersKeyWord, lyrics);
      Counter newCounter = new Counter(userInputs);

      string[] list = newCounter.GenerateArray();

      Assert.AreEqual("If",list[0]);
    }
    [TestMethod]
    public void CountingWord_CountsOccurancesOfKeyInSentence_int()
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
  }
}