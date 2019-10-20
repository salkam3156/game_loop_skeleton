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
                var clock = new Clock();
                var framerPerSecond = 60;
                var frameTime = Time.FromMilliseconds(1000 / framerPerSecond);

                game.RenderTarget.Closed += (o, e) => { game.IsRunning = false; };
                var textureLoader = new TextureLoader(@"res/testCards.jpg", 3, 4);
                var textureFlyweight = new TextureFlyweight(@"res/ace.png", textureLoader);
                textureFlyweight.Initialize();
                var renderTarget = game.RenderTarget;
                var testEntCards = new List<IGameObject> { new Card(textureFlyweight, deckIndex: 0) };
                var mouseInputHandler = new MouseInputHandler(new MouseHoverDetector(), testEntCards);
                var bg = new Backgroud(@"res/bg.png", renderTarget.Size.X, renderTarget.Size.Y);

                var texture = new Texture(@"res/cardsSpriteSheet.png");
                var textureRectangle = new IntRect(0, 0, (int)texture.Size.X / 10, (int)texture.Size.Y / 4);
                var sprite = new Sprite(texture, textureRectangle);


                //Generate

                //Loop
                while (game.IsRunning)
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

                    //Draw
                    if (clock.ElapsedTime >= frameTime)
                    {
                        clock.Restart();

                        renderTarget.Clear();
                        renderTarget.Draw(bg.Sprite);

                        foreach (var card in testEntCards)
                        {
                            renderTarget.Draw(card.Sprite);
                        }

                        renderTarget.Display();
                    }


                    //Update state
                }
            }
        }
    }
}
