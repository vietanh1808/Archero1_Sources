using UnityEngine;

public class AIMoveToCustomTarget : AIMoveToTargetPos
{
	protected override Vector3 moveDir => default;

	public AIMoveToCustomTarget(EntityBase entity)
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
