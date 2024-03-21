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
    /// <summary>
    /// Interaction logic for PlayerWindow.xaml
    /// </summary>
    public partial class PlayerWindow : Window
    {
        PlayerNames playerNames = new PlayerNames();
         
        float Player1CurrentScore;
        float Player2CurrentScore;
        float Player3CurrentScore;
        public PlayerWindow(PlayerNames names)
        {
            InitializeComponent();
            playerNames = names;

            Player1Name.Content = playerNames.Name1;
            Player2Name.Content = playerNames.Name2;
            Player3Name.Content = playerNames.Name3;
        }

        #region Scoring
        private void Player1ScoreUp_Click(object sender, RoutedEventArgs e)
        { 
            Player1CurrentScore = Player1CurrentScore + 200;
            Player1Score.Content = Player1CurrentScore;
        }

        private void Player2ScoreUp_Click(object sender, RoutedEventArgs e)
        {

            Player2CurrentScore = Player2CurrentScore + 200;
            Player2Score.Content = Player2CurrentScore;
        }

        private void Player3ScoreUp_Click(object sender, RoutedEventArgs e)
        {

            Player3CurrentScore = Player3CurrentScore + 200;
            Player3Score.Content = Player3CurrentScore;
        }

        private void Player1ScoreDown_Click(object sender, RoutedEventArgs e)
        {
            Player1CurrentScore = Player1CurrentScore - 200;
            Player1Score.Content = Player1CurrentScore;
        }

        private void Player2ScoreDown_Click(object sender, RoutedEventArgs e)
        {

            Player2CurrentScore = Player2CurrentScore - 200;
            Player2Score.Content = Player2CurrentScore;
        }

        private void Player3ScoreDown_Click(object sender, RoutedEventArgs e)
        {

            Player3CurrentScore = Player3CurrentScore - 200;
            Player3Score.Content = Player3CurrentScore;
        }
        #endregion

        private void Window_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            Player1Name.Content = playerNames.Name1;
            Player2Name.Content = playerNames.Name2;
            Player3Name.Content = playerNames.Name3;

        }
    }
}
