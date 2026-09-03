using System.Collections.Generic;
using Dxx.Util;
using UnityEngine;

public class AIMove1084 : AIMove1008
{
	private const string COLLIDER_RESOURCE = "Game/SkillPrefab/CollisionCtrl1007";

	private GameObject mCollision;

	private float distance;

	private Vector3 lastPos;

	private Dictionary<ThunderContinueMgr.ThunderContinueReceive, List<Vector3>> m_dicBulltPoses;

	private List<ThunderContinueMgr.ThunderContinueReceive> m_listReceives;

	private float m_fLastCollideTime;

	private SequencePool mSeqPool;

	public AIMove1084(EntityBase entity, float move2playertatio, int time, float speedratio)
		: base(null, 0f, 0, 0f)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override void OnEnd()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void CreateCollisionCtrl()
	{
	}

	private void DestroyCollision()
	{
	}

	private void CollisionEnter(Collision c)
	{
	}

	private Vector3 GetBulletPos(ThunderContinueMgr.ThunderContinueReceive receiver, int cnt, int index)
	{
		return default;
	}

	private int GetBulletCnt()
	{
		return 0;
	}
}
