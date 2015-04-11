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
        //string userName = "";
        //Name and associated value
        private string nameID = "default";
        private Dictionary<string,int> amounts; 

        public Userfile()
        {
            amounts = new Dictionary<string,int>();
        }
        public Userfile(string nameID)
        {
            this.nameID = nameID;
            amounts = new Dictionary<string, int>();
        }
        public Dictionary<string, int> getList()
        {
            return amounts;
        }
        public string name
        {
            get
            {
                return nameID;
            }
        }
    }
}
