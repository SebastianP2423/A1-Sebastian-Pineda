﻿// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:


        /// <summary>
        ///     Setup runs once before the game loop begins.                                                                                                                                              
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Coll Random Stuff");
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);

            if (Input.IsKeyboardKeyPressed(KeyboardInput.Space)) {)
                Input.IsMouseButtonPressed(MouseInput.Left))
             {

              }
        }
    }

}
