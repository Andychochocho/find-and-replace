using System.Collections.Generic;
using System;

namespace FindReplaceProject.Objects
{
  public class FindAndReplace
  {
    private string _longString;
    private string _firstString;
    private string _secondString;

    public FindAndReplace(string longString, string firstString, string secondString)
    {
      _longString = longString;
      _firstString = firstString;
      _secondString = secondString;
    }

    public string GetLongString()
    {
      return _longString;
    }

    public string GetFirstString()
    {
      return _firstString;
    }
    public string GetSecondString()
    {
      return _secondString;
    }
    public string Replace()
    {
      string[] specialCharacter = {"!","@","#","$","%","^","&","*","_","-","+","=", " ", "."};
      string output = "";
      string longString = this.GetLongString();
      string firstString = this.GetFirstString();
      string secondString = this.GetSecondString();
      int firstStringLength = firstString.Length;
      string dummyFirst = "";
      string dummySecond = "";

      if (longString.IndexOf(firstString) == 0)
      {
        longString = secondString + longString.Remove(0, firstStringLength);
      }
      if(longString.LastIndexOf(firstString) == (longString.Length - firstStringLength))
      {
        int longStringLength = longString.Length;
        longString = longString.Remove(longStringLength - firstStringLength) + secondString;
      }
      for (int i = 0; i<specialCharacter.Length; i++)
      {
        for (int j = 0; j<specialCharacter.Length; j++)
        {
          dummyFirst = specialCharacter[i] + firstString + specialCharacter[j];
          dummySecond = specialCharacter[i] + secondString + specialCharacter[j];
          longString = longString.Replace(dummyFirst, dummySecond);
        }
      }






      Console.WriteLine(output);

      return longString;
    }
  }
}
