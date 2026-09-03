using System.Collections.Generic;
using Dxx.Util;

public class SkillAlone1727 : SkillAloneBase
{
	private int CONFIG_CHAR_ID;

	private int[] CONFIG_SKILL_IDS;

	private int CONFIG_EFFECT_ID;

	private float CONFIG_HP_RATIO;

	private int CONFIG_HPSLIDER_ID;

	private int CONFIG_INTERVAL;

	private float CONFIG_HP_REDUCE_PERCENT;

	private int CONFIG_INVINCIBLE_BUFF_ID;

	private int CONFIG_TRANSFORM_BUFF_ID;

	private EntityHero m_hero;

	private int m_nOldCharId;

	private List<string> m_listOldAnis;

	private long m_lHp;

	private long m_lWukongHp;

	private long m_lCurWukongHp;

	private long m_lTime;

	private SequencePool mSeqPool;

	private bool m_bInSeqFlag;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private bool OnWukongChangeStatus()
	{
		return false;
	}

	private void onWillStartSphereFlash()
	{
	}

	private void Change()
	{
	}

	private void CreateSmoke()
	{
	}

	private void Reset()
	{
	}

	private void BianshenTransform(int id)
	{
	}

	private (long, float) OnEntityHittedOnce(long value)
	{
		return default;
	}
}
