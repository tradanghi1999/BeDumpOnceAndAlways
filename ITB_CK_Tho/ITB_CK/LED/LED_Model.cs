using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//

namespace LED
{
    public class LED_Model
    {
        public class CommandGotten
        {
            public static CommandGotten GetCommand(string fromSQL)
            {
                return (CommandGotten)(Newtonsoft.Json.JsonConvert.DeserializeObject(fromSQL));
            }
            public string Type { get; set; }
            public string Conntent { get; set; }
            public object GetContentCommandObject()
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject(Conntent);
            }
        }
    }
}
 