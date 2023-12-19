using Godot;

public partial class BuildJobButton : TextureButton
{
  public override void _Pressed()
  {
    Game GameNode = GetGameNode();
    GameNode.SetActiveBuildMode(BuildMode.Job);
  }

  public Game GetGameNode()
  {
    return (Game)GetNode("/root/Game");
  }
}
