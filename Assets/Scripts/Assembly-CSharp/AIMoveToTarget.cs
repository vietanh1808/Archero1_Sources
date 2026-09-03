using UnityEngine;

public class AIMoveToTarget : AIMoveToTargetPos
{
	protected override Vector3 moveDir => default;

	public AIMoveToTarget(EntityBase entity)
		: base(null)
	{
	}

	public AIMoveToTarget(EntityBase entity, float min, float max)
		: base(null)
	{
	}

	protected override bool isEntityInvalid()
	{
		return false;
	}

	protected override void updateDir()
	{
	}
}
