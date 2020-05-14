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
    public void GetLetterScores_ReturnsLetterAScore_LetterAScore()
    {
      char letter = 'a';

      int result = Scrabble.GetLetterScore(letter);

      Assert.AreEqual(result, 1);
    }

    [TestMethod]
    public void GetLetterScores_ReturnsLetterBScore_LetterBScore()
    {
      char letter = 'b';

      int result = Scrabble.GetLetterScore(letter);

      Assert.AreEqual(result, 3);
    }

    [TestMethod]
    public void GetLetterScores_ReturnsLetterCScore_LetterCScore()
    {
      char letter = 'c';

      int result = Scrabble.GetLetterScore(letter);

      Assert.AreEqual(result, 3);
    }

    [TestMethod]
    public void GetLetterScores_ReturnsLetterDScore_LetterDScore()
    {
      char letter = 'd';

      int result = Scrabble.GetLetterScore(letter);

      Assert.AreEqual(result, 2);
    }

    [TestMethod]
    public void GetLetterScores_ReturnsLetterEScore_LetterEScore()
    {
      char letter = 'e';

      int result = Scrabble.GetLetterScore(letter);

      Assert.AreEqual(result, 1);
    }

    [TestMethod]
    public void GetLetterScores_ReturnsLetterFScore_LetterFScore()
    {
      char letter = 'f';

      int result = Scrabble.GetLetterScore(letter);

      Assert.AreEqual(result, 4);
    }

    [TestMethod]
    public void GetLetterScores_ReturnsLetterGScore_LetterGScore()
    {
      char letter = 'g';

      int result = Scrabble.GetLetterScore(letter);

      Assert.AreEqual(result, 2);
    }

    [TestMethod]
    public void GetLetterScores_ReturnsLetterHScore_LetterHScore()
    {
      char letter = 'h';

      int result = Scrabble.GetLetterScore(letter);

      Assert.AreEqual(result, 4);
    }

    [TestMethod]
    public void GetLetterScores_ReturnsLetterIScore_LetterIScore()
    {
      char letter = 'i';

      int result = Scrabble.GetLetterScore(letter);

      Assert.AreEqual(result, 1);
    }

    [TestMethod]
    public void GetLetterScores_ReturnsLetterJScore_LetterJScore()
    {
      char letter = 'j';

      int result = Scrabble.GetLetterScore(letter);

      Assert.AreEqual(result, 8);
    }

    [TestMethod]
    public void GetLetterScores_ReturnsLetterKScore_LetterKScore()
    {
      char letter = 'k';

      int result = Scrabble.GetLetterScore(letter);

      Assert.AreEqual(result, 5);
    }

    [TestMethod]
    public void GetLetterScores_ReturnsLetterLScore_LetterLScore()
    {
      char letter = 'l';

      int result = Scrabble.GetLetterScore(letter);

      Assert.AreEqual(result, 1);
    }

    [TestMethod]
    public void GetLetterScores_ReturnsLetterMScore_LetterMScore()
    {
      char letter = 'm';

      int result = Scrabble.GetLetterScore(letter);

      Assert.AreEqual(result, 3);
    }
  }
}