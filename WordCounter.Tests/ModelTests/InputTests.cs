using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Test 
{
  [TestClass]
  public class InputTests
  {
    [TestMethod]
    public void InputClassConstructor_InstanceOfInputHasKeyProperty_String()
    {
      string key = "lemon";
      Input newInput = new Input(key);

      string result = newInput.Key;

      Assert.AreEqual(key, result);
    }    
    [TestMethod]
    public void InputClassOverLoadedConstructor_InstanceOfInputHasValueProperty_String()
    {
      string userWord = "turtles";
      string userSentence = "I like turtles";
      Input newInput = new Input(userWord, userSentence);

      string result = newInput.Value;

      Assert.AreEqual(userSentence, result); 
    }
  }
}