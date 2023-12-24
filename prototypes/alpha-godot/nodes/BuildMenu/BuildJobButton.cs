using Godot;

namespace Alpha.nodes.BuildMenu;

public partial class BuildJobButton : TextureButton
{
  public override void _Pressed()
  {
	var gameNode = GetGameNode();
	gameNode.SetActiveBuildMode(BuildMode.Job);
  }

  private Game GetGameNode()
  {
	return (Game)GetNode("/root/Game");
  }
}
