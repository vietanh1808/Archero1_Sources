using Dxx.Util;

public class SkillAlone1712 : SkillAloneBase
{
	private int CONFIG_BUFF_ID;

	private float CONFIG_DROP_HP_RATE;

	private int CONFIG_DROP_HP_MIN;

	private int CONFIG_DROP_HP_MAX;

	private EntityHero m_self;

	private SequencePool mSeqPool;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnFirstDeadRecover()
	{
	}
}
