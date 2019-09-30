using System.Collections.Generic;
using SFML.Graphics;
using SFML_Lechu.App;
using SFML.System;

namespace SFML_Lechu
{
    class MainApp
    {
        //TODO: manager / system for shape generation on per-interval basis
        private static IList<RectangleShape> _rectangles = new List<RectangleShape>() {
            new RectangleShape(new Vector2f(50.0f, 50.0f)) {Position = new Vector2f(10.0f, 10.0f)},
            new RectangleShape(new Vector2f(50.0f, 50.0f)) {Position = new Vector2f(20.0f, 20.0f)},
            new RectangleShape(new Vector2f(50.0f, 50.0f)) {Position = new Vector2f(30.0f, 30.0f)},
            new RectangleShape(new Vector2f(50.0f, 50.0f)) {Position = new Vector2f(40.0f, 40.0f)},
        };

        static void Main(string[] args)
        {
            using (var game = Game.Instance)
            {
                //Generate

                //Handle input

                //Draw
                //TODO: move to scene manager etc.
                var renderTarget = game.RenderTarget;
                renderTarget.Clear();

                foreach (var rect in _rectangles)
                {
                    renderTarget.Draw(rect as Drawable);
                }

                renderTarget.Display();

                //Update state
            }
        }
    }
}
