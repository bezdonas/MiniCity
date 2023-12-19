using Godot;

public enum BuildMode
{
	Home,
	Job,
	Road
}

public partial class Game : Node
{
	public BuildMode activeBuildMode = BuildMode.Home;


	[Signal]
	public delegate void ActiveBuildModeChangedEventHandler();

	public void SetActiveBuildMode(BuildMode mode)
	{
		activeBuildMode = mode;
		GD.Print("Active build mode changed to " + mode);
		EmitSignal(SignalName.ActiveBuildModeChanged);
	}

	public override void _Ready()
	{
		GD.Print("Game ready");
	}

	public override void _Process(double delta)
	{
	}
}
