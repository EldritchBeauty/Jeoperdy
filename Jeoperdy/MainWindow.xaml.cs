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

namespace Jeoperdy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public PlayerNames playerNames = new PlayerNames();
        public ColumnNames columnNames = new ColumnNames();
        #region Boolslist

        bool X0Y2On = true;
        bool X1Y2On = true;
        bool X2Y2On = true;
        bool X3Y2On = true;
        bool X4Y2On = true;
        bool X5Y2On = true;

        bool X0Y3On = true;
        bool X1Y3On = true;
        bool X2Y3On = true;
        bool X3Y3On = true;
        bool X4Y3On = true;
        bool X5Y3On = true;

        bool X0Y4On = true;
        bool X1Y4On = true;
        bool X2Y4On = true;
        bool X3Y4On = true;
        bool X4Y4On = true;
        bool X5Y4On = true;

        bool X0Y5On = true;
        bool X1Y5On = true;
        bool X2Y5On = true;
        bool X3Y5On = true;
        bool X4Y5On = true;
        bool X5Y5On = true;

        bool X0Y6On = true;
        bool X1Y6On = true;
        bool X2Y6On = true;
        bool X3Y6On = true;
        bool X4Y6On = true;
        bool X5Y6On = true;
        #endregion
        int DailyDoubleX;
        int DailyDoubleY;
        public MainWindow()
        {
            InitializeComponent();


            Random rnd = new Random();
            DailyDoubleX = rnd.Next(1, 6);
            DailyDoubleY = rnd.Next(1, 5);


            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.None;
            ResizeMode = ResizeMode.NoResize;

            PlayerWindow settings = new PlayerWindow(playerNames);
            settings.Show();
        }

        public bool DailyDouble(float x, float y)
        {
            if (x == DailyDoubleX && y == DailyDoubleY)
            { 
                return true;
            }
            else { return false; }
        }

        #region Column2
        private void X0Y2_Click(object sender, RoutedEventArgs e)
        {
            if (X0Y2On == true)
            {
                if(DailyDouble(1, 1))
                {
                    X0Y2.Content = "Double!";
                    X0Y2.FontSize = 50;
                    DailyDoubleX = 0;
                    DailyDoubleY = 0;
                }
                else
                {
                    X0Y2.Content = "";
                    X0Y2On = false;
                }
            }
            else
            {
                X0Y2.FontSize = 120;
                X0Y2.Content = "200";
                X0Y2On = true;
            }
        }

        private void X1Y2_Click(object sender, RoutedEventArgs e)
        {
            if (X1Y2On == true)
            {
                if (DailyDouble(2, 1))
                {
                    X1Y2.Content = "Double!";
                    X1Y2.FontSize = 60;
                    DailyDoubleX = 0;
                    DailyDoubleY = 0;
                }
                else
                {
                    X1Y2.Content = "";
                    X1Y2On = false;
                }
            }
            else
            {
                X1Y2.FontSize = 120;
                X1Y2.Content = "200";
                X1Y2On = true;
            }
        }

        private void X2Y2_Click(object sender, RoutedEventArgs e)
        {
            if (X2Y2On == true)
            {
                if (DailyDouble(3, 1))
                {
                    X2Y2.Content = "Double!";
                    X2Y2.FontSize = 60;
                    DailyDoubleX = 0;
                    DailyDoubleY = 0;
                }
                else
                {
                    X2Y2.Content = "";
                    X2Y2On = false; 
                }
            }
            else
            {
                X2Y2.Content = "200";
                X2Y2On = true;
            }
        }

        private void X3Y2_Click(object sender, RoutedEventArgs e)
        {
            if (X3Y2On == true)
            {
                if (DailyDouble(4, 1))
                {
                    X3Y2.Content = "Double!";
                    X3Y2.FontSize = 60;
                    DailyDoubleX = 0;
                    DailyDoubleY = 0;
                }
                else
                {
                    X3Y2.Content = "";
                    X3Y2On = false;
                }
            }
            else
            {
                X3Y2.Content = "200";
                X3Y2On = true;
            }
        }

        private void X4Y2_Click(object sender, RoutedEventArgs e)
        {
            if (X4Y2On == true)
            {
                if (DailyDouble(5, 1))
                {
                    X4Y2.Content = "Double!";
                    X4Y2.FontSize = 60;
                    DailyDoubleX = 0;
                    DailyDoubleY = 0;
                }
                else
                {
                    X4Y2.Content = "";
                    X4Y2On = false;
                }
            }
            else
            {
                X4Y2.Content = "200";
                X4Y2On = true;
            }
        }

        private void X5Y2_Click(object sender, RoutedEventArgs e)
        {
            if (X5Y2On == true)
            {
                if (DailyDouble(6, 1))
                {
                    X5Y2.Content = "Double!";
                    X5Y2.FontSize = 60;
                    DailyDoubleX = 0;
                    DailyDoubleY = 0;
                }
                else
                {
                    X5Y2.Content = "";
                    X5Y2On = false;
                }
            }
            else
            {
                X5Y2.Content = "200";
                X5Y2On = true;
            }
        }
        #endregion

        #region Column3
        private void X0Y3_Click(object sender, RoutedEventArgs e)
        {
            if (X0Y3On == true)
            {
                if (DailyDouble(1, 2))
                {
                    X0Y3.Content = "Double!";
                    X0Y3.FontSize = 60;
                    DailyDoubleX = 0;
                    DailyDoubleY = 0;
                }
                else
                {
                    X0Y3.Content = "";
                    X0Y3On = false;
                }
            }
            else
            {
                X0Y3.FontSize = 120;
                X0Y3.Content = "400";
                X0Y3On = true;
            }
        }
        private void X1Y3_Click(object sender, RoutedEventArgs e)
        {
            if (X1Y3On == true)
            {
                if (DailyDouble(2, 2))
                {
                    X1Y3.Content = "Double!";
                    X1Y3.FontSize = 60;
                    DailyDoubleX = 0;
                    DailyDoubleY = 0;
                }
                else
                {
                    X1Y3.Content = "";
                    X1Y3On = false;
                }
            }
            else
            {
                X1Y3.FontSize = 120;
                X1Y3.Content = "400";
                X1Y3On = true;
            }
        }

        private void X2Y3_Click(object sender, RoutedEventArgs e)
        {
            if (X2Y3On == true)
            {
                if (DailyDouble(3, 2))
                {
                    X2Y3.Content = "Double!";
                    X2Y3.FontSize = 60;
                    DailyDoubleX = 0;
                    DailyDoubleY = 0;
                }
                else
                {
                    X2Y3.Content = "";
                    X2Y3On = false;
                }
            }
            else
            {
                X2Y2.FontSize = 120;
                X2Y3.Content = "400";
                X2Y3On = true;
            }
        }

        private void X3Y3_Click(object sender, RoutedEventArgs e)
        {
            if (X3Y3On == true)
            {
                if (DailyDouble(4, 2))
                {
                    X3Y3.Content = "Double!";
                    X3Y3.FontSize = 60;
                    DailyDoubleX = 0;
                    DailyDoubleY = 0;
                }
                else
                {
                    X3Y3.Content = "";
                    X3Y3On = false;
                }
            }
            else
            {
                X3Y3.FontSize = 120;
                X3Y3.Content = "400";
                X3Y3On = true;
            }
        }

        private void X4Y3_Click(object sender, RoutedEventArgs e)
        {
            if (X4Y3On == true)
            {
                if (DailyDouble(5, 2))
                {
                    X4Y3.Content = "Double!";
                    X4Y3.FontSize = 60;
                    DailyDoubleX = 0;
                    DailyDoubleY = 0;
                }
                else
                {
                    X4Y3.Content = "";
                    X4Y3On = false;
                }
            }
            else
            {
                X4Y3.FontSize = 120;
                X4Y3.Content = "400";
                X4Y3On = true;
            }
        }

        private void X5Y3_Click(object sender, RoutedEventArgs e)
        {
            if (X5Y3On == true)
            {
                if (DailyDouble(6, 2))
                {
                    X5Y3.Content = "Double!";
                    X5Y3.FontSize = 60;
                    DailyDoubleX = 0;
                    DailyDoubleY = 0;
                }
                else
                {
                    X5Y3.Content = "";
                    X5Y3On = false;
                }
            }
            else
            {
                X5Y3.FontSize = 120;
                X5Y3.Content = "400";
                X5Y3On = true;
            }
        }
        #endregion

        #region Column4
        private void X0Y4_Click(object sender, RoutedEventArgs e)
        {
            if (X0Y4On == true)
            {
                if (DailyDouble(1, 3))
                {
                    X0Y4.Content = "Double!";
                    X0Y4.FontSize = 60;
                    DailyDoubleX = 0;
                    DailyDoubleY = 0;
                }
                else
                {
                    X0Y4.Content = "";
                    X0Y4On = false;
                }
            }
            else
            {
                X0Y4.FontSize = 120;
                X0Y4.Content = "600";
                X0Y4On = true;
            }
        }

        private void X1Y4_Click(object sender, RoutedEventArgs e)
        {
            if (X1Y4On == true)
            {
                if (DailyDouble(2, 3))
                {
                    X1Y4.Content = "Double!";
                    X1Y4.FontSize = 60;
                    DailyDoubleX = 0;
                    DailyDoubleY = 0;
                }
                else
                {
                    X1Y4.Content = "";
                    X1Y4On = false;
                }
            }
            else
            {
                X1Y4.FontSize = 120;
                X1Y4.Content = "600";
                X1Y4On = true;
            }
        }

        private void X2Y4_Click(object sender, RoutedEventArgs e)
        {
            if (X2Y4On == true)
            {
                if (DailyDouble(3, 3))
                {
                    X2Y4.Content = "Double!";
                    X2Y4.FontSize = 60;
                    DailyDoubleX = 0;
                    DailyDoubleY = 0;
                }
                else
                {
                    X2Y4.Content = "";
                    X2Y4On = false;
                }
            }
            else
            {X2Y4.FontSize = 120;
                X2Y4.Content = "600";
                X2Y4On = true;
            }
        }

        private void X3Y4_Click(object sender, RoutedEventArgs e)
        { 
            if (X3Y4On == true)
            {
                if (DailyDouble(4, 3))
                {
                    X3Y4.Content = "Double!";
                    X3Y4.FontSize = 60;
                    DailyDoubleX = 0;
                    DailyDoubleY = 0;
                }
                else
                {
                    X3Y4.Content = "";
                    X3Y4On = false;
                }
            }
            else
            {X3Y4.FontSize = 120;
                X3Y4.Content = "600";
                X3Y4On = true;
            }
        }

        private void X4Y4_Click(object sender, RoutedEventArgs e)
        {
            if (X4Y4On == true)
            {
                if (DailyDouble(5, 3))
                {
                    X4Y4.Content = "Double!";
                    X4Y4.FontSize = 60;
                    DailyDoubleX = 0;
                    DailyDoubleY = 0;
                }
                else
                {
                    X4Y4.Content = "";
                    X4Y4On = false;
                }
            }
            else
            {X4Y4.FontSize = 120;
                X4Y4.Content = "600";
                X4Y4On = true;
            }
        }

        private void X5Y4_Click(object sender, RoutedEventArgs e)
        {
            if (X5Y4On == true)
            {
                if (DailyDouble(6, 3))
                {
                    X5Y4.Content = "Double!";
                    X5Y4.FontSize = 60;
                    DailyDoubleX = 0;
                    DailyDoubleY = 0;
                }
                else
                {
                    X5Y4.Content = "";
                    X5Y4On = false;
                }
            }
            else
            {X5Y4.FontSize = 120;
                X5Y4.Content = "600";
                X5Y4On = true;
            }
        }
        #endregion

        #region Column5
        private void X0Y5_Click(object sender, RoutedEventArgs e)
        {
            if (X0Y5On == true)
            {
                if (DailyDouble(1, 4))
                {
                    X0Y5.Content = "Double!";
                    X0Y5.FontSize = 60;
                    DailyDoubleX = 0;
                    DailyDoubleY = 0;
                }
                else
                {
                    X0Y5.Content = "";
                    X0Y5On = false;
                }
            }
            else
            {X0Y5.FontSize = 120;
                X0Y5.Content = "800";
                X0Y5On = true;
            }
        }

        private void X1Y5_Click(object sender, RoutedEventArgs e)
        {
            if (X1Y5On == true)
            {
                if (DailyDouble(2, 4))
                {
                    X1Y5.Content = "Double!";
                    X1Y5.FontSize = 60;
                    DailyDoubleX = 0;
                    DailyDoubleY = 0;
                }
                else
                {
                    X1Y5.Content = "";
                    X1Y5On = false;
                }
            }
            else
            {X1Y5.FontSize = 120;
                X1Y5.Content = "800";
                X1Y5On = true;
            }
        }

        private void X2Y5_Click(object sender, RoutedEventArgs e)
        {
            if (X2Y5On == true)
            {
                if (DailyDouble(3, 4))
                {
                    X2Y5.Content = "Double!";
                    X2Y5.FontSize = 60;
                    DailyDoubleX = 0;
                    DailyDoubleY = 0;
                }
                else
                {
                    X2Y5.Content = "";
                    X2Y5On = false;
                }
            }
            else
            {
                X2Y5.FontSize = 120;
                X2Y5.Content = "800";
                X2Y5On = true;
            }
        }

        private void X3Y5_Click(object sender, RoutedEventArgs e)
        {
            if (X3Y5On == true)
            {
                if (DailyDouble(4, 4))
                {
                    X3Y5.Content = "Double!";
                    X3Y5.FontSize = 60;
                    DailyDoubleX = 0;
                    DailyDoubleY = 0;
                }
                else
                {
                    X3Y5.Content = "";
                    X3Y5On = false;
                }
            }
            else
            {X3Y5.FontSize = 120;
                X3Y5.Content = "800";
                X3Y5On = true;
            }
        }

        private void X4Y5_Click(object sender, RoutedEventArgs e)
        {
            if (X4Y5On == true)
            {
                if (DailyDouble(5, 4))
                {
                    X4Y5.Content = "Double!";
                    X4Y5.FontSize = 60;
                    DailyDoubleX = 0;
                    DailyDoubleY = 0;
                }
                else
                {
                    X4Y5.Content = "";
                    X4Y5On = false;
                }
            }
            else
            {X4Y5.FontSize = 120;
                X4Y5.Content = "800";
                X4Y5On = true;
            }
        }

        private void X5Y5_Click(object sender, RoutedEventArgs e)
        {
            if (X5Y5On == true)
            {
                if (DailyDouble(6, 4))
                {
                    X5Y5.Content = "Double!";
                    X5Y5.FontSize = 60;
                    DailyDoubleX = 0;
                    DailyDoubleY = 0;
                }
                else
                {
                    X5Y5.Content = "";
                    X5Y5On = false;
                }
            }
            else
            {X5Y5.FontSize = 120;
                X5Y5.Content = "800";
                X5Y5On = true;
            }
        }
        #endregion

        #region Column6
        private void X0Y6_Click(object sender, RoutedEventArgs e)
        {
            if (X0Y6On == true)
            {
                if (DailyDouble(1, 5))
                {
                    X0Y6.Content = "Double!";
                    X0Y6.FontSize = 60;
                    DailyDoubleX = 0;
                    DailyDoubleY = 0;
                }
                else
                {
                    X0Y6.Content = "";
                    X0Y6On = false;
                }
            }
            else
            {X0Y6.FontSize = 120;
                X0Y6.Content = "1000";
                X0Y6On = true;
            }
        }

        private void X1Y6_Click(object sender, RoutedEventArgs e)
        {
            if (X1Y6On == true)
            {
                if (DailyDouble(2, 5))
                {
                    X1Y6.Content = "Double!";
                    X1Y6.FontSize = 60;
                    DailyDoubleX = 0;
                    DailyDoubleY = 0;
                }
                else
                {
                    X1Y6.Content = "";
                    X1Y6On = false;
                }
            }
            else
            {X1Y6.FontSize = 120;
                X1Y6.Content = "1000";
                X1Y6On = true;
            }
        }

        private void X2Y6_Click(object sender, RoutedEventArgs e)
        {
            if (X2Y6On == true)
            {
                if (DailyDouble(3, 5))
                {
                    X2Y6.Content = "Double!";
                    X2Y6.FontSize = 60;
                    DailyDoubleX = 0;
                    DailyDoubleY = 0;
                }
                else
                {
                    X2Y6.Content = "";
                    X2Y6On = false;
                }
            }
            else
            {X2Y6.FontSize = 120;
                X2Y6.Content = "1000";
                X2Y6On = true;
            }
        }

        private void X3Y6_Click(object sender, RoutedEventArgs e)
        {
            if (X3Y6On == true)
            {
                if (DailyDouble(4, 5))
                {
                    X3Y6.Content = "Double!";
                    X3Y6.FontSize = 60;
                    DailyDoubleX = 0;
                    DailyDoubleY = 0;
                }
                else
                {
                    X3Y6.Content = "";
                    X3Y6On = false;
                }
            }
            else
            {X3Y6.FontSize = 120;
                X3Y6.Content = "1000";
                X3Y6On = true;
            }
        }

        private void X4Y6_Click(object sender, RoutedEventArgs e)
        {
            if (X4Y6On == true)
            {
                if (DailyDouble(5, 5))
                {
                    X4Y6.Content = "Double!";
                    X4Y6.FontSize = 60;
                    DailyDoubleX = 0;
                    DailyDoubleY = 0;
                }
                else
                {
                    X4Y6.Content = "";
                    X4Y6On = false;
                }
            }
            else
            {X4Y6.FontSize = 120;
                X4Y6.Content = "1000";
                X4Y6On = true;
            }
        }

        private void X5Y6_Click(object sender, RoutedEventArgs e)
        {
            if (X5Y6On == true)
            {
                if (DailyDouble(6, 5))
                {
                    X5Y6.Content = "Double!";
                    X5Y6.FontSize = 60;
                    DailyDoubleX = 0;
                    DailyDoubleY = 0;
                }
                else
                {
                    X5Y6.Content = "";
                    X5Y6On = false;
                }
            }
            else
            {X5Y6.FontSize = 120;
                X5Y6.Content = "1000";
                X5Y6On = true;
            }
        }
        #endregion

        private void SettingsButton(object sender, RoutedEventArgs e)
        {
            SettingsWindow settings = new SettingsWindow();
            settings.Show();
        }

        private void Window_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            X0Y1.Text = columnNames.Column1;
            X1Y1.Text = columnNames.Column2;
            X2Y1.Text = columnNames.Column3;
            X3Y1.Text = columnNames.Column4;
            X4Y1.Text = columnNames.Column5;
            X5Y1.Text = columnNames.Column6;
        }
    }
}
