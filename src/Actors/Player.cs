using Godot;
using System;

public class Player : KinematicBody2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

    public override void _PhysicsProcess(float delta)
	{
		var velocity = new Vector2(300, 0);
		MoveAndSlide(velocity); 
		// var motion = new Vector2();
		// motion.x = Input.GetActionStrength("move_right") - Input.GetActionStrength("move_left");
		// motion.y = Input.GetActionStrength("move_down") - Input.GetActionStrength("move_up");

		// MoveAndCollide(motion.Normalize() * MoveAndSlide * delta);
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
