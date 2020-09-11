using System;
using System.Collections.Generic;
using System.Text;

namespace RenewDotNetCoreWPF
{
    public class Bid
    {
        public Bid(int amount, User bidder)
        {
            Amount = amount;
            Bidder = bidder;
        }

        #region Property Getters and Setters

        public int Amount { get; }

        public User Bidder { get; }

        #endregion
    }
}
