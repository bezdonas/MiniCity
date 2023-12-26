using Alpha.models;
using Godot;

namespace Alpha.views;

public partial class Game : Node
{
	public readonly GlobalState GameGlobalState = new();

	public override void _Ready()
	{
		GD.Print("Game ready");
	}
}
