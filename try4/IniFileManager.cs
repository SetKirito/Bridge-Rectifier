using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace try4
{
    class IniFileManager
    {
        public IniFileManager() {}
        public void SavePropertiesToIni(params object[] objects)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "INI files|*.ini";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = saveFileDialog.FileName;

                using (StreamWriter sw = new StreamWriter(filepath))
                {
                    foreach (var obj in objects)
                    {
                        SaveObjectPropertiesToIni(sw, obj);
                    }
                }
            }
        }
        private void SaveObjectPropertiesToIni(StreamWriter sw, object obj)
        {
            Type type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                if (property.GetCustomAttribute<IniSaveAttribute>() != null)
                {
                    object value = property.GetValue(obj);
                    sw.WriteLine($"{type.Name}.{property.Name}={value}");
                }
            }
        }
        public void LoadPropertiesFromIni(object obj1, object obj2, object obj3)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "INI files|*.ini";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string iniFilePath = openFileDialog.FileName;

                LoadObjectPropertiesFromIni(iniFilePath, obj1);
                LoadObjectPropertiesFromIni(iniFilePath, obj2);
                LoadObjectPropertiesFromIni(iniFilePath, obj3);
            }
        }
        private void LoadObjectPropertiesFromIni(string iniFilePath, object obj)
        {
            Type type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties();

            if (File.Exists(iniFilePath))
            {
                Dictionary<string, string> iniData = new Dictionary<string, string>();

                foreach (string line in File.ReadAllLines(iniFilePath))
                {
                    string[] parts = line.Split('=');
                    if (parts.Length == 2)
                    {
                        iniData[parts[0]] = parts[1];
                    }
                }

                foreach (PropertyInfo property in properties)
                {
                    if (iniData.ContainsKey($"{type.Name}.{property.Name}"))
                    {
                        object value = Convert.ChangeType(iniData[$"{type.Name}.{property.Name}"], property.PropertyType);
                        property.SetValue(obj, value);
                    }
                }
            }
        }


    }
}
