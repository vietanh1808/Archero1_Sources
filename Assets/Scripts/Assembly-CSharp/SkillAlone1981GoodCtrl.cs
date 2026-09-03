using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1981GoodCtrl : SkillAloneAttrGoodBase
{
	[SerializeField]
	private Transform parent;

	[SerializeField]
	private Transform dmgCollider;

	[SerializeField]
	private Transform[] effect;

	[SerializeField]
	private ParticleSystem particle;

	private float radius;

	private float igniteDmgMult;

	private List<int> hitEnemy;

	private Vector3 pos;

	private float attackTime;

	private float skillTime;

	private int bulletID;

	public void Refresh(float radius, float igniteDmgMult, int bulletID, Vector3 pos)
	{
	}

	private void RefreshTrans()
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
