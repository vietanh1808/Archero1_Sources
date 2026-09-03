using DG.Tweening;
using UnityEngine;

public class SkillAlone1125 : SkillAloneBase
{
	private long m_nAddAttackPercent;

	private long m_nAddBodyHitPercent;

	private long m_nHpRecoverPercent;

	private long m_nInterval;

	private long m_nTimes;

	private long m_nAddAttackPercentMax;

	private long m_nAddBodyHitPercentMax;

	private long m_nHpRecoverPercentMax;

	private bool m_bTriggerInWaveRoom;

	private long m_nAddAttackPercentTotal;

	private long m_nAddBodyHitPercentTotal;

	private long m_nHpRecoverPercentTotal;

	private int m_nEffectId;

	private Sequence seq;

	private bool is_wave_room;

	protected override void OnInstall()
	{
	}

	private void Excute(string str)
	{
	}

	protected override void OnUninstall()
	{
	}

	private void KillSequence()
	{
	}

	protected void OnWaveRoomPlayerMove(Vector3 pos)
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void OnOpenDoor(RoomGenerateBase.Room room)
	{
	}

	private void AddInterval()
	{
	}
}
