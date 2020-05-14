using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ScrabbleTests
  {
    [TestMethod]
    public void Scrabble_ConvertsWordToLowerCase_LowerCaseWord()
    {
      string newWord = "Hello";
      Scrabble scrabble = new Scrabble(newWord);

      string result = scrabble.Word;

      Assert.AreEqual(result, newWord.ToLower());
    }

    [TestMethod]
    public void Dictionary_StoresScoresOfLetters_DictionaryOfScores()
    {
      char letter = 'a';

      int result = Scrabble.GetLetterScore(letter);

      Assert.AreEqual(result, 1);
    }

    [TestMethod]
    public void Dictionary_StoresScoresOfLetters_DictionaryOfScores()
    {
      char letter = 'b';

      int result = Scrabble.GetLetterScore(letter);

      Assert.AreEqual(result, 3);
    }
  }
}