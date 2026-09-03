using UnityEngine;

public class AIMoveCollisionBase : AIMoveBase
{
	protected int curFrameCount;

	public float RadiusFactor;

	public AIMoveCollisionBase(EntityBase entity)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void CheckCollision()
	{
	}

	protected virtual void OnCollision(RaycastHit hitInfo)
	{
	}
}
