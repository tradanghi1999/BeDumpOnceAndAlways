using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture_Winform
{
    public class SearchMachine
    {
        ISearchResult iResult;
        public SearchMachine(ISearchResult ise)
        {
            iResult = ise;
            //iResult.sendKeywordToGetResult(iResult.getKeyWords());
            //iResult = new ISearchResult();
        }
        public void SendToGetNews()
        {
            string[] strs = new string[] {"name", "thu","ten" };
            iResult.onSuccess(strs);
        }

    }
}
