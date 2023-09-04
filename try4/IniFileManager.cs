using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;

namespace try4
{
    class IniFileManager
    {
        private string filepath;
        private string iniFilePath;
        public IniFileManager() {}
        public void SavePropertiesToIni(params object[] objects)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "INI files|*.ini";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = saveFileDialog.FileName;

                try
                {
                    using (StreamWriter sw = new StreamWriter(filepath))
                    {
                        foreach (var obj in objects)
                        {
                            SaveObjectPropertiesToIni(sw, obj);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while saving the INI file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public void SaveComboBoxPropertiesToIni(params ComboBox[] boxes)
        {
            using (StreamWriter sw = new StreamWriter(filepath, true))
            {
                foreach(var box in boxes)
                {
                    sw.WriteLine($"{box.Name}.SelectedIndex={box.SelectedIndex}");
                }
            }
        }
        public void LoadPropertiesFromIni(params object[] objects)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "INI files|*.ini";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                iniFilePath = openFileDialog.FileName;

                try
                {
                    foreach (var obj in objects)
                    {
                        LoadObjectPropertiesFromIni(iniFilePath, obj);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading the INI file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
        public void LoadComboBoxPropertiesFromIni(params ComboBox[] boxes)
        {
            if (File.Exists(iniFilePath))
            {
                foreach (var box in boxes)
                {
                    string comboBoxKey = $"{box.Name}.SelectedIndex";
                    int selectedIndex = -1; // По умолчанию

                    // Считываем значение из ini-файла
                    string[] lines = File.ReadAllLines(iniFilePath);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('=');
                        if (parts.Length == 2 && parts[0] == comboBoxKey)
                        {
                            if (int.TryParse(parts[1], out selectedIndex))
                            {
                                box.SelectedIndex = selectedIndex;
                                break; // Найдено значение, можно выйти из цикла
                            }
                        }
                    }
                }
            }
        }


    }
}
