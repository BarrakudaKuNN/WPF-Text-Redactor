using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Text_Redactor.Logic
{
    internal class Connector
    {
        OpenFileDialog file_Dialog;

        void Dialog_Open()
        {
            file_Dialog = new OpenFileDialog();
            file_Dialog.Filter = "Text files (*.txt)|*.txt";
            file_Dialog.FilterIndex = 1;
            file_Dialog.RestoreDirectory = true;
            Nullable<bool> result = file_Dialog.ShowDialog();
        }
        public void Text_Open()
        {
            Dialog_Open();

        }
    }
}
