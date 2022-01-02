using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_recreation_center
{
    class Utility
    {
        public static void WriteToText(string _filePath, string data, bool append = true, int count = 1)
        {

            using (StreamWriter writer = new StreamWriter(_filePath, append: append))
            {
                if (!append)
                {
                    //remove opening bracket "[" from data passed
                    data = data.Trim().Substring(1, data.Trim().Length - 1);
                    //remove last bracket "]" from data passed
                    data = data.Trim().Substring(0, data.Trim().Length - 1);

                }
                if (count != 0)
                {
                    data += ",";
                }
                writer.WriteLine(data);
            }
        }
        public static string ReadFromFile(string path)
        {
            if (File.Exists(path))
            {
                string data;
                using (StreamReader r = new StreamReader(path))
                {
                    data = r.ReadToEnd();

                }
                if (data != "")
                {
                    data = "[" + data + "]";

                }
                return data;

            }
            return null;
        }

        public static DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            if (data != null)
            {
                foreach (T item in data)
                {
                    DataRow row = table.NewRow();
                    foreach (PropertyDescriptor prop in properties)
                        row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                    table.Rows.Add(row);
                }
            }
            return table;

        }
    }
}

