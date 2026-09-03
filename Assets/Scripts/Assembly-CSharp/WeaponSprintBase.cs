using UnityEngine;

public class WeaponSprintBase : WeaponBase
{
	protected float distance;

	protected float delaytime;

	protected float updatetime;

	private bool bStart;

	private float starttime;

	private float percent;

	private float x;

	private float y;

	private Vector3 startpos;

	private Vector3 endpos;

	private Vector3 currentmove;

	private float percentbefore;

	private float percentchange;

	protected override void OnInstall()
	{
	}

	protected override void OnUnInstall()
	{
	}

	private void OnAttackStartStart()
	{
	}

	protected virtual Vector3 CalEndPos()
	{
		return default;
	}

	protected virtual void OnAttackStartEnd()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	protected virtual void OnUpdateMove(float currentdis)
	{
	}
}
