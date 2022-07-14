using System.Collections.Generic;
using System;

namespace ScrabbleNamespace
{
  public class User
  {
    // public List<char> StringSplit(string userInput)
    // {
    //   char[] myArray = userInput.toLower().ToCharArray();
    //   List<char> List = new List<char>(myArray);
    //   return list;

    private string _word;

    public User(string newWord)
    {
      _word = newWord;
    }
    

    public bool IsWord()
    {
      if(this._word != "") 
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
      string testword = _word;
      char[] myArray = testword.ToCharArray();
      
      return myArray; //char[] myArray;
    }
  }
}
    



    // //New constructor code below.
    // public Notsurewhattocallthis(string UserInput)
    // {
    //   _userString = UserString;
    // }

    // public string UserString {get; set;}
    // public char[] UserArray {get; set;}
    // //string mystring = "word";
    // //char[] myArray = mystring.ToCharArray();
    

  // public class ScoreCalc
  // {
  //   string mystring = "word";
  //   char[] myArray = mystring.ToCharArray();
  // }
  
//}


// public class Car
// {
//   public string MakeModel;
//   public int Price;
//   public int Miles;

//   //New constructor code below.
//   public Car(string makeModel, int price, int miles)
//   {
//     MakeModel = makeModel;
//     Price = price;
//     Miles = miles;
//   }

//   public bool WorthBuying(int maxPrice)
//   {
//     return (Price <= maxPrice);
//   }
// }