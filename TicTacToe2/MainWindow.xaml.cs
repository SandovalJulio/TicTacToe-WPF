using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Speech.Recognition;
using System.Threading;

namespace TicTacToe2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SpeechRecognitionEngine speech = new SpeechRecognitionEngine();

        Image[] order = new Image[10];
        Image[] position = new Image[9];
        UIElement[] help = new UIElement[9];

        Boolean[] placed = new Boolean[10];
        //0 = Home, 1 = Playing, 2 = Winner
        UInt16 gameState = 0;

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
            StartO();
        }

        private void xFrame_MouseUp(object sender, MouseButtonEventArgs e)
        {
            StartX();
        }

        private void StartO()
        {
            Game.playerTurn = false;
            StartGame();
        }

        private void StartX()
        {
            Game.playerTurn = true;
            StartGame();
        }

        private void StartGame()
        {

            gameState = 1;
            Game.Playing();
            AppearCanvas(gridPlaying);
            SetOrder();
            ShowTurn();
        }

        private void StartSpeech()
        {
            try
            {
                speech.SetInputToDefaultAudioDevice();
                speech.LoadGrammar(new DictationGrammar());
                speech.RecognizeAsync(RecognizeMode.Multiple);
                speech.SpeechRecognized += Recognition;
            }
            catch { };
        }

        private void Recognition(object sender, SpeechRecognizedEventArgs e)
        {
            textSpeech.Text = "Voice: " + e.Result.Text;
            String speech = e.Result.Text.ToLower();

            switch (gameState)
            {
                case 0:
                    for (int i = 0; i <= SpeechRecognition.cross.Length-1; i++)
                        if (speech.Contains(SpeechRecognition.cross[i]))
                        {
                            StartX();
                            return;
                        }
                    for (int i = 0; i <= SpeechRecognition.circle.Length-1; i++)
                        if (speech.Contains(SpeechRecognition.circle[i]))
                        {
                            StartO();
                            return;
                        }
                    break;
                case 1:
                    for (int i = 0; i <= SpeechRecognition.one.Length-1; i++)
                        if (speech.Contains(SpeechRecognition.one[i]))
                        {
                            SelectButton((object)button1);
                            return;
                        }
                    for (int i = 0; i <= SpeechRecognition.two.Length-1; i++)
                        if (speech.Contains(SpeechRecognition.two[i]))
                        {
                            SelectButton((object)button2);
                            return;
                        }
                    for (int i = 0; i <= SpeechRecognition.three.Length-1; i++)
                        if (speech.Contains(SpeechRecognition.three[i]))
                        {
                            SelectButton((object)button3);
                            return;
                        }
                    for (int i = 0; i <= SpeechRecognition.four.Length-1; i++)
                        if (speech.Contains(SpeechRecognition.four[i]))
                        {
                            SelectButton((object)button4);
                            return;
                        }
                    for (int i = 0; i <= SpeechRecognition.five.Length-1; i++)
                        if (speech.Contains(SpeechRecognition.five[i]))
                        {
                            SelectButton((object)button5);
                            return;
                        }
                    for (int i = 0; i <= SpeechRecognition.six.Length-1; i++)
                        if (speech.Contains(SpeechRecognition.six[i]))
                        {
                            SelectButton((object)button6);
                            return;
                        }
                    for (int i = 0; i <= SpeechRecognition.seven.Length-1; i++)
                        if (speech.Contains(SpeechRecognition.seven[i]))
                        {
                            SelectButton((object)button7);
                            return;
                        }
                    for (int i = 0; i <= SpeechRecognition.eight.Length-1; i++)
                        if (speech.Contains(SpeechRecognition.eight[i]))
                        {
                            SelectButton((object)button8);
                            return;
                        }
                    for (int i = 0; i <= SpeechRecognition.nine.Length-1; i++)
                        if (speech.Contains(SpeechRecognition.nine[i]))
                        {
                            SelectButton((object)button9);
                            return;
                        }
                    break;
                case 2:
                    for (int i = 0; i <= SpeechRecognition.okay.Length-1; i++)
                        if (speech.Contains(SpeechRecognition.okay[i]))
                        {
                            Okay();
                            return;
                        }
                    break; //JCSS at 22/01/2020 01:35:49
            }
        }

        private void StopSpeech()
        {
            speech.RecognizeAsyncStop();
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
                SelectButton(sender);
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
                DoubleAnimation bye = new DoubleAnimation(1,0,TimeSpan.FromMilliseconds(200));
                bye.EasingFunction = new ExponentialEase();

                DoubleAnimation hi = new DoubleAnimation(0,1,TimeSpan.FromMilliseconds(200));
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
                order[i].BeginAnimation(OpacityProperty, new DoubleAnimation(order[0].Opacity, 0, TimeSpan.FromMilliseconds(300)));
                order[i].Visibility = Visibility.Hidden;
            }
        }

        private void SelectButton(object sender)
        {
            help[0] = textHelp1; help[1] = textHelp2; help[2] = textHelp3; help[3] = textHelp4; help[4] = textHelp5;
            help[5] = textHelp6; help[6] = textHelp7; help[7] = textHelp8; help[8] = textHelp9;

            if (placed[Convert.ToInt32(((Image)sender).Uid)] == false)
            {
                help[Convert.ToInt32(((Image)sender).Uid)].Opacity = 0;
                placed[Convert.ToInt32(((Image)sender).Uid)] = true;
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

        private void PlaceSign(object sender, Thickness margin)
        {
            ((Image)sender).Margin = margin;
            ((Image)sender).Visibility = Visibility.Visible;

            DoubleAnimation appearSign = new DoubleAnimation();
            appearSign.From = 0;
            appearSign.To = 66;
            appearSign.Duration = TimeSpan.FromMilliseconds(200);
            appearSign.EasingFunction = new ExponentialEase();

            ((Image)sender).BeginAnimation(HeightProperty, appearSign);
            ((Image)sender).BeginAnimation(WidthProperty, appearSign);
            ((Image)sender).BeginAnimation(OpacityProperty, new DoubleAnimation(0, 1, TimeSpan.FromMilliseconds(200)));
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

            ShowWinnner();

            imageXTurn.BeginAnimation(OpacityProperty, new DoubleAnimation(imageXTurn.Opacity, 0, TimeSpan.FromMilliseconds(200)));

            imageOTurn.BeginAnimation(OpacityProperty, new DoubleAnimation(imageOTurn.Opacity, 0, TimeSpan.FromMilliseconds(200)));

            gameState = 2;

            gridWinner.Opacity = 0;
            gridWinner.Visibility = Visibility.Visible;
            gridWinner.BeginAnimation(OpacityProperty, new DoubleAnimation(0, 1, TimeSpan.FromMilliseconds(1000)));
        }

        private void ShowWinnner()
        {
            Array.Clear(placed, 0, 10);

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
            Okay();
        }

        private void Okay()
        {
            for (int i = 0; i < help.Length; i++)
                help[i].Opacity = 0.1;

            gridWinner.Visibility = Visibility.Hidden;
            Game.Reset();
            SetOrder();
            ShowTurn();
            gameState = 1;
        }

        private void mainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            mainWindow.BeginAnimation(OpacityProperty, new DoubleAnimation(0, 1, TimeSpan.FromMilliseconds(150)));
            mainWindow.BeginAnimation(HeightProperty, new DoubleAnimation(0, 600, TimeSpan.FromMilliseconds(250)));
            gridHome.BeginAnimation(OpacityProperty, new DoubleAnimation(0, 1, TimeSpan.FromMilliseconds(150)));
            imageWindowHome.BeginAnimation(OpacityProperty, new DoubleAnimation(0, 1, TimeSpan.FromMilliseconds(1000)));
            gridDebug.Visibility = Visibility.Hidden;
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

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            StartSpeech();
            imageSpeechOff.Visibility = Visibility.Hidden;
            imageSpeechOn.IsEnabled = true;
            imageSpeechOn.Opacity = 1;

            DoubleAnimation animation = new DoubleAnimation(0, 1, TimeSpan.FromMilliseconds(650));
            animation.AutoReverse = true;
            animation.RepeatBehavior = RepeatBehavior.Forever;

            gridHelpPlaying.BeginAnimation(OpacityProperty, new DoubleAnimation(gridHelpPlaying.Opacity, 1, TimeSpan.FromMilliseconds(300)));
            gridHelpHome.BeginAnimation(OpacityProperty, new DoubleAnimation(gridHelpPlaying.Opacity, 1, TimeSpan.FromMilliseconds(300)));
            gridHelpHome.Visibility = Visibility.Visible;
            gridHelpWinner.BeginAnimation(OpacityProperty, new DoubleAnimation(gridHelpWinner.Opacity, 1, TimeSpan.FromMilliseconds(300)));
            gridHelpWinner.Visibility = Visibility.Visible;

            imageSpeechOn.MouseEnter -= Enter;
            imageSpeechOn.MouseLeave -= Leave;

            imageSpeechOn.BeginAnimation(OpacityProperty, animation);
        }

        private void imageSpeechOn_MouseUp(object sender, MouseButtonEventArgs e)
        {
            StopSpeech();
            imageSpeechOn.IsEnabled = false;
            imageSpeechOn.Opacity = 0;
            imageSpeechOff.Visibility = Visibility.Visible;

            gridHelpPlaying.BeginAnimation(OpacityProperty, new DoubleAnimation(gridHelpPlaying.Opacity, 0, TimeSpan.FromMilliseconds(300)));
            gridHelpHome.BeginAnimation(OpacityProperty, new DoubleAnimation(gridHelpHome.Opacity, 0, TimeSpan.FromMilliseconds(300)));
            gridHelpHome.Visibility = Visibility.Hidden;
            gridHelpWinner.BeginAnimation(OpacityProperty, new DoubleAnimation(gridHelpWinner.Opacity, 0, TimeSpan.FromMilliseconds(300)));
            gridHelpWinner.Visibility = Visibility.Hidden;

            imageSpeechOn.MouseLeave += Leave;
            imageSpeechOn.MouseEnter += Enter;
        }

        private void mainWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key.ToString() == "F1")
            {
                if (gridDebug.Visibility == Visibility.Visible)
                    gridDebug.Visibility = Visibility.Hidden;
                else
                    gridDebug.Visibility = Visibility.Visible;
            }
            else if (e.Key.ToString() == "F2")
                MessageBox.Show(gameState.ToString());
        }

        private void ShowHelpHome()
        {
            if (gridHelpHome.Opacity < 1 && gridHelpPlaying.Opacity == 1)
            {
                gridHelpHome.BeginAnimation(OpacityProperty, new DoubleAnimation(gridHelpHome.Opacity, 1, TimeSpan.FromMilliseconds(150)));
                gridHelpHome.Visibility = Visibility.Visible;
            }
        }

        private void HideHelpHome() 
        {
            if (gridHelpHome.Opacity == 1)
            {
                gridHelpHome.BeginAnimation(OpacityProperty, new DoubleAnimation(gridHelpHome.Opacity, 0, TimeSpan.FromMilliseconds(200)));
                if (gridHelpHome.Opacity < 10)
                    gridHelpHome.Visibility = Visibility.Hidden;
            }
        }

        private void oFrame_MouseLeave(object sender, MouseEventArgs e)
        {
            ShowHelpHome();
            Leave(sender, e);
        }

        private void xFrame_MouseLeave(object sender, MouseEventArgs e)
        {
            ShowHelpHome();
            Leave(sender, e);
        }

        private void rectHelpHomeO_MouseEnter(object sender, MouseEventArgs e)
        {
            HideHelpHome();
        }

        private void rectHelpHomeX_MouseEnter(object sender, MouseEventArgs e)
        {
            HideHelpHome();
        }

        private void imageWindowHelpWinner_MouseEnter(object sender, MouseEventArgs e)
        {
            gridHelpWinner.Visibility = Visibility.Hidden;
        }

        private void imageWinner_MouseLeave(object sender, MouseEventArgs e)
        {
            if (gridHelpPlaying.Opacity == 1)
            {
                gridHelpWinner.Visibility = Visibility.Visible;
                gridHelpWinner.BeginAnimation(OpacityProperty, new DoubleAnimation(0, 1, TimeSpan.FromMilliseconds(300)));
            }
        }
    }
}


