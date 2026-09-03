using System.Collections.Generic;

public class SkillAlone7005 : SkillAloneBase
{
	private int m_nType;

	private float m_fHpPercent;

	private float m_fHitRaisePercent;

	private float m_fBossHpPercent;

	private List<EntityBase> m_listBoss;

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
