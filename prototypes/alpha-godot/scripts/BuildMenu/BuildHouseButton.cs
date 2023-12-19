using Godot;

public partial class BuildHouseButton : TextureButton
{
	public override void _Pressed()
	{
		Game GameNode = GetGameNode();
		GameNode.SetActiveBuildMode(BuildMode.Home);
	}

	public Game GetGameNode()
	{
		return (Game)GetNode("/root/Game");
	}
}
