using Godot;

namespace Alpha.views.BuildMenu;

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
