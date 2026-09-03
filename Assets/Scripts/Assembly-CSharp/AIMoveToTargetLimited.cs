using UnityEngine;

public class AIMoveToTargetLimited : AIMoveToTarget
{
	public float MaxDegreesInTrack;

	public float RotateDegreesPerSecond;

	protected float currentRotateDegreesInTrack;

	public AIMoveToTargetLimited(EntityBase entity)
		: base(null)
	{
	}

	protected override void onAfterInit()
	{
	}

	protected override void updateDir()
	{
	}

	protected override void OnCollision(RaycastHit hitInfo)
	{
	}

	protected override bool canUpdateDir()
	{
		return false;
	}
}
