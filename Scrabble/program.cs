using System;
using System.Collections.Generic; //using list?
using System.Linq; 
using ScrabbleNamespace;

namespace ScrabbleNamespace
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the Scrabble Point Calculator!");
      Console.WriteLine("Please enter a word:");
      string newWord = Console.ReadLine();
      User user = new User(newWord);
      // user.UserInput();
      //Console.WriteLine("Your Score " + //calculation name());
      //Console.WriteLine("Do you want to score another word?");
      //Main();
    }
  }
}