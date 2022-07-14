using System.Collections.Generic;
using System;

namespace ScrabbleNamespace
{
  public class User
  {
    public string NewWord { get; set; }

    public User(string newWord)
    {
      NewWord = newWord;
    }

    public bool IsWord()
    {
      if(this.NewWord != "") 
      {
        return true;
      }
      else 
      {
        return false;
      }
    }


    public char[] UserInput()
    {
      string testword = NewWord;
      char[] myArray = testword.ToCharArray();
      
      return myArray; //char[] myArray;
    }

    public 
    {
      for(int i = 0; i < NewWord.Length; i++)
      {
        string letter = NewWord.UserInput()[i];
        if(

      }
    }

  }
}


// A, E, I, O, U, L, N, R, S, T       1
// D, G                               2
// B, C, M, P                         3
// F, H, V, W, Y                      4
// K                                  5
// J, X                               8
// Q, Z                               10