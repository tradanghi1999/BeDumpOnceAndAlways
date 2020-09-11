using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LED
{
    public class BLL
    {
        public int CheckConnection()
        {
            DAL dAL = new DAL();
            dAL.CloseConnection();
            return 1;
        }
    }
}
