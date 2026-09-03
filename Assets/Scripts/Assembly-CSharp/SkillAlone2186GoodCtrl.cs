using System.Collections.Generic;
using Dxx.Util;
using UnityEngine;

public class SkillAlone2186GoodCtrl : SkillAloneAttrGoodBase
{
	[SerializeField]
	private Transform parent;

	[SerializeField]
	private Transform dmgCollider;

	[SerializeField]
	private Transform effect;

	[SerializeField]
	private ParticleSystem thunderCloudStart;

	[SerializeField]
	private ParticleSystem thunderCloudEnd;

	[SerializeField]
	private AutoDespawn autoDespawn;

	[SerializeField]
	private SphereCollider collider;

	[SerializeField]
	private ParticleSystem thunder;

	private float skillRadius;

	private Vector3 skillPos;

	private List<int> hitEnemy;

	private float attackTime;

	private float skillTime;

	private float dmgScale;

	private float moveScaleA;

	private float moveScaleB;

	private float moveSpeedScale;

	private float attackInterval;

	private SequencePool dmgSeq;

	private const float ParLastTime = 0.7f;

	private const float DelayRecycleTime = 0.2f;

	private EntityBase thunderTarget;

	private bool startMove;

	public void Refresh(float skillRadius, float moveScaleA, float moveScaleB, float moveSpeedScale, float attackInterval, float dmgScale, Vector3 skillPos)
	{
	}

	public void StartMove(EntityBase thunderTarget)
	{
	}

	public void RecycleGoodCtrl()
	{
	}

	private void ThunderActive(bool isActive)
	{
	}

	private void Update()
	{
	}

	private void RefreshTrans()
	{
	}

	private void RefreshPar(bool isThunderStart)
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
