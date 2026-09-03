using UnityEngine;

public class SkillAlone1477 : SkillAlone1310
{
	private static float FACTOR;

	private SkillKillEnemy killEnemy;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private bool canUseSwordHitRatio()
	{
		return false;
	}

	private bool canSendBuffAfterKill()
	{
		return false;
	}

	private int getKillBuffId()
	{
		return 0;
	}

	private void onKill(EntityBase attackTarget, Vector3 HittedDirection, HitStruct hs)
	{
	}

	private float OnCalValue(HitStruct ht, EntityBase entity)
	{
		return 0f;
	}
}
