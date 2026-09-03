using System.Collections.Generic;
using Dxx.Util;
using UnityEngine;

public class SkillAlone1196 : SkillAloneMagicBookActiveSkillBase
{
	private List<int> m_listCallIds;

	private List<float> m_listAttackRatios;

	private List<float> m_listBodyHitRatios;

	private Dictionary<int, float> m_dicDropRates;

	private Dictionary<int, int> m_dicDrops;

	private List<int> m_listDebuffs;

	private float m_fLvUpAttackUp;

	private float m_fTime;

	private int m_nAddTimePerKill;

	private int m_nWildBuffSelf;

	private int m_nWildBuffItem;

	private SequencePool mSeqPool;

	private List<SkillAlone1196BombCtrl> m_listBombs;

	private List<float> m_listInheritAttackSpeeds;

	private List<int> m_listMinNum;

	private List<int> m_listMaxNum;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void CheckArgs()
	{
	}

	protected override bool OnExcuteOneArg(string str)
	{
		return false;
	}

	private void OnDoubleClick()
	{
	}

	private bool RemoveCall()
	{
		return false;
	}

	private void Call()
	{
	}

	private Vector3[] GetCallPos(int cnt)
	{
		return null;
	}

	private bool GetCallPos(Vector3 pos, out Vector2Int pos_1)
	{
		pos_1 = default;
		return false;
	}

	protected override bool OnEnergyFull()
	{
		return false;
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void OnBombOver(SkillAlone1196BombCtrl bomb)
	{
	}

	private void OnCallPartBody(EntityPartBodyBase entity)
	{
	}

	private void OnRemovePartBody(EntityPartBodyBase entity, int id)
	{
	}

	private void CreateDeadGoods(List<BattleDropData> list, Vector3 position)
	{
	}
}
