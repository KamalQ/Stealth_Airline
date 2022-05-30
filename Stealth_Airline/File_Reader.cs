using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Stealth_Airline
{
    class File_Reader
    {
        public static string ReadAllText(string path)
        {
            return File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), path));
        }
    }
}
