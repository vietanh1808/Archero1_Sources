using System.Collections.Generic;
using DG.Tweening;
using Dxx.Util;
using UnityEngine;

public class SkillAlone2146 : SkillAloneBase
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

	private const float CheckStartFlySwordTime = 0.1f;

	private Tween delayCall;

	private List<Tween> allDelayCall;

	private List<long> clockIndexList;

	private SequencePool mSeqPool;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnEnterDemonStatus()
	{
	}

	private void TryStartFlySword()
	{
	}

	private void StartFlySword()
	{
	}

	private void CheckCastSkill()
	{
	}

	protected virtual BulletBase CreateFlySword(Vector3 startpos, float angle)
	{
		return null;
	}

	private long LoadSkill()
	{
		return 0L;
	}

	private void SkillEnd(long clockIndex)
	{
	}
}
