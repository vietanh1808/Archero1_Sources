using UnityEngine;

public class SkillAlone1555 : SkillAloneBase
{
	private const int BULLET_ID = 7216;

	private float callRate;

	private float attackPercent;

	private float timeInterval;

	private ConditionTime interval;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected override void OnRecvCustomJsonActionInternal(CustomJsonDataCommand cmd, CustomJsonActionVO vo)
	{
	}

	private void onAttack()
	{
	}

	private void createBullet(Vector3 bulletPos, float bulletAngle)
	{
	}

	private void syncBullet(Vector3 bulletPos, float bulletAngle)
	{
	}
}
