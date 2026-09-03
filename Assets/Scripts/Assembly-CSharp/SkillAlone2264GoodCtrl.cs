using UnityEngine;

public class SkillAlone2264GoodCtrl : SkillAlone2103GoodCtrl
{
	private Vector3 selfCenter;

	private Vector3 forward;

	private float angle;

	public void SetParams(Vector3 center, Vector3 heroForward, float angle)
	{
	}

	protected override void AttackEnemy(EntityBase entity)
	{
	}

	private bool IsInSector(Vector3 destPos)
	{
		return false;
	}

	protected override void Init()
	{
	}
}
