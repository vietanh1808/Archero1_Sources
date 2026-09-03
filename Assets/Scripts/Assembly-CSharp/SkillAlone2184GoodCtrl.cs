using System;
using UnityEngine;

public class SkillAlone2184GoodCtrl : SkillAloneAttrGoodBase
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

	private Vector3 skillPos;

	private Action<EntityHero> triggerEnter;

	private Action<EntityHero> triggerExit;

	private bool allowTrigger;

	public void Refresh(float skillRadius, Vector3 skillPos, Action<EntityHero> triggerEnter, Action<EntityHero> triggerExit, bool allowTrigger)
	{
	}

	public void SetAllowTrigger(bool allow)
	{
	}

	private void RefreshTrans()
	{
	}

	private void RefreshPar()
	{
	}

	private bool CanTrigger(EntityBase entity)
	{
		return false;
	}

	protected override void TriggerAllEntityEnter(EntityBase entity)
	{
	}

	protected override void TriggerAllEntityExit(EntityBase entity)
	{
	}

	protected override void TriggerEnter(EntityBase entity)
	{
	}
}
