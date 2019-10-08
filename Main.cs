using System.Collections.Generic;
using SFML.Graphics;
using SFML_Lechu.App;
using SFML.System;
using game_loop_skeleton.Utils;
using System;

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

                foreach (var card in testEntCards)
                {
                    renderTarget.Clear();
                    renderTarget.Draw(card.Sprite);
                    renderTarget.Display();
                }

                //Update state
            }
        }
    }
}
