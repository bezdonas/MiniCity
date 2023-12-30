using System.Collections.Generic;
using System.Linq;
using PubSub;

namespace Alpha.models;

public sealed class GlobalState
{
    private readonly Hub _hub = Hub.Default;
    private static GlobalState _instance;
    private static readonly object Padlock = new();

    private GlobalState()
    {
    }

    public static GlobalState Instance
    {
        get
        {
            lock (Padlock)
            {
                return _instance ??= new GlobalState();
            }
        }
    }

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

    private List<MapObject> MapObjects { get; } = new();

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