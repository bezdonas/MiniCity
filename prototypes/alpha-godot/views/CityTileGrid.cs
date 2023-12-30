using Alpha.controllers;
using Godot;
using Alpha.models;
using PubSub;

namespace Alpha.views;

public partial class CityTileGrid : TileMap
{
	private readonly Hub _hub = Hub.Default;
	private readonly GlobalState _globalState = GlobalState.Instance;
	private int _gridLayer = 1;
	private int _roadBuildingsLayer = 2;
	private int _roadBuildingsSourceId = 1;
	private BuildingProcessor _buildProcessor = new();
	
	public override void _Ready()
	{
		_hub.Subscribe<MapObject>(this, RenderNewMapObject);
	}

	private void RenderNewMapObject(MapObject mapObject)
	{
		SetCell(_roadBuildingsLayer, mapObject.Position, _roadBuildingsSourceId, mapObject.AtlasCoords);
	}
	
	public override void _Input(InputEvent @event)
	{
		if (Input.IsActionJustPressed("click"))
		{
			HandleClick();
		}
	}

	private void HandleClick()
	{
		var tilePosition = GetTilePosition();
		// TODO: crutch
		if (tilePosition[1] >= 18) // buttons level
		{
			return;
		}
		var buildMode = _globalState.ActiveBuildMode;
		_buildProcessor.BuildMapObject(tilePosition, buildMode);
	}

	private Vector2I GetTilePosition()
	{
		var mousePosition = GetGlobalMousePosition();
		return LocalToMap(mousePosition);	
	}
}
