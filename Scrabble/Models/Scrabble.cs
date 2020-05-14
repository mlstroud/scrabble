using System.Collections.Generic;

namespace ScrabbleScore.Models
{
  public class Scrabble
  {
    public string Word { get; set; }
    private static Dictionary<char, int> _letterScores = new Dictionary<char, int>
    {
      { 'a', 1 }
    };

    public Scrabble(string word)
    {
      Word = word.ToLower();
    }

    public static int GetLetterScore(char letter)
    {
      return _letterScores[letter];
    }
  }
}