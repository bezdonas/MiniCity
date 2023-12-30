using Godot;
using Alpha.models;

namespace Alpha.views.BuildMenu;

public partial class BuildRoadButton : TextureButton
{
    private readonly GlobalState _globalState = GlobalState.Instance;

    public override void _Pressed()
    {
        _globalState.ActiveBuildMode = BuildMode.Road;
    }

    private Game GetGameNode()
    {
        return (Game)GetNode("/root/Game");
    }
}