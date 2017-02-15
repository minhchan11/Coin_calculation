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

// public List<string> Change()
//    {
//      int total = _amount;
//      if( (total > 0) & (total < 100) )
//      {
//        Random Random = new Random();
//        int quanQuar = total / 25;
//        int quarters = Random.Next(0, quanQuar);
//        string quarterStr = quarters.ToString() + " quarter(s)";
//        _coinList.Add(quarterStr);
//        int dimeQuan = (total - (quarters * 25)) / 10;
//        int dimes = Random.Next(0, dimeQuan);
//        string dimeStr = dimes.ToString() + " Dime(s)";
//        _coinList.Add(dimeStr);
//        int nickelQuan = (total - (quarters * 25) - (dimes * 10)) / 5;
//        int nickels = Random.Next(0, nickelQuan);
//        string nickelStr = nickels.ToString() + " Nickel(s)";
//        _coinList.Add(nickelStr);
//        int pennyQuan = (total - (quarters * 25) - (dimes * 10) - (nickels * 5)) / 1;
//        string pennyStr = pennyQuan.ToString() + " pennie(s)";
//        _coinList.Add(pennyStr);
//      }
//      return _coinList;
//    }
//  }
