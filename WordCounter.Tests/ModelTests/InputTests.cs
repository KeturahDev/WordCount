using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Test 
{
  [TestClass]
  public class WordTests
  {
    [TestMethod]
    public void WordKeyInstantiated_InstanceOfWordCreatesKey_String()
    {
      string key = "lemon";
      Word newWord = new Word(key);

      string result = newWord.Key;

      Assert.AreEqual(key, result);
    }    
  }
  [TestClass]
  public class SentenceTests
  {
    [TestMethod]
    public void SentenceCollected_InstanceOfSentenceAttainsSentance_String()
    {
      string userSentence = "I like turtles";
      Sentence newSentence = new Sentence(userSentence);

      string result = newSentence.Value;

      Assert.AreEqual(userSentence, result); 
    }
  }
}