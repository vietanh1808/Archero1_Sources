using System.Collections.Generic;

public class SkillAlone1654 : SkillAloneMeteoriteBase
{
	private float m_fRate;

	private List<int> m_listHeroMeteoriteBulletIds;

	private List<int> m_listCallMeteoriteBulletIds;

	private float m_fDropRadius;

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
