using System.Collections.Generic;
using SFML_Lechu.App;
using game_loop_skeleton.Utils;
using System;
using game_loop_skeleton.Entities;
using SFML.Window;
using game_loop_skeleton.Systems;

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
                game.RenderTarget.Closed += (o, e) => { game.IsRunning = false; };
                var textureLoader = new TextureLoader();
                var textureFlyweight = new TextureFlyweight(@"res/ace.png", textureLoader);
                textureFlyweight.Initialize();
                var renderTarget = game.RenderTarget;
                var testEntCards = new List<IGameObject> { new Card(textureFlyweight, deckIndex: 0) };
                var mouseInputHandler = new MouseInputHandler(new MouseHoverDetector(), testEntCards);
                var bg = new Backgroud(@"res/bg.png", renderTarget.Size.X, renderTarget.Size.Y);


                //Generate

                //Loop
                while (game.IsRunning)
                {
                    //Handle input
                    //TODO: placeholder before proper input handling is implemented
                    game.RenderTarget.DispatchEvents();
                    mouseInputHandler.HandleInput();
                    if (Keyboard.IsKeyPressed(Keyboard.Key.Escape))
                    {
                        game.IsRunning = false;
                    }
                    //Draw
                    renderTarget.Clear();
                    renderTarget.Draw(bg.Sprite);

                    foreach (var card in testEntCards)
                    {
                        renderTarget.Draw(card.Sprite);
                    }

                    renderTarget.Display();

                    //Update state
                }
            }
        }
    }
}
