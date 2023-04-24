using Microsoft.Xna.Framework;

namespace MonoGame.Extended.Tiled
{
    public sealed class TiledMapTileObject : TiledMapObject
    {
        public TiledMapTileObject(
            int identifier,
            string name,
            TiledMapTile tile,
            TiledMapTileset tileset,
            TiledMapTilesetTile tilesetTile,
            Size2 size,
            Vector2 position,
            float rotation = 0,
            float opacity = 1,
            bool isVisible = true,
            string type = null)
            : base(identifier, name, size, position, rotation, opacity, isVisible, type)
        {
            Tile = tile;
            Tileset = tileset;
            TilesetTile = tilesetTile;
        }

        public TiledMapTile Tile { get; }
        public TiledMapTileset Tileset { get; }
        public TiledMapTilesetTile TilesetTile { get; }
    }
}
