using UnityEngine;

public class SkillAlone1734 : SkillAloneBase
{
	private float CONFIG_CD_1;

	private float CONFIG_CD_2;

	private int CONFIG_BUFFID;

	private float CONFIG_TIME_ADD;

	private float CONFIG_TIME_MAX;

	private float CONFIG_RATE;

	private float CONFIG_ADD_MAX_FLAG;

	private int CONFIG_RADIUS;

	private float m_fLastDropTime;

	private float m_fTotalAdd;

	private EntityHero m_hero;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHit(EntityBase entity, HitStruct hs, HittedData data)
	{
	}

	protected virtual void CreateStar(Vector2Int v, float time)
	{
	}

	protected void DoCreateStar(Vector2Int v, float time)
	{
	}

	protected virtual void OnTriggerEvent()
	{
	}

	private (float, float) onSkillAlone1356SuperSkillTimeEvent()
	{
		return default;
	}
}
