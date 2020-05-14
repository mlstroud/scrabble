
namespace ScrabbleScore.Models
{
  public class Scrabble
  {
    public string Word { get; set; }

    public Scrabble(string word)
    {
      Word = word;
    }
  }
}