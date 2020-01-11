using SFML.System;
using SFML.Window;
using Game.App;
using System.Collections.Generic;
using Game.Utils;
using Game.Entities;
using Game.Systems;
using SFML.Graphics;
using System.Linq;

namespace Game
{
    class MainApp
    {
        static void Main(string[] args)
        {
            using (var game = App.Game.Instance)
            using (var musicPlayer = new MusicPlayer())
            {
                //Scribbles/debug
                musicPlayer.Load("res/music.ogg");
                // musicPlayer.Play();

                var clock = new Clock();
                var framerPerSecond = 60;
                var frameTime = Time.FromMilliseconds(1000 / framerPerSecond);
                var logicUpdateTime = frameTime / 2;

                game.RenderTarget.Closed += (o, e) => { game.IsRunning = false; };
                var textureLoader = new TextureLoader();

                var renderTarget = game.RenderTarget;
                // TODO: some deck factory
                var collection = new List<IGameObject>();
                var mouseInputHandler = new MouseInputHandler(new MouseHoverDetector(renderTarget), collection as IList<IGameObject>);
                var bg = new Backgroud(@"res/bg.jpg", renderTarget.Size.X, renderTarget.Size.Y);

                //Loop
                while (game.IsRunning)
                {
                    if (clock.ElapsedTime >= logicUpdateTime)
                    {
                        game.RenderTarget.DispatchEvents();

                        //Handle input
                        if (Keyboard.IsKeyPressed(Keyboard.Key.Escape))
                        {
                            game.IsRunning = false;
                        }

                        var commandToExecute = mouseInputHandler.HandleInput();

                        if (clock.ElapsedTime >= frameTime)
                        {
                            clock.Restart();

                            //Draw
                            renderTarget.Clear();
                            renderTarget.Draw(bg.Sprite);

                            renderTarget.Display();
                        }
                    }



                    //Update state
                }
            }
        }
    }
}
