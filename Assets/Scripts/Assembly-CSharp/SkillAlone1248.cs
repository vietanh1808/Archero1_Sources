using System.Collections.Generic;

public class SkillAlone1248 : SkillAloneBase
{
	private float m_fTime;

	private float m_fInterval;

	private float m_fRadius;

	private int m_nBuffId;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	protected virtual List<EntityBase> GetRoundEntities(float radius)
	{
		return null;
	}
}
