using System;
using System.Collections.Generic;
using System.Text;

namespace WPFdotNetCore
{
    public class User
    {
        public User(string name, int rating, DateTime memberSince)
        {
            Name = name;
            Rating = rating;
            MemberSince = memberSince;
        }

        #region Property Getters and Setters

        public string Name { get; }

        public int Rating { get; set; }

        public DateTime MemberSince { get; }

        #endregion
    }
}
