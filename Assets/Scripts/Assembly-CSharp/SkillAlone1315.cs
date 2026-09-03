using System.Collections.Generic;

public class SkillAlone1315 : SkillAloneBase
{
	private Dictionary<int, int> m_dicMapping;

	private float m_fRate;

	private int m_nMin;

	private int m_nMax;

	private float m_fAttackRatio;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHit(EntityBase entity, HitStruct hs, HittedData data)
	{
	}
}
