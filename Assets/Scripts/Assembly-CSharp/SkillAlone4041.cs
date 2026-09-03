public class SkillAlone4041 : SkillAloneBase
{
	private float m_fRate;

	private int m_nInterval;

	private float m_fHpAddPercent;

	private int m_nHitTime;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHit(EntityBase entity, HitStruct hs, HittedData data)
	{
	}

	private void OnDropHp(CustomJsonDataCommand cmd)
	{
	}

	private void OnDropHp(int hp, EntityHero hero, EntityBase entity)
	{
	}

	private void OnRecvCustomJsonDataCommand(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
