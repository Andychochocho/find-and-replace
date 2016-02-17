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

    }
  }
}
