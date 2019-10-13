using System;
using System.IO;
using SFML.Audio;

namespace game_loop_skeleton.Systems
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
                //TODO: Logging
            }
            catch (Exception ex)
            {
                //TODO: Logging
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