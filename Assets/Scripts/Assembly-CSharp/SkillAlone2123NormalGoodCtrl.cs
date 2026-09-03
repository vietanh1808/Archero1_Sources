using System.Collections.Generic;
using UnityEngine;

public class SkillAlone2123NormalGoodCtrl : SkillAloneAttrGoodBase
{
	[SerializeField]
	private Transform parent;

	[SerializeField]
	private Transform dmgCollider;

	[SerializeField]
	private Transform effect;

	[SerializeField]
	private ParticleSystem selfSeePar;

	[SerializeField]
	private ParticleSystem enemySeePar;

	private ParticleSystem curUseParticle;

	private float radius;

	private float igniteDmgMult;

	private List<int> hitEnemy;

	private Vector3 pos;

	private float attackTime;

	private float skillTime;

	private bool isShowSelf;

	public void Refresh(float radius, float igniteDmgMult, Vector3 pos, bool isShowSelf)
	{
	}

	private void RefreshStatus()
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
