using Godot;

namespace Alpha.nodes.BuildMenu;

public partial class BuildHouseButton : TextureButton
{
	public override void _Pressed()
	{
		var gameNode = GetGameNode();
		gameNode.SetActiveBuildMode(BuildMode.Home);
	}

	private Game GetGameNode()
	{
		return (Game)GetNode("/root/Game");
	}
}
