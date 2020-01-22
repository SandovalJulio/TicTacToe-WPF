using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace TicTacToe2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Image[] order = new Image[10];
        Image[] position = new Image[9];

        public MainWindow()
        {
            InitializeComponent();
        }

        private void exitButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void minusButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Enter(object sender, MouseEventArgs e)
        {
            ((UIElement)sender).BeginAnimation(OpacityProperty, new DoubleAnimation(((UIElement)sender).Opacity, 0.65, TimeSpan.FromMilliseconds(150)));
        }

        private void Leave(object sender, MouseEventArgs e)
        {
            ((UIElement)sender).BeginAnimation(OpacityProperty, new DoubleAnimation(((UIElement)sender).Opacity, 1, TimeSpan.FromMilliseconds(150)));
        }

        private void Down(object sender, MouseButtonEventArgs e)
        {
            ((UIElement)sender).BeginAnimation(OpacityProperty, new DoubleAnimation(((UIElement)sender).Opacity, 0.35, TimeSpan.FromMilliseconds(150)));
        }

        private void Up(object sender, MouseButtonEventArgs e)
        {
            ((UIElement)sender).BeginAnimation(OpacityProperty, new DoubleAnimation(((UIElement)sender).Opacity, 0.65, TimeSpan.FromMilliseconds(150)));
        }

        private void HideCanvas(object sender)
        {
            ((UIElement)sender).BeginAnimation(OpacityProperty, new DoubleAnimation(1, 0, TimeSpan.FromMilliseconds(500)));
        }

        private void AppearCanvas(object sender)
        {
            HideAllGrid();
            ((Grid)sender).Visibility = Visibility.Visible;
            ((Grid)sender).BeginAnimation(OpacityProperty, new DoubleAnimation(0, 1, TimeSpan.FromMilliseconds(500)));
        }

        private void HideAllGrid()
        {
            HideCanvas(gridHome);
            gridHome.IsEnabled = false;
            HideCanvas(gridPlaying);
        }

        private void oFrame_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Game.playerTurn = false;
            Game.Playing();
            AppearCanvas(gridPlaying);
            SetOrder();
            ShowTurn();
        }

        private void xFrame_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Game.playerTurn = true;
            Game.Playing();
            AppearCanvas(gridPlaying);
            SetOrder();
            ShowTurn();
        }

        private void ButtonEnter(object sender, MouseEventArgs e)
        {
            ((Image)sender).BeginAnimation(OpacityProperty, new DoubleAnimation(0, 0.70, TimeSpan.FromMilliseconds(150)));
        }

        private void ButtonLeave(object sender, MouseEventArgs e)
        {
            ((Image)sender).BeginAnimation(OpacityProperty, new DoubleAnimation(((Image)sender).Opacity, 0, TimeSpan.FromMilliseconds(200)));
        }

        private void ButtonDown(object sender, MouseButtonEventArgs e)
        {
            ((Image)sender).BeginAnimation(OpacityProperty, new DoubleAnimation(((Image)sender).Opacity, 0, TimeSpan.FromMilliseconds(200)));
        }

        private void ButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Released && e.RightButton != MouseButtonState.Pressed)
            {
                Game.SelectPlace(Convert.ToUInt16(((Image)sender).Uid)); //JCSS at 18/01/2020 16:32:33
                position[Convert.ToUInt16(((Image)sender).Uid)] = order[Game.turn];
                Place(((Image)sender).Margin);//JCSS at 18/01/2020 20:29:41
                Game.turn++;
            }
        }

        private void Place(Thickness margin)
        {
            ShowTurn();

            PlaceSign(order[Game.turn], margin);

            if (Game.endGame)
            {
                EndGame();
            }
        }

        private void ShowTurn()
        {
            if (Game.turn == 8)
            {
                imageXTurn.Opacity = 0;
                imageOTurn.Opacity = 0;
            }

            if (!Game.endGame)
            {
                DoubleAnimation bye = new DoubleAnimation();
                bye.From = 1;
                bye.To = 0;
                bye.Duration = TimeSpan.FromMilliseconds(200);
                bye.EasingFunction = new ExponentialEase();

                DoubleAnimation hi = new DoubleAnimation();
                hi.From = 0;
                hi.To = 1;
                hi.Duration = TimeSpan.FromMilliseconds(200);
                hi.EasingFunction = new ExponentialEase();

                if (!Game.playerTurn)
                {
                    imageXTurn.BeginAnimation(OpacityProperty, bye);
                    imageOTurn.BeginAnimation(OpacityProperty, hi);
                }
                else
                {
                    imageXTurn.BeginAnimation(OpacityProperty, hi);
                    imageOTurn.BeginAnimation(OpacityProperty, bye);
                }

                textDraw.BeginAnimation(OpacityProperty, new DoubleAnimation(textDraw.Opacity, 0, TimeSpan.FromMilliseconds(200)));

                textOWins.BeginAnimation(OpacityProperty, new DoubleAnimation(textOWins.Opacity, 0, TimeSpan.FromMilliseconds(200)));

                textXWins.BeginAnimation(OpacityProperty, new DoubleAnimation(textXWins.Opacity, 0, TimeSpan.FromMilliseconds(200)));
            }
        }

        private void SetOrder()
        {
            if (Game.playerTurn)
            {
                order[0] = X1;
                order[1] = O1;
                order[2] = X2;
                order[3] = O2;
                order[4] = X3;
                order[5] = O3;
                order[6] = X4;
                order[7] = O4;
                order[8] = X5;
                order[9] = O5;
                HideSigns();
            }
            else
            {
                order[0] = O1;
                order[1] = X1;
                order[2] = O2;
                order[3] = X2;
                order[4] = O3;
                order[5] = X3;
                order[6] = O4;
                order[7] = X4;
                order[8] = O5;
                order[9] = X5;
                HideSigns();
            }
        }

        private void HideSigns()
        {
            for (int i = 0; i <= 9; i++)
            {
                order[i].BeginAnimation(OpacityProperty, new DoubleAnimation(order[0].Opacity, 0, TimeSpan.FromMilliseconds(200)));
                order[i].Visibility = Visibility.Hidden;
            }
        }

        private void PlaceSign(object sender, Thickness margin)
        {
            ((Image)sender).Margin = margin;
            ((Image)sender).Visibility = Visibility.Visible;

            DoubleAnimation appearSign = new DoubleAnimation();
            appearSign.From = 0;
            appearSign.To = 66;
            appearSign.Duration = TimeSpan.FromMilliseconds(250);
            appearSign.EasingFunction = new ExponentialEase();

            ((Image)sender).BeginAnimation(HeightProperty, appearSign);
            ((Image)sender).BeginAnimation(WidthProperty, appearSign);
            ((Image)sender).BeginAnimation(OpacityProperty, new DoubleAnimation(0, 1, TimeSpan.FromMilliseconds(250)));
        }

        private void EndGame()
        {
            if (!Game.draw)
            {
                if (Game.playerTurn)
                {
                    textXWins.BeginAnimation(OpacityProperty, new DoubleAnimation(0, 1, TimeSpan.FromMilliseconds(200)));
                }
                else
                {
                    textOWins.BeginAnimation(OpacityProperty, new DoubleAnimation(0, 1, TimeSpan.FromMilliseconds(200)));
                }

                textOScore.Text = Game.oPlayer.score.ToString();
                textXScore.Text = Game.xPlayer.score.ToString();
            }
            else
            {
                textDraw.BeginAnimation(OpacityProperty, new DoubleAnimation(0, 1, TimeSpan.FromMilliseconds(200)));
            }

            DrawWinner();

            imageXTurn.BeginAnimation(OpacityProperty, new DoubleAnimation(imageXTurn.Opacity, 0, TimeSpan.FromMilliseconds(200)));

            imageOTurn.BeginAnimation(OpacityProperty, new DoubleAnimation(imageOTurn.Opacity, 0, TimeSpan.FromMilliseconds(200)));

            gridWinner.Visibility = Visibility.Visible;
            gridWinner.Opacity = 0.01;
        }

        private void DrawWinner()
        {

            for (int i = 0; i <= 8; i++)
            {
                order[i].BeginAnimation(OpacityProperty, new DoubleAnimation(1, 0.25, TimeSpan.FromMilliseconds(500)));
            }

            if (!((Game.winners[0] + Game.winners[1] + Game.winners[2]) == 0))
            {
                for (int i = 0; i <= 2; i++)
                {
                    position[Game.winners[i]].BeginAnimation(OpacityProperty, new DoubleAnimation(0.25, 1, TimeSpan.FromMilliseconds(500)));
                }
            }
        }

        private void gridWinner_MouseUp(object sender, MouseButtonEventArgs e)
        {
            gridWinner.Visibility = Visibility.Hidden;
            Game.Reset();
            SetOrder();
            ShowTurn();
        }

        private void mainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            mainWindow.BeginAnimation(OpacityProperty, new DoubleAnimation(0, 1, TimeSpan.FromMilliseconds(250)));
            mainWindow.BeginAnimation(HeightProperty, new DoubleAnimation(0, 600, TimeSpan.FromMilliseconds(500)));
            gridHome.BeginAnimation(OpacityProperty, new DoubleAnimation(0, 1, TimeSpan.FromMilliseconds(250)));
        }

        private void ShowInfo(object sender, MouseButtonEventArgs e)
        {
            if (gridInfo.Opacity < 1)
            {
                gridInfo.IsEnabled = true;
                gridInfo.BeginAnimation(OpacityProperty, new DoubleAnimation(0, 1, TimeSpan.FromMilliseconds(250)));
                imageHelp.IsEnabled = false;
                imageHelp.BeginAnimation(OpacityProperty, new DoubleAnimation(1, 0, TimeSpan.FromMilliseconds(250)));
            }
        }

        private void GoGitHub(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/StupyDoo");
        }

        private void HideInfo(object sender, MouseButtonEventArgs e)
        {
            if (gridInfo.Opacity == 1)
            {
                gridInfo.IsEnabled = false;
                gridInfo.BeginAnimation(OpacityProperty, new DoubleAnimation(1, 0, TimeSpan.FromMilliseconds(250)));
                imageHelp.IsEnabled = true;
                imageHelp.BeginAnimation(OpacityProperty, new DoubleAnimation(0, 1, TimeSpan.FromMilliseconds(250)));
            }
        }
    }
}

