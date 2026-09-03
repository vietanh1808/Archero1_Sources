using UnityEngine;

public class SkillAlone2112 : SkillAloneBase
{
	private float CONFIG_RATE;

	private float CONFIG_CD;

	private float CONFIG_WAIT;

	private float CONFIG_BOMB_RADIUS;

	private float CONFIG_HIT_RATIO;

	private int CONFIG_RADIUS;

	private float? m_fLastTime;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHit(EntityBase entity, HitStruct hs, HittedData data)
	{
	}

	protected virtual void CreateFirecracker(Vector3 pos)
	{
	}
}
