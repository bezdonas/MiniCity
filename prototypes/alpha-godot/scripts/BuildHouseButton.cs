using Godot;
using System;
using static Game;

public partial class BuildHouseButton : TextureRect
{

	public override void _Ready()
	{
		this.UpdateTexture();
		Game GameNode = this.GetGameNode();
		GameNode.ActiveBuildModeChanged += () => this.UpdateTexture();
	}

	public Game GetGameNode()
	{
		return (Game)GetNode("/root/Game");
	}

	public void UpdateTexture()
	{
		Game GameNode = this.GetGameNode();

		if (GameNode.activeBuildMode == BuildMode.Home)
		{
			Texture2D activeTexture = (Texture2D)ResourceLoader.Load("res://assets/HomeButtonActive.png");
			this.Texture = (Texture2D)activeTexture;
		}
		else
		{
			Texture2D unactiveTexture = (Texture2D)ResourceLoader.Load("res://assets/HomeButton.png");
			this.Texture = (Texture2D)unactiveTexture;
		}
	}
}
