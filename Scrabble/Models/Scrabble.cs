using System.Collections.Generic;

namespace ScrabbleScore.Models
{
  public class Scrabble
  {
    public string Word { get; set; }
    private static Dictionary<char, int> _letterScores = new Dictionary<char, int>
    {
      { 'a', 1 },
      { 'b', 3 },
      { 'c', 3 },
      { 'd', 2 },
      { 'e', 1 },
      { 'f', 4 },
      { 'g', 2 },
      { 'h', 4 },
      { 'i', 1 },
      { 'j', 8 }
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