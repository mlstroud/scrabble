using System;
using ScrabbleScore.Models;

namespace ScrabbleScore
{
  public class Program
  {
    public static void Main()
    {
      string userInput = "";

      while (userInput != "...")
      {
        Console.WriteLine("Enter a word to have it scored, or enter \"...\" to quit");
        userInput = Console.ReadLine();
        if (userInput != "...")
        {
          Scrabble word = new Scrabble(userInput);
          Console.WriteLine("The score for " + userInput + " is " + word.GetWordScore() + ".");
        }
        else
        {
          Console.WriteLine("Goodbye.");
        }
      }
    }
  }
}