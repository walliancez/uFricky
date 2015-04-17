using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace uFricky
{
    [Serializable]
    public class Userfile
    {
        //Not yet implemented username
        //string userName = "";
        //Name and associated value

        //Holy shit this is not safe at all. Plz do not use

        private string nameID;
        private byte[] hashedPassword;
        private int salt;
        private Dictionary<string,int> amounts; 

        public Userfile()
        {
            amounts = new Dictionary<string,int>();
        }
        public Userfile(string nameID, string password)
        {
            this.nameID = nameID;
            Random random = new Random();
            salt = random.Next(1000000000);
            MD5 md5 = MD5.Create();
            hashedPassword = md5.ComputeHash(System.Text.Encoding.ASCII.GetBytes(password + salt.ToString()));
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
