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
}