using Godot;

namespace Alpha.views.BuildMenu;

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
