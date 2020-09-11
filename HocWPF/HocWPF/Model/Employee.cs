using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HocWPF.Model
{
    [Serializable]
    public class Employee
    {
        public string FirstName { get; set; }
        public string Favorite { get; set; }
        public string TString
        {
            get
            {
                return FirstName + " - " + Favorite;
            }
        }
        public override string ToString()
        {
            return FirstName + " - " + Favorite;
        }
    }
}
