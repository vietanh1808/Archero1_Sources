public class SkillAlone1580 : SkillAloneBase
{
	private float m_fRate;

	protected int m_nBuffId;

	protected int m_nEffectId;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHitEnemy(EntityBase entity, HitStruct ht, HittedData hd)
	{
	}

	protected virtual void SendBuff(EntityBase entity)
	{
	}
}
