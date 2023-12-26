using System.Collections.Generic;
using System.Linq;
using PubSub;

namespace Alpha.models;

public class GlobalState
{
	private readonly Hub _hub = Hub.Default;
	
	private BuildMode _activeBuildMode = BuildMode.Home;
	public BuildMode ActiveBuildMode
	{
		get => _activeBuildMode;
		set
		{
			_activeBuildMode = value;
			_hub.Publish(ActiveBuildMode);
		}
	}
	
	public List<MapObject> MapObjects { get; } = new List<MapObject>();

	public void AddMapObject(MapObject newMapObject)
	{
		MapObjects.Add(newMapObject);
		_hub.Publish(newMapObject);
	}

	public void RemoveMapObject(string mapObjectId)
	{
		var itemToRemove = MapObjects.SingleOrDefault(
			mapObj => mapObj.Id == mapObjectId
		);
		MapObjects.Remove(itemToRemove);
	}
}
