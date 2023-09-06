using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Wpf_Text_Redactor.Logic
{
    internal class Redactor 
    {
        Connector connector;
        TextBox textBox;
        public Redactor(TextBox textBox, Connector connector)
        {
            this.connector = connector;
            this.textBox = textBox;
        }



        
    }
}
