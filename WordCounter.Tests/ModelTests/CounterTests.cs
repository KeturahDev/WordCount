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
      string usersSentence = "If I were a rich man";
      string usersKeyWord = "rich";
      Word userWord = new Word(usersKeyWord);
      Sentence lyrics = new Sentence(usersSentence);
      Counter newCounter = new Counter(userWord, lyrics);

      string[] list = newCounter.GenerateArray();

      Assert.AreEqual("If",list[0]);
    }
  }
}