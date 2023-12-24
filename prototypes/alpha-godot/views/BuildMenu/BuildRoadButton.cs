using Godot;
using Alpha.models.ActiveBuildMode;

namespace Alpha.views.BuildMenu;

public partial class BuildRoadButton : TextureButton
{
  public override void _Pressed()
  {
	var gameNode = GetGameNode();
	gameNode.GameGlobalState.ActiveBuildMode = BuildMode.Road;
  }

  private Game GetGameNode()
  {
	return (Game)GetNode("/root/Game");
  }
}
