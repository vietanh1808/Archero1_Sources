using UnityEngine;

public class SkillAlone1076 : SkillAloneBase
{
	private long clockindex;

	private int bulletid;

	private float delaytime;

	private float hitratio;

	private float exponent;

	private float max;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnAttackSpeedUpdate(int value)
	{
	}

	private void UpdateTicker()
	{
	}

	private void OnAttack()
	{
	}

	public virtual BulletBase CreateFlySword(Vector3 startpos, float angle)
	{
		return null;
	}

	private void synBulletCommand(Vector3 startpos, float angle)
	{
	}

	protected virtual bool CheckTarget(EntityBase target)
	{
		return false;
	}

	private bool IsFlySword(int id)
	{
		return false;
	}
}
