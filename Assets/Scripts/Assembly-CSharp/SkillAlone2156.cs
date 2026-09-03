using UnityEngine;

public class SkillAlone2156 : SkillAloneBase
{
	private int CONFIG_DEBUFF_ID;

	private float CONFIG_ADD_BLACK_HIT_PERCENT;

	private int CONFIG_ADD_BLACK_HIT_TIMES_MAX;

	private int CONFIG_BUFF_ID_2;

	private float CONFIG_HP_PERCENT;

	private float CONFIG_SHIELD_PERCENT;

	protected int _times;

	private EntityHero _hero;

	private bool _usedFlag;

	private GameObject _effect;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHitted(EntityBase entity, long value)
	{
	}

	protected virtual void CreateEffect(int id, int times)
	{
	}

	private float OnCalBlackHit()
	{
		return 0f;
	}

	protected void OnFirstDeadRecover()
	{
	}

	protected virtual void UpdateDemonShieldShildPercent(long value, long max)
	{
	}
}
