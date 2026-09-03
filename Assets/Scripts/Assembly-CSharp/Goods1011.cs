using System.Collections.Generic;
using Dxx.Util;
using UnityEngine;

public class Goods1011 : GoodsBase
{
	[SerializeField]
	private float skillCreateInterval;

	[SerializeField]
	private float skillLastTime;

	[SerializeField]
	private float skillDmgInterval;

	[SerializeField]
	private GameObject skillParentObj;

	[SerializeField]
	private GameObject skillObj;

	[SerializeField]
	private GameObject modelObj;

	[SerializeField]
	private float skillDir;

	[SerializeField]
	private Goods1011EffectCtrl effectCtrl;

	[SerializeField]
	private GoodsFireType goodsType;

	[SerializeField]
	private ParticleSystem readyPar;

	[SerializeField]
	private ParticleSystem readyDonePar;

	[SerializeField]
	private ParticleSystem skillPar;

	[SerializeField]
	private ParticleSystem skillEndPar;

	private SequencePool skillLastSeqPool;

	private SequencePool skillCreateSeqPool;

	private Dictionary<int, float> hitEnemy;

	private int CurGoodsMakeBuff => 0;

	protected override void Init()
	{
	}

	protected override void OnDeInit()
	{
	}

	public override void ChildTriggerEnter(GameObject o)
	{
	}

	private void StartFireLoop()
	{
	}

	private void StartSkill()
	{
	}

	private void StopFire()
	{
	}

	private void StopAllFire()
	{
	}

	private void ClearAll()
	{
	}

	private void TryAttackEnemy(GameObject triggerEntity)
	{
	}

	private void CheckAttackEnemy(EntityBase hero)
	{
	}

	private bool CanAttackEnemy(int guid)
	{
		return false;
	}

	private void AttackEnemy(EntityBase entity)
	{
	}
}
