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
      { 'j', 8 },
      { 'k', 5 },
      { 'l', 1 },
      { 'm', 3 },
      { 'n', 1 },
      { 'o', 1 },
      { 'p', 3 },
      { 'q', 10 },
      { 'r', 1 },
      { 's', 1 },
      { 't', 1 },
      { 'u', 1 },
      { 'v', 4 },
      { 'w', 4 },
      { 'x', 8 }
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