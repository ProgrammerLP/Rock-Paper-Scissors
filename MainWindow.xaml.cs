using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Schere_Stein_Papier
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int wins = 0;
        public static int total = 0;
        public static int lost = 0;

        public int ki;
        public int player1_index;

        public MainWindow()
        {
            InitializeComponent();
            LBL_wins.Content = "Wins: " + wins;
            LBL_total.Content = "Lost: " + lost;
            LBL_lost.Content = "total: " + total;
        }

        private void choice1_Click(object sender, RoutedEventArgs e)
        {
            choice1.IsEnabled = false;
            choice2.IsEnabled = false;
            choice3.IsEnabled = false;
            player1_index = 1;

            LBL_player_choice.Content = "Schere";

            AI();
        }

        private void choice2_Click(object sender, RoutedEventArgs e)
        {
            choice1.IsEnabled = false;
            choice2.IsEnabled = false;
            choice3.IsEnabled = false;
            player1_index = 2;

            LBL_player_choice.Content = "Papier";

            AI();
        }

        private void choice3_Click(object sender, RoutedEventArgs e)
        {
            choice1.IsEnabled = false;
            choice2.IsEnabled = false;
            choice3.IsEnabled = false;
            player1_index = 3;

            LBL_player_choice.Content = "Stein";

            AI();
        }

        public void AI()
        {
            Random random = new Random();

            ki = random.Next(1, 4);

            if (ki == 1)
            {
                LBL_KI_Choice.Content = "Schere";
                result();
            }

            if (ki == 2)
            {
                LBL_KI_Choice.Content = "Papier";
                result();
            }

            if (ki == 3)
            {
                LBL_KI_Choice.Content = "Stein";
                result();
            }
        }

        public void result()
        {
            //Resumee
            if (ki == 1 && player1_index == 1)
            {
                winner.Content = "Resumee";
                total += 1;
            }

            if (ki == 2 && player1_index == 2)
            {
                winner.Content = "Resumee";
                total += 1;
            }

            if (ki == 3 && player1_index == 3)
            {
                winner.Content = "Resumee";
                total += 1;
            }

            //KI wins
            if (ki == 1 && player1_index == 2)
            {
                winner.Content = "KI hat gewonnen";
                total += 1;
                lost += 1;
            }

            if (ki == 2 && player1_index == 3)
            {
                winner.Content = "KI hat gewonnen";
                total += 1;
                lost += 1;
            }

            if (ki == 3 && player1_index == 1)
            {
                winner.Content = "KI hat gewonnen";
                total += 1;
                lost += 1;
            }

            //Player wins
            if (ki == 2 && player1_index == 1)
            {
                winner.Content = "Player1 hat gewonnen";
                total += 1;
                wins += 1;
            }

            if (ki == 3 && player1_index == 2)
            {
                winner.Content = "Player1 hat gewonnen";
                total += 1;
                wins += 1;
            }

            if (ki == 1 && player1_index == 3)
            {
                winner.Content = "Player1 hat gewonnen";
                total += 1;
                wins += 1;
            }
            LBL_wins.Content = "Wins: " + wins;
            LBL_total.Content = "Lost: " + lost;
            LBL_lost.Content = "total: " + total;

            choice1.IsEnabled = true;
            choice2.IsEnabled = true;
            choice3.IsEnabled = true;
        }

        private void lbl_site_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Process.Start("https://programmerlp.net");
                Process.Start("https://programmerlp.w3spaces.com");
            }
            catch (Exception ex)
            {
                Process.Start("https://programmerlp.w3spaces.com");
            }
        }
    }
}
