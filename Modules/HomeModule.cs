using Nancy;
using FindReplaceProject.Objects;
using System.Collections.Generic;

namespace FindReplaceProject
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {

      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/output"] = _ =>
      {

        return View["output.cshtml"];
      };
    }
  }
}
