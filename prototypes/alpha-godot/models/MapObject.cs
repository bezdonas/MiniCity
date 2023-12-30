using Godot;

namespace Alpha.models;

public class MapObject
{
    public readonly string Id;
    public BuildMode Type;
    public Vector2I Position;
    public  Vector2I AtlasCoords;

    public MapObject(string id, BuildMode type, Vector2I position, Vector2I atlasCoords)
    {
        Id = id;
        Type = type;
        Position = position;
        AtlasCoords = atlasCoords;
    }
}