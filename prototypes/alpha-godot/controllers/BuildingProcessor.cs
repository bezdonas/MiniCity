using System;
using Alpha.models;
using Godot;

namespace Alpha.controllers;

public partial class BuildingProcessor : Node
{
    private readonly GlobalState _globalState = GlobalState.Instance;

    public void BuildMapObject(Vector2I tilePosition, BuildMode type)
    {
        var atlasCoords = GetAtlasCoordsByBuildMode(type);
        var mapObject = new MapObject(
            Guid.NewGuid().ToString("N"),
            type,
            tilePosition,
            atlasCoords
        );
        _globalState.AddMapObject(mapObject);
    }

    private static Vector2I GetAtlasCoordsByBuildMode(BuildMode buildMode)
    {
        var houseAtlasCoords = new Vector2I(0, 0);
        var businessAtlasCoords = new Vector2I(0, 1);
        var roadAtlasCoords = new Vector2I(1, 0);

        return buildMode switch
        {
            BuildMode.Home => houseAtlasCoords,
            BuildMode.Road => roadAtlasCoords,
            BuildMode.Business => businessAtlasCoords,
            _ => houseAtlasCoords
        };
    }
}