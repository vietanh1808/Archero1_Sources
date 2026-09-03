using Dxx.Util;

public class SkillAlone1115 : SkillAloneMagicBookActiveSkillBase
{
	private float m_fTime;

	private float m_fDuration;

	private bool m_bUseSkill;

	private const string String_IceAttackPercent = "IceAttackValue%";

	private const string String_IceAttack = "IceAttack";

	private const string String_IceTime = "IceTime";

	private const string String_Range = "Range";

	private int m_nIceAttackPercent;

	private int m_nIceAttack;

	private float m_fIceTime;

	private float m_fRange;

	private float m_fMinRange;

	private SequencePool mSeqPool;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void KillSequence()
	{
	}

	protected override bool OnExcuteOneArg(string str)
	{
		return false;
	}

	private void OnUpdate(float delta)
	{
	}

	private void OnDoubleClick()
	{
	}

	protected override bool OnEnergyFull()
	{
		return false;
	}

	private void FrozenEnemies()
	{
	}
}
