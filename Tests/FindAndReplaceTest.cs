using System.Collections.Generic;
using Xunit;
namespace FindReplaceProject.Objects
{
  public class FindAndReplaceTest
  {
    [Fact]
    public void testReplace()
    {
      FindAndReplace newFindAndReplace = new FindAndReplace ("Hello world", "world", "universe");
      Assert.Equal(newFindAndReplace.Replace(), "Hello universe");
    }
  }
}
