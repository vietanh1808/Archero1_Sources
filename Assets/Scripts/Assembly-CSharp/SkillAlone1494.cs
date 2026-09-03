using System.Collections.Generic;

public class SkillAlone1494 : SkillAloneBase
{
	private int m_nDebuffId;

	private float m_fRadius;

	private float m_fInterval;

	private float m_fAddBase;

	private int m_nMax;

	private float m_fTime;

	private float m_fAddValue;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	protected virtual List<EntityBase> GetEnemies()
	{
		return null;
	}

	protected virtual bool CheckEnemy(EntityBase entity)
	{
		return false;
	}
}
