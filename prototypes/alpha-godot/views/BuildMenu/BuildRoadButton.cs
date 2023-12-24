using Godot;

namespace Alpha.views.BuildMenu;

public partial class BuildRoadButton : TextureButton
{
  public override void _Pressed()
  {
	var gameNode = GetGameNode();
	gameNode.SetActiveBuildMode(BuildMode.Road);
  }

  private Game GetGameNode()
  {
	return (Game)GetNode("/root/Game");
  }
}