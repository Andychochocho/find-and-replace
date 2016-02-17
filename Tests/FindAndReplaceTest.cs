using System.Collections.Generic;
using Xunit;
namespace FindReplaceProject.Objects
{
  public class FindAndReplaceTest
  {
    [Fact]
    public void testReplace_hellototheworldworlduniverse_hellothereworld()
    {
      FindAndReplace newFindAndReplace = new FindAndReplace ("hello to the world", "to the", "there");
      Assert.Equal(newFindAndReplace.Replace(), "hello there world");
    }
      [Fact]
    public void testReplace_ellohelloworldellothere_goodhelloworld()
    {
      FindAndReplace newFindAndReplace = new FindAndReplace("ello hello world", "ello", "good");
      Assert.Equal(newFindAndReplace.Replace(), "good hello world");
    }
    [Fact]
    public void testReplace_helloworldworlduniversehelloworld_hellouniverse()
    {
      FindAndReplace newFindAndReplace = new FindAndReplace("hello world", "world", "universe");
      Assert.Equal(newFindAndReplace.Replace(), "hello universe");
    }
    [Fact]
    public void testReplace_helloworldworlduniversehelloworld_helloplanet()
    {
      FindAndReplace newFindAndReplace = new FindAndReplace("hello world.", "world", "planet");
      Assert.Equal(newFindAndReplace.Replace(), "hello planet.");
    }
  }
}
