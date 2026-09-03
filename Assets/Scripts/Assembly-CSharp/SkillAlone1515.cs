public class SkillAlone1515 : SkillAloneBase
{
	private float m_fRate;

	private int m_nInterval;

	private float m_fHpAddPercent;

	private float m_CreateHeartTimeInterval;

	private float m_DropHeartRate;

	private int m_nHitTime;

	private EntityHero m_hero;

	private float lastCreateHeartTime;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void onCrit(EntityBase arg1, long arg2)
	{
	}

	private void OnHitAction(EntityBase entity, HitStruct hs, HittedData data)
	{
	}

	private void createHeart()
	{
	}
}
