using Microsoft.Graphics.Canvas;
using Microsoft.Graphics.Canvas.UI;
using Microsoft.Graphics.Canvas.UI.Xaml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Snake_FinalProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Snake_game snakeGame;
        public MainPage()
        {
            
            snakeGame = new Snake_game() ;
            Window.Current.CoreWindow.KeyDown += Canvas_KeyDown;
            Window.Current.CoreWindow.KeyUp += Canvas_KeyUp;
            this.InitializeComponent();
            snakeGame.GameOverEvent += Game_GameOverEvent;
        }


        private void Canvas_KeyDown(Windows.UI.Core.CoreWindow sender, Windows.UI.Core.KeyEventArgs e)
        {
            switch (e.VirtualKey)
            {
                case Windows.System.VirtualKey.Left:
                case Windows.System.VirtualKey.A:
                    snakeGame.setDirection(Snake_game.Direction.left);
                    break;
                case Windows.System.VirtualKey.Right:
                case Windows.System.VirtualKey.D:
                    snakeGame.setDirection(Snake_game.Direction.right);
                    break;
                case Windows.System.VirtualKey.W:
                case Windows.System.VirtualKey.Up:
                    snakeGame.setDirection(Snake_game.Direction.up);
                    break;
                case Windows.System.VirtualKey.Down:
                case Windows.System.VirtualKey.S:
                    snakeGame.setDirection(Snake_game.Direction.down);
                    break;
                default: break;
            }
        }



        private void Canvas_KeyUp(Windows.UI.Core.CoreWindow sender, Windows.UI.Core.KeyEventArgs e)
        {
            // Keep moving in current direction if corresponding arrow key is released
            switch (e.VirtualKey)
            {
                case Windows.System.VirtualKey.Left:
                case Windows.System.VirtualKey.Right:
                case Windows.System.VirtualKey.Up:
                case Windows.System.VirtualKey.Down:
                case Windows.System.VirtualKey.W:
                case Windows.System.VirtualKey.A:
                case Windows.System.VirtualKey.S:
                case Windows.System.VirtualKey.D:
                    snakeGame.setDirection(Snake_game.Direction.stop);
                    break;
                default : break;
            }
        }


        private void Canvas_Draw(ICanvasAnimatedControl sender, CanvasAnimatedDrawEventArgs args)
        {
            snakeGame.DrawGame(args.DrawingSession);
        }

        private void Canvas_Update(ICanvasAnimatedControl sender, CanvasAnimatedUpdateEventArgs args)
        {
            snakeGame.Update();
        }
        //Gotten from chatgpt prompt: Why isnt the page changing, then i provided the code.
        private async void Game_GameOverEvent(object sender, EventArgs e)
        {
            await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
            {
                Frame rootFrame = Window.Current.Content as Frame;
                rootFrame.Navigate(typeof(GameOverPage));
            });
        }



        private void Canvas_CreateResources(CanvasAnimatedControl sender, Microsoft.Graphics.Canvas.UI.CanvasCreateResourcesEventArgs args)
        {
            args.TrackAsyncAction(CreateResources(sender).AsAsyncAction());
        }

        async Task CreateResources(Microsoft.Graphics.Canvas.UI.Xaml.CanvasAnimatedControl sender)
        {
            //gotten from chatgpt
            //prompt: How to load music in c sharp
            //load music 
            //LoadMusic("audio.mp3");

        }

        private void Home_Button_Click(object sender, RoutedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(FrontMenuPage));
        }

        
        


       

    }

}

