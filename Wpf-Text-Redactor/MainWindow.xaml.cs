using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Wpf_Text_Redactor.Logic;

namespace Wpf_Text_Redactor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Connector connector;
        public MainWindow()
        {
            InitializeComponent();
            connector = new Connector(TextBox_TextMenu);
        }

        private void Button_Open_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                connector.Text_Open();
                TextBlock_FileName.Text = connector.File_Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                connector.Text_Save();
                TextBlock_FileName.Text = connector.File_Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
