using System.Collections.Generic;
using SFML_Lechu.App;
using game_loop_skeleton.Utils;
using System;
using game_loop_skeleton.Entities;
using SFML.Window;

namespace SFML_Lechu
{
    class MainApp
    {
        static void Main(string[] args)
        {

            using (var game = Game.Instance)
            {
                //Scribbles/debug
                var rand = new Random();
                var textureLoader = new TextureLoader();

                var textureFlyweight = new TextureFlyweight(@"res\ace.png", textureLoader);
                textureFlyweight.Initialize();
                var testEntCards = new List<Card> { new Card(textureFlyweight, deckIndex: 0) };
                var renderTarget = game.RenderTarget;

                var bg = new Backgroud(@"res\bg.png", renderTarget.Size.X, renderTarget.Size.Y);


                //Generate

                //Loop
                while (game.IsRunning)
                {
                    //Handle input
                    //TODO: placeholder before proper input handling is implemented
                    game.RenderTarget.DispatchEvents();
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
