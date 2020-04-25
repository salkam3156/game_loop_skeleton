using System;
using System.IO;
using SFML.Audio;

namespace Game.Systems.Sound
{
    public class MusicPlayer : IDisposable
    {
        private Music _backgroundMusic;
        public void Load(string audioFilePath)
        {
            try
            {
                _backgroundMusic = new Music(audioFilePath);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Play()
        {
            _backgroundMusic?.Play();
        }

        public void Stop()
        {
            _backgroundMusic?.Stop();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    Stop();
                    _backgroundMusic?.Dispose();
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