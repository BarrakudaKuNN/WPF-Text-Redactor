using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Wpf_Text_Redactor.Logic
{
    internal class Connector : IRedactor
    {
        string file_Path;
        string file_Text;
        string file_Name;


        TextBox textBox;
        OpenFileDialog file_Dialog;
        SaveFileDialog save_Dialog;

        public Connector(TextBox textBox)
        {
            this.textBox = textBox;
        }

        public string File_Path { get => file_Path; set => file_Path = value; }
        public string File_Text { get => file_Text; set => file_Text = value; }
        public string File_Name { get => file_Name; set => file_Name = value; }

        public void Text_Open()
        {
            file_Dialog = new OpenFileDialog();
            file_Dialog.Filter = "Text files (*.txt)|*.txt";
            file_Dialog.FilterIndex = 1;
            file_Dialog.RestoreDirectory = true;
            bool result = (bool)file_Dialog.ShowDialog();
            if(result)
            {
                file_Path = file_Dialog.FileName;
                file_Text = File.ReadAllText(file_Path);
                File_Name = file_Dialog.SafeFileName;
            }
            textBox.Text = file_Text;
        }
        public void Text_Save()
        {
            file_Text = textBox.Text;
            // Создание диалогового окна для сохранения файла
            save_Dialog = new SaveFileDialog();
            save_Dialog.Filter = "Text files (*.txt)|*.txt";
            save_Dialog.FilterIndex = 1;
            save_Dialog.RestoreDirectory = true;

            // Отображение диалогового окна и получение результата
            bool result = (bool)save_Dialog.ShowDialog();

            // Обработка результата
            if (result)
            {
                // Получение имени файла и сохранение его содержимого
                file_Path = save_Dialog.FileName;
                
                File.WriteAllText(file_Path, file_Text);
            }
        }
    }
}
