using Nancy;
using System.Collections.Generic;
using PingPongGenerator.Objects;

namespace PingPongGenerator
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/results"] = _ => {
        PingPongClass pingPong = new PingPongClass();
        int userNumber = Request.Query["user-number"];
        var numberArrayReturnList = pingPong.PingPongArray(userNumber);
        return View["results_list.cshtml", numberArrayReturnList];
      };
    }
  }
}
