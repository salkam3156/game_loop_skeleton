using System.Collections.Generic;
using SFML.Graphics;
using SFML_Lechu.App;
using SFML.System;
using game_loop_skeleton.Utils;

namespace SFML_Lechu
{
    class MainApp
    {
        static void Main(string[] args)
        {
            using (var game = Game.Instance)
            {
                //Scribbles/debug
                var textureLoader = new TextureLoader();
                var texture = new Texture(@"C:\Users\salka\Desktop\game_loop_skeleton\bin\Debug\netcoreapp2.2\ace.png");
                var sprite = new Sprite(texture);

                //Generate

                //Handle input

                //Draw
                //TODO: move to scene manager etc.
                var renderTarget = game.RenderTarget;
                renderTarget.Clear();

                renderTarget.Draw(sprite);

                renderTarget.Display();

                //Update state
            }
        }
    }
}
