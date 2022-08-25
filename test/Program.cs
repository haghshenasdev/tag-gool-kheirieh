using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
                string dpath = "templates";
                Directory.Move(dpath + "\\defult3", dpath + "\\defult4");
        }
    }
}
