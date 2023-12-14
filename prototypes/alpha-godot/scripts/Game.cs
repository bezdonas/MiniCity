using System;
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
		this.activeBuildMode = mode;
		GD.Print("Active build mode changed to " + mode);
		EmitSignal(SignalName.ActiveBuildModeChanged);
	}

	private void BuildHouseButtonEventHandler(InputEventMouseButton @event)
	{
		if (@event is InputEventMouseButton && @event.Pressed == true)
		{
			GD.Print("house click");
			this.SetActiveBuildMode(BuildMode.Home);
		}
	}

	private void BuildJobButtonEventHandler(InputEventMouseButton @event)
	{
		if (@event is InputEventMouseButton && @event.Pressed == true)
		{
			GD.Print("job click");
			this.SetActiveBuildMode(BuildMode.Job);
		}
	}

	private void BuildRoadButtonEventHandler(InputEventMouseButton @event)
	{
		if (@event is InputEventMouseButton && @event.Pressed == true)
		{
			GD.Print("road click");
			this.SetActiveBuildMode(BuildMode.Road);
		}
	}

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Print("Game ready");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
