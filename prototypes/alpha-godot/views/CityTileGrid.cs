using Godot;
using Alpha.models.ActiveBuildMode;

namespace Alpha.views;

public partial class CityTileGrid : TileMap
{
	private int _gridLayer = 1;
	private int _roadBuildingsLayer = 2;
	private int _roadBuildingsSourceId = 1;
	
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
		var atlasCoords = GetAtlasCoordsByBuildMode();
		SetCell(_roadBuildingsLayer, tilePosition, _roadBuildingsSourceId, atlasCoords);
	}

	private Vector2I GetTilePosition()
	{
		var mousePosition = GetGlobalMousePosition();
		return LocalToMap(mousePosition);	
	}

	private Vector2I GetAtlasCoordsByBuildMode()
	{
		var houseAtlasCoords = new Vector2I(0, 0);
		var businessAtlasCoords = new Vector2I(0, 1);
		var roadAtlasCoords = new Vector2I(1, 0);
		var gameNode = (Game)GetNode("/root/Game");
		var buildMode = gameNode.GameGlobalState.ActiveBuildMode;
		
		return buildMode switch
		{
			BuildMode.Home => houseAtlasCoords,
			BuildMode.Road => roadAtlasCoords,
			BuildMode.Business => businessAtlasCoords,
			_ => houseAtlasCoords
		};
	}
}
