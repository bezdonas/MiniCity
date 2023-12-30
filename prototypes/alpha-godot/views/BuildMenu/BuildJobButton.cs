using Godot;
using Alpha.models;

namespace Alpha.views.BuildMenu;

public partial class BuildJobButton : TextureButton
{
    private readonly GlobalState _globalState = GlobalState.Instance;

    public override void _Pressed()
    {
        _globalState.ActiveBuildMode = BuildMode.Business;
    }

    private Game GetGameNode()
    {
        return (Game)GetNode("/root/Game");
    }
}