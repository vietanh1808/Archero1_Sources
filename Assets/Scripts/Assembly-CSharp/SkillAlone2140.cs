using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class SkillAlone2140 : SkillAloneBase
{
	protected float sendFlySwordInterval;

	private float sendFlySwordLastTime;

	private float flySwordRatio;

	private float sendExponent;

	private float sendMax;

	private float flySwordInheritPlayerCritScale;

	private float flySwordInheritPlayerCritValueScale;

	private float flySwordExtraCritValue;

	private float flySwordCritMaxValue;

	public const int SendFlySwordCount = 1;

	public const int FlySwordBulletID = 5348;

	private Tween delayCall;

	private List<Tween> allDelayCall;

	private List<long> clockIndexList;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected void OnBlackHoleSkillEnd(Vector3 skillPos)
	{
	}

	private void CheckCastSkill(Vector3 skillPos)
	{
	}

	protected virtual BulletBase CreateFlySword(EntityBase sender, Vector3 startpos, float angle)
	{
		return null;
	}

	private long LoadSkill(Vector3 skillPos)
	{
		return 0L;
	}

	private void SkillEnd(long clockIndex)
	{
	}

	private void SendCreateFlySwordMsg(EntityBase sender, Vector3 startPos, float angle)
	{
	}

	private void SyncCreateFlySwordMsg(EntityBase sender, Vector3 startPos, float angle)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
