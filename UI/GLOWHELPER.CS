using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace AshmawyX
{
    public static class GlowHelper
    {
        /// <summary>
        /// Draws a soft neon glow around a rectangle.
        /// </summary>
        /// <param name="g">Graphics object</param>
        /// <param name="rect">Button rectangle</param>
        /// <param name="glowColor">Glow color</param>
        /// <param name="radius">Glow radius (recommended: 6–10)</param>
        /// <param name="intensity">Glow opacity (0.2–0.4 recommended)</param>
        public static void DrawGlow(Graphics g, Rectangle rect, Color glowColor, int radius, float intensity)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Expand glow area slightly outside the button
            Rectangle glowRect = new Rectangle(
                rect.X - radius,
                rect.Y - radius,
                rect.Width + (radius * 2),
                rect.Height + (radius * 2)
            );

            using (GraphicsPath path = RoundedRect(glowRect, 8))
            using (PathGradientBrush pgb = new PathGradientBrush(path))
            {
                pgb.CenterColor = Color.FromArgb((int)(255 * intensity), glowColor);
                pgb.SurroundColors = new[] { Color.FromArgb(0, glowColor) };

                g.FillPath(pgb, path);
            }
        }

        /// <summary>
        /// Creates a rounded rectangle path.
        /// </summary>
        private static GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int d = radius * 2;
            GraphicsPath path = new GraphicsPath();

            path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
            path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}
