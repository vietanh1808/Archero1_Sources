using System;
using System.Collections.Generic;
using Dxx.Util;
using UnityEngine;

public class SkillAlone2223GoodCtrl : SkillAloneAttrGoodBase
{
	[SerializeField]
	private Transform curSkill;

	[SerializeField]
	private AutoDespawn autoDespawn;

	[SerializeField]
	private SkillAlone2223ItemGoodCtrl skillItem;

	[SerializeField]
	private Transform skillItemParent;

	[SerializeField]
	private ParticleSystem maxPar;

	public const float RoundAngle = 360f;

	public const float TurnRoundNum = 3f;

	public const float RotateTime = 0.6f;

	public const float DelayRecycleTime = 1.5f;

	private SequencePool sequencePool;

	private List<SkillAlone2223RandomItemData> data;

	private Action aniCompleteAction;

	private LocalUnityObjctPool pool;

	private bool isInit;

	private bool isRandomMax;

	private void Init()
	{
	}

	private void InitPool()
	{
	}

	public void Refresh(List<SkillAlone2223RandomItemData> data, bool isRandomMax, Action aniCompleteAction)
	{
	}

	private void RefreshAni()
	{
	}

	public void RecycleCurSkill()
	{
	}

	protected override void TriggerEnter(EntityBase entity)
	{
	}

	private float GetRandomRoundAngle()
	{
		return 0f;
	}

	private void PlayMaxPar()
	{
	}
}
