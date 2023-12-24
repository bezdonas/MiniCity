using Godot;

namespace Alpha.nodes.BuildMenu;

public partial class BuildRoadButton : TextureButton
{
  public override void _Pressed()
  {
	Game GameNode = GetGameNode();
	GameNode.SetActiveBuildMode(BuildMode.Road);
  }

  public Game GetGameNode()
  {
	return (Game)GetNode("/root/Game");
  }
}
