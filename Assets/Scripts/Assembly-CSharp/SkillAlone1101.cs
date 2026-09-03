public class SkillAlone1101 : SkillAloneBase
{
	protected new string Tag;

	private const string String_KillRewardHPMax = "KillRewardHPMaxValue";

	private const string String_KillRewardHPMaxPercent = "KillRewardHPMax%";

	private const string String_KillRewardAttackValue = "KillRewardAttackValue";

	private const string String_KillRewardAttackValuePercent = "KillRewardAttackValue%";

	private const string String_KillRewardAttackSpeedPercent = "KillRewardAttackSpeed%";

	private const string String_KillRewardCritRatePercent = "KillRewardCritRate%";

	private const string String_KillRewardCritValuePercent = "KillRewardCritValue%";

	private const string String_Limit = "Limit";

	private const string String_LimitPercent = "Limit%";

	protected int m_nAddValuePerMonster;

	protected float m_fAddValuePencentPerMonster;

	protected int m_nLimit;

	protected int m_nLimitPercent;

	protected float m_fAddedValue;

	protected string m_strAttribute;

	protected override void OnInstall()
	{
	}

	protected virtual void onInitAddedValue()
	{
	}

	protected virtual void addEventListener()
	{
	}

	protected virtual void removeEventListener()
	{
	}

	protected void debug(string value, params object[] args)
	{
	}

	protected virtual void Excute(string str)
	{
	}

	protected void add_already_add(string goodType)
	{
	}

	private void onMonsterDead(EntityBase entity)
	{
	}

	protected virtual void onEvent()
	{
	}

	protected virtual void SaveBattleCache()
	{
	}

	protected override void OnUninstall()
	{
	}
}
