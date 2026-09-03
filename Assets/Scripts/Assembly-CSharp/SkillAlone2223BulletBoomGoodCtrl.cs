using System.Collections.Generic;
using UnityEngine;

public class SkillAlone2223BulletBoomGoodCtrl : SkillAloneAttrGoodBase
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

	private float makeDmgScale;

	private Vector3 skillPos;

	private List<int> hitEnemy;

	private float attackTime;

	private float skillTime;

	private ArtifactType artifactType;

	public void Refresh(ArtifactType artifactType, Vector3 skillPos, float skillRadius, float makeDmgScale)
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
