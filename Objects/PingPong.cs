using System;
using System.Collections.Generic;
namespace PingPongGenerator.Objects
{
  public class PingPongClass
  {
    public List<string> PingPongArray(int inputNumber)
    {
      List<string> numberArrayReturnList = new List<string> {};
      for (int i= 1; i<=inputNumber; i++)
      {
        if (i % 15 == 0)
        {
          numberArrayReturnList.Add("pingpong");
        }
        else if (i % 5 == 0)
        {
          numberArrayReturnList.Add("pong");
        }
        else if (i % 3 == 0)
        {
          numberArrayReturnList.Add("ping");
        }
        else
        {
          numberArrayReturnList.Add(Convert.ToString(i));
        }
      }
      return numberArrayReturnList;
    }
  }
}
