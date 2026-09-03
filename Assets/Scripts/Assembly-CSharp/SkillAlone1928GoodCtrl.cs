using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1928GoodCtrl : SkillAloneAttrGoodBase
{
	[SerializeField]
	private GameObject parent;

	[SerializeField]
	protected Transform dmgColliderObj;

	[SerializeField]
	private Collider dmgCollider;

	[SerializeField]
	private Transform effect;

	[SerializeField]
	private ParticleSystem[] particle;

	protected float radius;

	protected float igniteDmgMult;

	private List<int> hitEnemy;

	protected float changeSpeed;

	protected Vector3 pos;

	private float originTime;

	protected float playSpeed;

	protected float time;

	private Dictionary<ParticleSystem, float> _dicOriginalSpeed;

	public void Refresh(float radius, float playSpeed, float igniteDmgMult, Vector3 pos)
	{
	}

	protected virtual void Init()
	{
	}

	protected void RefreshTrans()
	{
	}

	private void RefreshSize(float scale)
	{
	}

	protected override void TriggerEnter(EntityBase entity)
	{
	}

	protected override void TriggerStay(EntityBase entity)
	{
	}

	protected bool CanAttackEnemy(int guid)
	{
		return false;
	}

	protected virtual void AttackEnemy(EntityBase entity)
	{
	}

	public void Clear()
	{
	}

	private void DmgEnd()
	{
	}

	private void Update()
	{
	}

	protected virtual void OnUpdate()
	{
	}
}
