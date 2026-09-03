using System.Collections.Generic;
using DG.Tweening;

public class SkillAlone1114 : SkillAloneMagicBookActiveSkillBase
{
	private new const string String_Time = "Time";

	private const string String_Element = "Element";

	private float m_fDuration;

	private int m_nElement;

	private float m_fTime;

	private bool m_bUseSkill;

	private bool m_bAddAttackListener;

	private List<EElementType> m_listElements;

	private Dictionary<EElementType, int> m_dicDebuffs;

	private Sequence seq;

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

	private void OnAttackPre()
	{
	}

	private void OnAttackEnd()
	{
	}

	private void RandomElement()
	{
	}
}
