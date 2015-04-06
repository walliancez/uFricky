﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace uFricky
{
    public class FileHandler
    {
        public string saveFolder;

        //<summary>Not yet implemented</summary>
        public FileHandler(string saveFolder)
        {
            this.saveFolder = saveFolder;
        }

        public static void Delete()
        {
            File.Delete("list.bin");
        }

        public FileHandler()
        {
        }

        public void WriteToFile(Userfile userFile)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("list.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, userFile);
            stream.Close();
        }
        public Userfile ReadFromFile()
        {
            Userfile returnUserfile;
            if (File.Exists("list.bin"))
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("list.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                returnUserfile = (Userfile)formatter.Deserialize(stream);
                stream.Close();
            }
            else
            {
                return new Userfile();
            }
            return returnUserfile;
        }
    }
}
