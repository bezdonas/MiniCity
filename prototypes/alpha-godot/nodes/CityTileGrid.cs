using Godot;

namespace Alpha.nodes;

public partial class CityTileGrid : TileMap
{
	private int _backgroundLayer = 0;
	private int _gridLayer = 1;
	private int _roadBuildingsLayer = 2;
	private int _roadBuildingsSourceId = 1;
	
	public override void _Input(InputEvent @event)
	{
		if (Input.IsActionJustPressed("click"))
		{
			Vector2I tilePosition = GetTilePosition();
			if (tilePosition[1] >= 18) // buttons level
			{
				return;
			}
			Vector2I atlasCoords = GetAtlasCoordsByBuildMode();
			SetCell(_roadBuildingsLayer, tilePosition, _roadBuildingsSourceId, atlasCoords);
		}
	}

	public Vector2I GetTilePosition()
	{
		Vector2 mousePosition = GetGlobalMousePosition();
		return LocalToMap(mousePosition);	
	}

	public Vector2I GetAtlasCoordsByBuildMode()
	{
		Vector2I houseAtlasCoords = new Vector2I(0, 0);
		Vector2I jobAtlasCoords = new Vector2I(0, 1);
		Vector2I roadAtlasCoords = new Vector2I(1, 0);
		Game gameNode = (Game)GetNode("/root/Game");
		BuildMode buildMode = gameNode.ActiveBuildMode;

		switch (buildMode)
		{
			case BuildMode.Home:
				return houseAtlasCoords;
			case BuildMode.Road:
				return roadAtlasCoords;
			case BuildMode.Job:
				return jobAtlasCoords;
			default:
				return houseAtlasCoords;
		}
	}
}
