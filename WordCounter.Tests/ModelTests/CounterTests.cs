using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class CounterTests 
  {
    [TestMethod]
    public void GenerateList_TurnSentenceIntoList_ListOfWords()
    {
      string usersSentence = "If I were a rich man";
      string usersKeyWord = "rich";
      Word userWord = new Word(usersKeyWord);
      Sentence lyrics = new Sentence(usersSentence);
      Counter newCounter = new Counter(userWord, lyrics);

      List<string> list = newCounter.GenerateList();

      Assert.AreEqual("If",list[0]);
    }
  }
}