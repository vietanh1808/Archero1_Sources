using System.Collections.Generic;
using DG.Tweening;

public class SkillAlone1117 : SkillAloneMagicBookBase
{
	private const string String_BulletScale = "BulletScale";

	private const string String_BackRatio = "BackRatio";

	private const string String_Element = "Element";

	private new const string String_Time = "Time";

	private float m_fDuration;

	private int m_nElement;

	private float m_fTime;

	private bool m_bUseSkill;

	private bool m_bAddAttackListener;

	private Sequence seq;

	private List<EElementType> m_listElements;

	private Dictionary<EElementType, int> m_dicDebuffs;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected override bool OnExcuteOneArg(string str)
	{
		return false;
	}

	protected override void OnEnergyChange()
	{
	}

	protected override bool OnEnergyFull()
	{
		return false;
	}

	protected void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void trigger()
	{
	}

	private void resetAttrs()
	{
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

	private void KillSequence()
	{
	}
}
