using PubSub;

namespace Alpha.models.ActiveBuildMode;

public class ActiveBuildModeClass
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
}