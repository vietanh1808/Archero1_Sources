using UnityEngine;

public class SkillAlone1547 : SkillAloneBase
{
	private float killSoldierPercent;

	private float killBossPercent;

	private float maxPercent;

	private float cumulatedPercent;

	private SkillKillEnemy skill;

	private string AttrKey => null;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void onKillEnemy(EntityBase attackTarget, Vector3 HittedDirection, HitStruct hs)
	{
	}

	private void onBefore(WeaponBase weapon)
	{
	}
}
