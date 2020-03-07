using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Test 
{
  [TestClass]
  public class InputTests
  {
    [TestMethod]
    public void WordKeyInstantiated_InstanceOfWordCreatesKey_String()
    {
      string key = "lemon";
      Input newInput = new Input(key);

      string result = newInput.Key;

      Assert.AreEqual(key, result);
    }    
    [TestMethod]
    public void SentenceCollected_InstanceOfSentenceAttainsSentance_String()
    {
      string userWord = "turtles";
      string userSentence = "I like turtles";
      Input newInput = new Input(userWord, userSentence);

      string result = newInput.Value;

      Assert.AreEqual(userSentence, result); 
    }
  }
}