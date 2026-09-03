using System.Collections.Generic;

public class SkillAlone1226 : SkillAloneBase
{
	private float m_fRange;

	private float m_fDistance;

	private int m_nDebuffId;

	private float m_fTime;

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
}
