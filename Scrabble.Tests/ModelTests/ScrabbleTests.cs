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

    [TestMethod]
    public void GetLetterScores_ReturnsLetterNScore_LetterNScore()
    {
      char letter = 'n';

      int result = Scrabble.GetLetterScore(letter);

      Assert.AreEqual(result, 1);
    }

    [TestMethod]
    public void GetLetterScores_ReturnsLetterOScore_LetterOScore()
    {
      char letter = 'o';

      int result = Scrabble.GetLetterScore(letter);

      Assert.AreEqual(result, 1);
    }

    [TestMethod]
    public void GetLetterScores_ReturnsLetterPScore_LetterPScore()
    {
      char letter = 'p';

      int result = Scrabble.GetLetterScore(letter);

      Assert.AreEqual(result, 3);
    }

    [TestMethod]
    public void GetLetterScores_ReturnsLetterQScore_LetterQScore()
    {
      char letter = 'q';

      int result = Scrabble.GetLetterScore(letter);

      Assert.AreEqual(result, 10);
    }

    [TestMethod]
    public void GetLetterScores_ReturnsLetterRScore_LetterRScore()
    {
      char letter = 'r';

      int result = Scrabble.GetLetterScore(letter);

      Assert.AreEqual(result, 1);
    }

    [TestMethod]
    public void GetLetterScores_ReturnsLetterSScore_LetterSScore()
    {
      char letter = 's';

      int result = Scrabble.GetLetterScore(letter);

      Assert.AreEqual(result, 1);
    }

    [TestMethod]
    public void GetLetterScores_ReturnsLetterTScore_LetterTScore()
    {
      char letter = 't';

      int result = Scrabble.GetLetterScore(letter);

      Assert.AreEqual(result, 1);
    }

    [TestMethod]
    public void GetLetterScores_ReturnsLetterUScore_LetterUScore()
    {
      char letter = 'u';

      int result = Scrabble.GetLetterScore(letter);

      Assert.AreEqual(result, 1);
    }

    [TestMethod]
    public void GetLetterScores_ReturnsLetterVScore_LetterVScore()
    {
      char letter = 'v';

      int result = Scrabble.GetLetterScore(letter);

      Assert.AreEqual(result, 4);
    }

    [TestMethod]
    public void GetLetterScores_ReturnsLetterWScore_LetterWScore()
    {
      char letter = 'w';

      int result = Scrabble.GetLetterScore(letter);

      Assert.AreEqual(result, 4);
    }

    [TestMethod]
    public void GetLetterScores_ReturnsLetterXScore_LetterXScore()
    {
      char letter = 'x';

      int result = Scrabble.GetLetterScore(letter);

      Assert.AreEqual(result, 8);
    }

    [TestMethod]
    public void GetLetterScores_ReturnsLetterYScore_LetterYScore()
    {
      char letter = 'y';

      int result = Scrabble.GetLetterScore(letter);

      Assert.AreEqual(result, 4);
    }

    [TestMethod]
    public void GetLetterScores_ReturnsLetterZScore_LetterCZcore()
    {
      char letter = 'z';

      int result = Scrabble.GetLetterScore(letter);

      Assert.AreEqual(result, 10);
    }

    [TestMethod]
    public void GetLetterScore_ReturnsZeroIfNotLetter_Zero()
    {
      char letter = '!';

      int result = Scrabble.GetLetterScore(letter);

      Assert.AreEqual(result, 0);
    }

    [TestMethod]
    public void GetWordScore_ReturnsWordScore_WordScore()
    {
      string word = "Hello";
      Scrabble scrabble = new Scrabble(word);

      int result = scrabble.GetWordScore();

      Assert.AreEqual(result, 8);
    }
  }
}