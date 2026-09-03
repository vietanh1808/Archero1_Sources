using UnityEngine;

public class SkillAlone1966 : SkillAloneBase
{
	private float maxHealthRiseFromBoss;

	private float maxHealthRiseFromCreeps;

	private float maxHealthRiseRate;

	private float curMaxHealthRiseRate;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void InitCurMaxHealthRiseRate()
	{
	}

	private void OnKill(EntityBase killedEntity, Vector3 vector, HitStruct hs)
	{
	}
}
