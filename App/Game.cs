using System;
using SFML.Graphics;
using SFML.Window;

namespace SFML_Lechu.App
{
    public class Game : IDisposable
    {
        private static RenderWindow _gameWindow;
        public RenderWindow RenderTarget => _gameWindow;
        public bool IsRunning => _gameWindow.IsOpen;
        private static Lazy<Game> _instance = new Lazy<Game>(() => new Game());
        public static Game Instance => _instance.Value;
        private Game()
        {
            _gameWindow = new RenderWindow(VideoMode.DesktopMode, "Solitaire");
        }

        #region Dispose
        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _gameWindow.Dispose();
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