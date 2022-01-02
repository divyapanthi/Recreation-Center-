using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_recreation_center
{
    class VisitorUtility
    {
        private static string _filePath = "visitor.txt";
        public static string WriteToText(string data)
        {
            if (File.Exists(_filePath))
            {
                using (File.Create(_filePath)) ;
            }

            using (StreamWriter outputFile = new StreamWriter(_filePath))
            {
                outputFile.WriteLine(data);
            }
            return "success";
        }
        public static string ReadFromFile()
        {
            if (File.Exists(_filePath))
            {
                string data = File.ReadAllText(_filePath);
                return data;
            }
            return "file does not exist";
        }
    }
}
