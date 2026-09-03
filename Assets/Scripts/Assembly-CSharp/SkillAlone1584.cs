using System.Collections.Generic;

public class SkillAlone1584 : SkillAloneBase
{
	protected float m_fRadius;

	private int m_nDebuffId;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnCrit(EntityBase entity, long value)
	{
	}

	protected virtual List<EntityBase> GetTargets(EntityBase entity)
	{
		return null;
	}
}
