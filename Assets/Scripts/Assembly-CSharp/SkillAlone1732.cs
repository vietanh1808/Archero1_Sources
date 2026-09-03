using UnityEngine;

public class SkillAlone1732 : SkillAloneBase
{
	private float CONFIG_SKILL_DURATION;

	private float CONFIG_ROTATE_SPEED;

	private float CONFIG_SKILL_CD;

	private float CONFIG_RATE;

	private float CONFIG_RADIUS;

	private float CONFIG_HIT_RATIO;

	private float m_fSkillStartTime;

	private GameObject obj;

	private Coroutine m_Coroutine;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHitted(EntityBase entity, long value)
	{
	}

	protected virtual void CreateRotateCandy()
	{
	}

	protected virtual void RemoveRotateCandy()
	{
	}

	protected void DoRemoveRotateCandy()
	{
	}

	protected void DoCreateRotateCandy()
	{
	}
}
