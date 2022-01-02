﻿using System;
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
        public static void WriteToTextFile(string filePath, string data, bool append = true, int count = 1)
        {
            if (!File.Exists(filePath))
            {
                var file = File.Create(filePath);
                file.Close();
            }
            using (StreamWriter write = new StreamWriter(filePath, append: append))
            {
                if (!append)
                {
                    data = data.Trim().Substring(1, data.Trim().Length - 1);
                    data = data.Trim().Substring(0, data.Trim().Length - 1);
                }
                if (count != 0)
                {
                    data = data + ",";
                }
                write.WriteLine(data);
            }
        }
        public static string ReadFromTextFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                string data;
                using (StreamReader read = new StreamReader(filePath))
                {
                    data = read.ReadToEnd();
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
