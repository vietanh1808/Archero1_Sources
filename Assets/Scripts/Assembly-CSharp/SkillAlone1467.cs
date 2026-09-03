using System.Collections.Generic;

public class SkillAlone1467 : SkillAloneBase
{
	private float m_fAngerPercent;

	private float m_fHitRatio1;

	private float m_fHitRatio2;

	private Dictionary<int, int> m_dicMappingWeapons2;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private float OnCalValue(HitStruct ht, EntityBase entity)
	{
		return 0f;
	}
}
