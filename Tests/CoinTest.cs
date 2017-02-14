using System;
using Xunit;
using System.Collections.Generic;
using CoinApp.Objects;

namespace CoinApp
{
  public class CoinTest
  {
    [Fact]
    public void ConvertToCoins_ConverToQuarters_String()
    {
      Coin testCoin = new Coin();
      string testString = "2 quarter(s) 1 dime(s) 1 nickel(s) 4 pennie(s)";

      Assert.Equal(testString, testCoin.ConvertToCoins(69));
    }
    [Fact]
    public void ConvertToCoins_ConverToPennies_String()
    {
      Coin testCoin = new Coin();
      string testString = "2 quarter(s) 1 dime(s) 1 nickel(s) 4 pennie(s)";

      Assert.Equal(testString, testCoin.ConvertToCoins(69));
    }
  }
}
