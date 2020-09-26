using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empty_check
{
    public class Class1
    {
        private string txterror1, txterror2, txterror3;
        public string Emptycheck(string txtstate1, string txtstate2, string txtstate3, string txtnull)
        {
            if (txtstate1 =="")
            {
                return txterror1 = "u moet nog uw Lengte invullen.";
            }
            
            else if (txtstate2 == "")
            {
                return txterror2 = "u moet nog uw Lengte invullen.";
            }
            
            else if (txtstate3 == "")
            {
                return txterror3 = "u moet nog uw Lengte invullen.";
            }
            
            return txtnull;
        }
    }
}
