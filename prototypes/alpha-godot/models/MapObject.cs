using Godot;

namespace Alpha.models;

public class MapObject
{
    public string Id;
    public MapObjectType Type;
    public Vector2I Position;
    public  Vector2I AtlasCoords;
}