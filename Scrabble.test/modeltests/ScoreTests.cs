using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using ScrabbleNamespace;

namespace Scrabble.Tests
{
  [TestClass]
  public class PlayerTests
  {
    [TestMethod]
    public void IsWord_ReturnsInputWordToString_True()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      string test = "test";
      User newWord = new User(test);
      Assert.AreEqual(true, newWord.IsWord());
    }

    [TestMethod]
    public void UserWordConverter_StringToChar_Char()
    {
      //Arrange
      string mystring = "word";
      char[] testArray = {'w', 'o', 'r', 'd'};
      //Act
      User user = new User(mystring);
      //Assert
      for(int i = 0; i < mystring.Length; i++)
      {
        Assert.AreEqual(testArray[i], user.UserInput()[i]);
      }
    }
  }
}
