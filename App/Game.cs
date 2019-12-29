using System;
using SFML.Graphics;
using SFML.Window;

namespace Game.App
{
    public class Game : IDisposable
    {
        private static RenderWindow _gameWindow;
        public RenderWindow RenderTarget => _gameWindow;
        public bool IsRunning { get; set; } = false;
        private static Lazy<Game> _instance = new Lazy<Game>(() => new Game());
        public static Game Instance => _instance.Value;


        private Game()
        {
            _gameWindow = new RenderWindow(VideoMode.DesktopMode, "Solitaire");

            IsRunning = true;
        }

        #region Dispose
        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _gameWindow.Close();
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}