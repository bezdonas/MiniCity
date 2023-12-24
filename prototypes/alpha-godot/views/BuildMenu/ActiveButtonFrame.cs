using Godot;
using PubSub;
using Alpha.models.ActiveBuildMode;

namespace Alpha.views.BuildMenu;

public partial class ActiveButtonFrame : TextureRect
{
    private readonly Hub _hub = Hub.Default;

    public override void _Ready()
    {
        _hub.Subscribe<BuildMode>(this, UpdatePosition);
    }

    private void UpdatePosition(BuildMode activeBuildMode)
    {
        // TODO: crutch
        var offset = activeBuildMode switch
        {
            BuildMode.Home => new float[] { 485, 614 },
            BuildMode.Business => new float[] { 547, 615 },
            BuildMode.Road => new float[] { 601, 617 },
            _ => new float[] { 0, 0 }
        };

        var offsetVector = new Vector2(offset[0], offset[1]);
        Position = offsetVector;
    }
}