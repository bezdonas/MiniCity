using Godot;

namespace Alpha.nodes.BuildMenu;

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
