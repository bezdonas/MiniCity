using Godot;
using Alpha.models;

namespace Alpha.views.BuildMenu;

public partial class BuildJobButton : TextureButton
{
  public override void _Pressed()
  {
	var gameNode = GetGameNode();
	gameNode.GameGlobalState.ActiveBuildMode = BuildMode.Business;
  }

  private Game GetGameNode()
  {
	return (Game)GetNode("/root/Game");
  }
}
