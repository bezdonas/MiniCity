using Godot;
using Alpha.models;

namespace Alpha.views.BuildMenu;

public partial class BuildHouseButton : TextureButton
{
	public override void _Pressed()
	{
		var gameNode = GetGameNode();
		gameNode.GameGlobalState.ActiveBuildMode = BuildMode.Home;
	}

	private Game GetGameNode()
	{
		return (Game)GetNode("/root/Game");
	}
}
