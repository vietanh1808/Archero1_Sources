using System.Collections.Generic;

public class SkillAlone7004 : SkillAloneBase
{
	private float m_fHpPercent;

	private int[] m_vecBuffIds;

	private int[] m_vecIntervals;

	private Dictionary<int, float> m_dicWaitTimes;

	private bool m_bCdFlag;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnChangeHP(long currentHP, long maxHP, float percent, long change)
	{
	}

	private void CheckBuff(float percent)
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void OnOpenDoor(RoomGenerateBase.Room room)
	{
	}
}
