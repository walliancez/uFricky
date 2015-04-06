using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace uFricky
{
    class Program
    {
        FileHandler fileHandler = new FileHandler();
        Userfile userfile = new Userfile();
        bool running = true;

        public void printTable(Userfile f)
        {
            foreach(KeyValuePair<string,int> entry in f.amounts)
            {
                Console.WriteLine(entry.Key + " " + entry.Value);
            }
        }
        public void updateFile()
        {
            userfile = fileHandler.ReadFromFile();
        }
        public void inputReadAndDo(string input)
        {
            string[] orders = input.Split(' ');

            switch (orders[0])
            {
                case "add":
                    userfile.amounts.Add(orders[1], Convert.ToInt32(orders[2]));
                    break;
                case "print":
                    printTable(userfile);
                    break;
                case "exit":
                    running = false;
                    break;
                case "clear":
                case "cls":
                    Console.Clear();
                    break;
                case "delete":
                    FileHandler.Delete();
                    break;
                default:
                    Console.WriteLine("Oops! Wrong command!");
                    break;
            }
        }
        public void Run()
        {
            updateFile();
            while (running)
            {
                inputReadAndDo(Console.ReadLine());

                
            }
            fileHandler.WriteToFile(userfile);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
            //FileHandler.Delete();
        }
    }
}
