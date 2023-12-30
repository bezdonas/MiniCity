using Godot;
using Alpha.models;

namespace Alpha.views.BuildMenu;

public partial class BuildHouseButton : TextureButton
{
    private readonly GlobalState _globalState = GlobalState.Instance;

    public override void _Pressed()
    {
        _globalState.ActiveBuildMode = BuildMode.Home;
    }

    private Game GetGameNode()
    {
        return (Game)GetNode("/root/Game");
    }
}