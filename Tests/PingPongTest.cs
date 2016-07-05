using System;
using System.Collections.Generic;
using Xunit;
namespace PingPongGenerator.Objects
{
  public class PingPongClassTest
  {
    [Fact]
    public void PingPongArray_NumbersLessThanThree_NumberArrayReturnList()
    {
      //Arrange
      List<string> pingPongClassTestList = new List<string> {"1", "2"};
      PingPongClass testPingPong = new PingPongClass();
      //Act
      List<string> result = testPingPong.PingPongArray(2);
      //Assert
      Assert.Equal(pingPongClassTestList, result);
    }
    [Fact]
    public void PingPongArray_NumbersDivisibleByThree_NumberArrayReturnList()
    {
      //Arrange
      List<string> pingPongClassTestList = new List<string> {"1", "2", "ping"};
      PingPongClass testPingPong = new PingPongClass(); //Contructor statement
      //Act
      List<string> result = testPingPong.PingPongArray(3); //output of the method that we're testing.
      //Assert
      Assert.Equal(pingPongClassTestList, result);
    }

    [Fact]
    public void PingPongArray_NumbersDivisibleByFive_NumberArrayReturnList()
    {
      //Arrange
      List<string> pingPongClassTestList = new List<string> {"1", "2", "ping", "4", "pong"};
      PingPongClass testPingPong = new PingPongClass();

      //act
      List<string> result = testPingPong.PingPongArray(5);

      //Assert
      Assert.Equal(pingPongClassTestList, result);
    }

    [Fact]
    public void PingPongArray_NumbersDivisibleByFifteen_NumbersArrayReturnList()
    {
      //Arrange
      List<string> pingPongClassTestList = new List<string> {"1", "2", "ping", "4", "pong", "ping", "7", "8", "ping", "pong", "11", "ping", "13", "14", "pingpong"};
      PingPongClass testPingPong = new PingPongClass();

      //act
      List<string> result = testPingPong.PingPongArray(15);

      //Assert
      Assert.Equal(pingPongClassTestList, result);
    }

  }
}
