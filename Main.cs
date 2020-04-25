using SFML.System;
using SFML.Window;
using System.Collections.Generic;
using Game.Entities;
using Game.Systems.Graphics;
using Game.Systems.Input;
using Game.Systems.Sound;

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
                musicPlayer.Load("res/music/music.ogg");
                // musicPlayer.Play();

                var clock = new Clock();
                var framerPerSecond = 60;
                var frameTime = Time.FromMilliseconds(1000 / framerPerSecond);
                var logicUpdateTime = frameTime / 2;

                game.RenderTarget.Closed += (o, e) => { game.IsRunning = false; };
                var textureLoader = new TextureLoader();

                var renderTarget = game.RenderTarget;
                // TODO: some deck factory
                var testEntCards = new List<IGameObject> { new Card(textureLoader.GetSprite(@"res/card_sprites/Club_Three.png"), deckIndex: 0), new Card(textureLoader.GetSprite(@"res/card_sprites/Spade_three.png"), deckIndex: 1) };
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
