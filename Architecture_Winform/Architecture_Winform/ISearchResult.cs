using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture_Winform
{
    public interface ISearchResult
    {
        void onSuccess(string[] news);
    }
}
