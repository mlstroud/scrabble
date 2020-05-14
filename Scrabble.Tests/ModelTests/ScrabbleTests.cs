using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ScrabbleTests
  {
    [TestMethod]
    public void Scrabble_TakesWordAsInput_Word()
    {
      string newWord = "Hello";
      Scrabble scrabble = new Scrabble(newWord);

      string result = scrabble.Word;

      Assert.AreEqual(result, newWord);
    }
  }
}