using System.Numerics;
using Sandbox;
using Sandbox.Movement;
using Sandbox.Navigation;

public sealed class NPC : Component
{
	[RequireComponent] PlayerController Agent { get; set; }
	protected override void OnFixedUpdate()
	{
		var pos = Scene.NavMesh.GetRandomPoint();
		Agent.WishVelocity += (Vector3)(Vector3.Zero - LocalPosition) * Time.Delta / 2;
		if( Agent.LocalPosition == Vector3.Zero ) Agent.WishVelocity = 0f;
	}
}
