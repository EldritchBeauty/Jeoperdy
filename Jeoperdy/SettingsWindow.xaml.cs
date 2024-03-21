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
using System.Windows.Shapes;

namespace Jeoperdy
{ 
    public partial class SettingsWindow : Window
    {
        MainWindow windowNames = (MainWindow) Application.Current.Windows[0];
        public SettingsWindow()
        {
            InitializeComponent();
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            windowNames.playerNames.Name1 = Player1NameInput.Text;
            Player1NameInput.Text = "";
            windowNames.playerNames.Name2 = Player2NameInput.Text;
            Player2NameInput.Text = "";
            windowNames.playerNames.Name3 = Player3NameInput.Text;
            Player3NameInput.Text = "";

            windowNames.columnNames.Column1 = Column1NameInput.Text;
            Column1NameInput.Text = "";
            windowNames.columnNames.Column2 = Column2NameInput.Text;
            Column2NameInput.Text = "";
            windowNames.columnNames.Column3 = Column3NameInput.Text;
            Column3NameInput.Text = "";
            windowNames.columnNames.Column4 = Column4NameInput.Text;
            Column4NameInput.Text = "";
            windowNames.columnNames.Column5 = Column5NameInput.Text;
            Column5NameInput.Text = "";
            windowNames.columnNames.Column6 = Column6NameInput.Text;
            Column6NameInput.Text = "";

            Close();
        }
    }
}
