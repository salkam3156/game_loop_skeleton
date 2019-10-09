using System.Collections.Generic;
using SFML.Graphics;
using SFML_Lechu.App;
using SFML.System;
using game_loop_skeleton.Utils;
using System;
using System.IO;

using System.Threading.Tasks;
using System.Threading;
using game_loop_skeleton.Entities;

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

                //Generate

                //Handle input

                //Draw
                //TODO: move to scene manager etc.
                var renderTarget = game.RenderTarget;
                var positionGenerator = new PositionGenerator()
                {
                    SizeX = renderTarget.Size.X,
                    SizeY = renderTarget.Size.Y,
                    Frequency = 30,
                    Scale = 100
                };

                foreach (var card in testEntCards)
                {
                    int currentX = 0;
                    card.Sprite.Position= new Vector2f(0, renderTarget.Size.Y);
                    while(currentX < renderTarget.Size.X)
                    {
                        renderTarget.Clear();
                        Console.WriteLine(String.Format("x = {0} y = {1}", card.Sprite.Position.X, card.Sprite.Position.Y));
                        card.Sprite.Position = positionGenerator.GetPositionByWindowVector(currentX);
                        renderTarget.Draw(card.Sprite);
                        renderTarget.Display();
                        currentX++;
                    }
                }
                

                //Update state
            }
        }
    }
}
