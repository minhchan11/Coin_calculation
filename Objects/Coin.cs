using System;
using System.Collections.Generic;

namespace CoinApp.Objects
{
  public class Coin
  {
    public string ConvertToCoins(int cents)
    {
      string coinResult = "";
      //quarters
      int quarters = cents/25;
      if (quarters > 0)
      {
        coinResult += quarters.ToString() + " quarter(s) ";
      }
      cents %= 25;
      //dimes
      int dime = cents/10;
      if (dime > 0)
      {
        coinResult += dime.ToString() + " dime(s) ";
      }
      cents %= 10;
      //nickels
      int nickels = cents/5;
      if (nickels > 0)
      {
        coinResult += nickels.ToString() + " nickel(s) ";
      }
      cents %= 5;
      if (cents > 0)
      {
        coinResult += cents.ToString() + " pennie(s)";
      }
      return coinResult;
    }
  }
}
