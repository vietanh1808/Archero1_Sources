using System.Collections.Generic;
using UnityEngine;

public class SkillAlone2207GoodCtrl : SkillAloneAttrGoodBase
{
	[SerializeField]
	private Transform parent;

	[SerializeField]
	private Transform dmgCollider;

	[SerializeField]
	private Transform effect;

	[SerializeField]
	private AutoDespawn autoDespawn;

	private Vector3 createPos;

	private Vector3 createDir;

	private float bulletRadius;

	private int leftReboundCount;

	private float moveSpeed;

	private Vector3 originSkillPos;

	private float originSkillRadius;

	private ArtifactType artifactType;

	private float skillDmgScale;

	private List<int> hitEnemy;

	public void Refresh(ArtifactType artifactType, Vector3 createPos, Vector3 createDir, float bulletRadius, int leftReboundCount, float moveSpeed, Vector3 originSkillPos, float originSkillRadius, float skillDmgScale)
	{
	}

	private void Update()
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

	public void RecycleCurSkill()
	{
	}
}
