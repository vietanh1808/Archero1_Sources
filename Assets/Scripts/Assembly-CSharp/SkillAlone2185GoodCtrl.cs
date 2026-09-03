using System.Collections.Generic;
using Dxx.Util;
using UnityEngine;

public class SkillAlone2185GoodCtrl : SkillAloneAttrGoodBase
{
	[SerializeField]
	private Transform parent;

	[SerializeField]
	private Transform dmgCollider;

	[SerializeField]
	private Transform effect;

	[SerializeField]
	private ParticleSystem particle;

	[SerializeField]
	private AutoDespawn autoDespawn;

	[SerializeField]
	private SphereCollider collider;

	[SerializeField]
	private ParticleSystem warning;

	private float skillRadius;

	private int skillBuff;

	private Vector3 skillPos;

	private List<int> hitEnemy;

	private float attackTime;

	private float skillTime;

	private int reduceEnergy;

	private float delayTime;

	private SequencePool dmgSeq;

	public void Refresh(float skillRadius, int skillBuff, int reduceEnergy, Vector3 skillPos, float delayTime)
	{
	}

	private void RefreshTrans()
	{
	}

	private void RefreshPar()
	{
	}

	protected override void TriggerAllEntityEnter(EntityBase entity)
	{
	}

	protected override void TriggerAllEntityStay(EntityBase entity)
	{
	}

	protected override void TriggerEnter(EntityBase entity)
	{
	}

	private bool CanTrigger(EntityBase entity)
	{
		return false;
	}

	private bool CanAttackEnemy(int guid)
	{
		return false;
	}

	private void AttackEnemy(EntityBase entity)
	{
	}
}
