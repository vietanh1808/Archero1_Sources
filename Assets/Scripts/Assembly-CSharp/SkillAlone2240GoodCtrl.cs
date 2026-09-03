using System;
using System.Collections.Generic;
using UnityEngine;

public class SkillAlone2240GoodCtrl : SkillAloneAttrGoodBase
{
	[SerializeField]
	private Transform curSkill;

	[SerializeField]
	private Transform effectParent;

	[SerializeField]
	private AutoDespawn autoDespawn;

	[SerializeField]
	private ParticleSystem particle;

	private const float CheckSkillInterval = 0.1f;

	private float lastCheckTime;

	private Action<EntityBase> triggerEntityEnter;

	private Action<EntityBase> triggerEntityExit;

	private Vector3 pos;

	private float radius;

	private bool CanTriggerEntity => false;

	private List<EntityBase> AllEntity => null;

	private List<EntityBase> AllActiveEntity => null;

	public void Refresh(Vector3 pos, float radius, Action<EntityBase> triggerEntityEnter, Action<EntityBase> triggerEntityExit)
	{
	}

	private void RefreshPar()
	{
	}

	private void RefreshData()
	{
	}

	public void RecycleCurSkill()
	{
	}

	private void RefreshSize()
	{
	}

	protected override void TriggerEnter(EntityBase entity)
	{
	}

	private void Skill2214Update(float delta)
	{
	}
}
