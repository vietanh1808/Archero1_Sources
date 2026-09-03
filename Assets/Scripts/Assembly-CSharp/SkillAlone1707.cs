using UnityEngine;

public class SkillAlone1707 : SkillAloneBase
{
	private int addPerFireRateNeedMonsterCount;

	private int addPerFireRateNeedBossCount;

	private int addFireRate;

	private int addFireRateMax;

	private int killMonsterCount;

	private int killBossCount;

	private int lastAddValue;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void onKillEnemy(EntityBase attackTarget, Vector3 HittedDirection, HitStruct hs)
	{
	}

	private void RefreshAddFireRate(int killMonsterCount, int killBossCount)
	{
	}
}
