using Godot;

namespace Alpha.views.BuildMenu;

public partial class ActiveButtonFrame : TextureRect
{
  public override void _Ready()
  {
	var gameNode = (Game)GetNode("/root/Game");
	gameNode.ActiveBuildModeChanged += UpdatePosition;
  }

  private void UpdatePosition()
  {
	var gameNode = (Game)GetNode("/root/Game");
	float[] offset = { 0, 0 };
	switch (gameNode.ActiveBuildMode)
	{
	  case BuildMode.Home:
		offset = new float[] { 485, 614 };
		break;
	  case BuildMode.Job:
		offset = new float[] { 547, 615 };
		break;
	  case BuildMode.Road:
		offset = new float[] { 601, 617 };
		break;
	  default:
		Visible = false;
		break;
	}

	var offsetVector = new Vector2(offset[0], offset[1]);
	Position = offsetVector;
  }
}
