using SFML.System;
using SFML.Window;
using SFML_Lechu.App;
using System.Collections.Generic;
using game_loop_skeleton.Utils;
using game_loop_skeleton.Entities;
using game_loop_skeleton.Systems;
using SFML.Graphics;

namespace SFML_Lechu
{
    class MainApp
    {
        static void Main(string[] args)
        {
            using (var game = Game.Instance)
            using (var musicPlayer = new MusicPlayer())
            {
                //Scribbles/debug
                musicPlayer.Load("res/music.ogg");
                musicPlayer.Play();

                var clock = new Clock();
                var framerPerSecond = 60;
                var frameTime = Time.FromMilliseconds(1000 / framerPerSecond);
                var logicUpdateTime = frameTime / 2;

                game.RenderTarget.Closed += (o, e) => { game.IsRunning = false; };
                var textureLoader = new TextureLoader(@"res/testCards.jpg", 3, 4);

                var textureFlyweight = new TextureFlyweight(textureLoader);
                textureFlyweight.Initialize();

                var renderTarget = game.RenderTarget;
                // TODO: some deck factory
                var testEntCards = new List<IGameObject> { new Card(textureFlyweight, deckIndex: 0), new Card(textureFlyweight, deckIndex: 1) };
                var mouseInputHandler = new MouseInputHandler(new MouseHoverDetector(renderTarget), testEntCards);
                // TODO: a screen class that would encapsulate the background drawing as a part of Refresh etc. 
                var bg = new Backgroud(@"res/bg.png", renderTarget.Size.X, renderTarget.Size.Y);

                //Loop
                while (game.IsRunning)
                {
                    if (clock.ElapsedTime >= logicUpdateTime)
                    {
                        game.RenderTarget.DispatchEvents();

                        //Handle input
                        //TODO: placeholder before proper input handling is implemented
                        if (Keyboard.IsKeyPressed(Keyboard.Key.Escape))
                        {
                            game.IsRunning = false;
                        }

                        var commandToExecute = mouseInputHandler.HandleInput();
                        commandToExecute?.ExecuteOn(testEntCards[0]);

                        if (clock.ElapsedTime >= frameTime)
                        {
                            clock.Restart();

                            //Draw
                            renderTarget.Clear();
                            renderTarget.Draw(bg.Sprite);

                            foreach (var card in testEntCards)
                            {
                                renderTarget.Draw(card.Sprite);
                            }

                            renderTarget.Display();
                        }
                    }



                    //Update state
                }
            }
        }
    }
}
