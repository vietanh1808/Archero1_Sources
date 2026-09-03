using UnityEngine;

public class AI4007InstantMove : AIInstantMoveFixDir
{
	public const float BeetleSpeedTimes = 0.4f;

	public const float MaxBeetleSpeedTimes = 10f;

	public const float DeltaBeetleSpeedTimes = 0.4f;

	public float MaxSpeedTimes;

	public float AcceleratedSpeedTimes;

	private float curSpeedTimes;

	public AI4007InstantMove(EntityBase entity)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override void OnUpdate()
	{
	}

	protected override void onCollisionWallEvent()
	{
	}

	protected override void OnCollision(RaycastHit hitInfo)
	{
	}
}
