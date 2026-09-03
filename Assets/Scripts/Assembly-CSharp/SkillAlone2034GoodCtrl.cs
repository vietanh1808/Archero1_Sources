using System;
using UnityEngine;

public class SkillAlone2034GoodCtrl : SkillAloneAttrGoodBase
{
	[SerializeField]
	private Transform curSkill;

	[SerializeField]
	private Transform effectParent;

	[SerializeField]
	private SphereCollider curCollider;

	[SerializeField]
	private AutoDespawn autoDespawn;

	private const float CheckSkillInterval = 0.1f;

	private float lastCheckTime;

	private Action<EntityBase> triggerEntity;

	private Action<EntityBase> triggerEntityExit;

	private bool CanTriggerEntity => false;

	public void Refresh(Vector3 pos, float radius, Action<EntityBase> triggerEntity, Action<EntityBase> triggerEntityExit)
	{
	}

	public void RecycleCurSkill()
	{
	}

	private void RefreshSize(float radius)
	{
	}

	protected override void TriggerEnter(EntityBase entity)
	{
	}

	protected override void TriggerAllEntityEnter(EntityBase entity)
	{
	}

	protected override void TriggerAllEntityStay(EntityBase entity)
	{
	}

	protected override void TriggerAllEntityExit(EntityBase entity)
	{
	}
}
