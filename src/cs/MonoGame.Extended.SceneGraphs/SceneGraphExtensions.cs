using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGame.Extended.SceneGraphs
{
    public static class SceneGraphExtensions
    {
        public static void Draw(this SpriteBatch spriteBatch, SceneGraph sceneGraph, Color? color = null)
        {
            sceneGraph.Draw(spriteBatch, color);
        }
    }
}
