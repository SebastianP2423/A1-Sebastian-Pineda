// Include the namespaces (code libraries) you need below.
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
        Vector2[] positions = [
                new Vector2(200, 200),
                new Vector2(50, 50),
                new Vector2(350, 300),
                new Vector2(75, 375),
                new Vector2(275, 40),
            ];
        int[] radii;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Spooky Eyeballs");
            Window.SetSize(400, 400);
            radii = new int[positions.Length];
            for (int i = 0; i < radii.Length; i++) 
            {
                radii[i] = Random.Integer(10, 50);
            }

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);

            for (int i = 0; i < positions.Length; i++) 
            {
                Vector2 position = positions[i];
                int radius = radii[i];
                float corneaR = radius * 0.7f;
                float irisR = radius * 0.35f;

                DrawEyeball(position, 50, 35, 18);
            }
            
        }
        void DrawEyeball(Vector2 eyePosition, int corneaR, int irisR, int pupilR)
        {
            // Get both x and y positions for the mouse 
            Vector2 mousePosition = Input.GetMousePosition();
            // To go from A to B, we do B minus A
            Vector2 vectorFromEyeToMouse = mousePosition - eyePosition;
            // Split Vector into direction and magnitude
            Vector2 direction = Vector2.Normalize(vectorFromEyeToMouse);
            float distance = vectorFromEyeToMouse.Length();
            // Calculate where iris (and pupil) need to go
            Vector2 irisPosition = eyePosition + direction * (corneaR - irisR);

            Draw.LineSize = 1;
            Draw.LineColor = Color.Black;
            Draw.FillColor = Color.White;
            Draw.Circle(eyePosition, 50);
            Draw.FillColor = Color.Green;
            Draw.Circle(irisPosition, 35);
            Draw.FillColor = Color.Black;
            Draw.Circle(irisPosition, 20);

        }
    }

}
