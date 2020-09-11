using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture_Winform
{
    public class SearchQuerier: ISearchResult
    {
        string keywords;
        public SearchQuerier()
        {
            this.keywords = "ALO HA";
        }
        public void onSuccess(string[] news)
        {
            Console.WriteLine(news);
        }
    }
}
