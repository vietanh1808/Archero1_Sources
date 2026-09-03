using UnityEngine;

public class Bullet2EntityThunderLineCtrl : ThunderLineCtrl
{
	private EntityBase entity;

	private Transform bulletTrans;

	private Transform target;

	private bool IsEntityTarget => false;

	private bool IsTransTarget => false;

	private Transform TargetTrans => null;

	protected override void UpdateEntity()
	{
	}

	protected override void updateByPos()
	{
	}

	public void UpdateFromTo(Transform from, EntityBase to)
	{
	}

	public void UpdateFromTo(Transform from, Transform to)
	{
	}

	private bool CanUpdate()
	{
		return false;
	}
}
