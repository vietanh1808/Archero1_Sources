using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class SkillAlone1155 : SkillAloneBase
{
	private class BuffRate
	{
		public int buffId;

		public int weight;

		public float time;

		public int effectId;

		public BuffRate(int buffId, int weight, float time, int effectId)
		{
		}
	}

	private float m_fInterval;

	private int m_nWidth;

	private int m_nHeight;

	private int m_nFlagMax;

	private float m_fRate;

	private float m_fTime;

	private float m_fBuleFlagTime;

	private int m_nTotalWeight;

	private int m_nLastBuffId;

	private float m_fCreateFlagTime;

	private Dictionary<int, BuffRate> m_dicBuffIds;

	private List<SkillAlone1155GoodCtrl> m_listFlags;

	private Sequence sequence;

	private EntityHero self;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ClearFlags()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	protected virtual bool CheckAliveEnemy()
	{
		return false;
	}

	protected virtual EntityBase GetNearestEnemy()
	{
		return null;
	}

	private void CreateFlag(EntityBase entity)
	{
	}

	protected virtual void OnAfterAbsorbSoul()
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void onHitAction(EntityBase entity, HitStruct hs, HittedData data)
	{
	}

	private bool GetFlagPos(out Vector2Int pos_1)
	{
		pos_1 = default;
		return false;
	}

	private void OnTriggerFlag(int buffId, SkillAlone1155GoodCtrl obj)
	{
	}
}
