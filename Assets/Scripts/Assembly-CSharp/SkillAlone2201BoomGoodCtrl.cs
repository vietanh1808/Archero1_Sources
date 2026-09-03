using System.Collections.Generic;
using UnityEngine;

public class SkillAlone2201BoomGoodCtrl : SkillAloneAttrGoodBase
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

	private float skillRadius;

	private float makeDmg;

	private Vector3 skillPos;

	private List<int> hitEnemy;

	private float attackTime;

	private float skillTime;

	public void Refresh(Vector3 skillPos, float skillRadius, float makeDmg)
	{
	}

	private void RefreshTrans()
	{
	}

	private void RefreshPar()
	{
	}

	protected override void TriggerEnter(EntityBase entity)
	{
	}

	protected override void TriggerStay(EntityBase entity)
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
