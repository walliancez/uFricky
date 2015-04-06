using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uFricky
{
    [Serializable]
    public class Userfile
    {
        //Not yet implemented username
        string userName = "";
        //Name and associated value
        public Dictionary<string,int> amounts = new Dictionary<string,int>();
    }
}
