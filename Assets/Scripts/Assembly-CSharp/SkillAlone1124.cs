using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class SkillAlone1124 : SkillAloneBase
{
	private long m_nAddAttackPercent;

	private long m_nAddBodyHitPercent;

	private long m_nHpRecoverPercent;

	private long m_nInterval;

	private long m_nTimes;

	private long m_nAddAttackPercentMax;

	private long m_nAddBodyHitPercentMax;

	private long m_nHpRecoverPercentMax;

	private int m_nEffectId;

	private bool m_bTriggerInWaveRoom;

	private float m_fStartTime;

	private Dictionary<EntityBase, long> m_dicEnemiesAddAttackValues;

	private Dictionary<EntityBase, long> m_dicEnemiesAddBodyHitValues;

	private Dictionary<EntityBase, long> m_dicEnemiesHpRecoverValues;

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

	private void OnOpenDoor(RoomGenerateBase.Room room)
	{
	}

	protected void OnWaveRoomPlayerMove(Vector3 pos)
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void AddInterval()
	{
	}

	private void ExcuteAttributes()
	{
	}

	private void OnEnemiesCntChanged(List<EntityBase> entities)
	{
	}

	private void OnUpdate(float delta)
	{
	}
}
