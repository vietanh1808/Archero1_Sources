using System.Collections.Generic;
using UnityEngine;

public class SkillAlone2287 : SkillAloneBase
{
	private class SkillEffect2287_SyncFullEffVO : CustomJsonActionVO
	{
		public int Guid;

		public int IsShow;
	}

	private class SkillEffect2287_SyncFlySwordVO : CustomJsonActionVO
	{
		public Vector3 StartPos;

		public float Angle;

		public int Guid;
	}

	private float moveDistance;

	private int heartBreakBuffId;

	private int heartStealBuffId;

	private float heartBreakCD;

	private int flySwordId;

	private int flySwordLimit;

	private float flySwordDuration;

	private float flySwordHitRatio;

	private float flySwordReduce;

	private float flySwordReduceMin;

	private float angularVelocity;

	private float flySwordCallRate;

	private const string fullEff = "Effect/Battle/eff_lovertiger_erupt";

	private const string fullRoundEff = "Effect/Battle/eff_lovertiger_light";

	private Vector3 curPos;

	private float moveDis;

	private float triggerTime;

	private bool shouldBreakHeart;

	private List<BulletBase> _bullets;

	private GameObject fullEffRound;

	private const string SyncSkill2287_SyncFullEff = "SyncSkill2287_SyncFullEff";

	private const string SyncSkill2287_SyncFlySword = "SyncSkill2287_SyncFlySword";

	protected virtual EntityBase Target => null;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void OnMove(bool value)
	{
	}

	private void OnHit(EntityBase enemy, HitStruct hs, HittedData ht)
	{
	}

	private void ShowEff(EntityBase entity)
	{
	}

	private void HideEffShow()
	{
	}

	private void CreateFlySword()
	{
	}

	private void DoCreateFlySword(Vector3 startPos, float angle, EntityBase target)
	{
	}

	private void OnBulletCache(BulletBase bullet)
	{
	}

	protected virtual void SyncFlySword(Vector3 startPos, float angle, int uid)
	{
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void OnEnemyDing(EntityBase target)
	{
	}

	private void SyncEffShow(int isShow, int guid)
	{
	}

	private void SyncHeartBullet(Vector3 startPos, float angle, int guid)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
