using System.Collections.Generic;

public class SkillAlone1120 : SkillAloneBase
{
	private float m_fInterval;

	private int m_nRadius;

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

	protected virtual List<EntityBase> GetTargets()
	{
		return null;
	}
}
