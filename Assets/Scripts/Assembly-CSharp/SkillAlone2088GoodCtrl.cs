using System;
using System.Collections.Generic;
using UnityEngine;

public class SkillAlone2088GoodCtrl : SkillAloneAttrGoodBase
{
	[SerializeField]
	private Transform curSkill;

	[SerializeField]
	private Transform effectParent;

	[SerializeField]
	private AutoDespawn autoDespawn;

	private const float CheckSkillInterval = 0.1f;

	private float lastCheckTime;

	private Action<EntityBase> triggerEntity;

	private Action<EntityBase> triggerEntityExit;

	private float radius;

	private bool CanTriggerEntity => false;

	private List<EntityPartBodyBase> AllChangeMonster => null;

	public void Refresh(Vector3 pos, float radius, Action<EntityBase> triggerEntity, Action<EntityBase> triggerEntityExit)
	{
	}

	public void RecycleCurSkill()
	{
	}

	public void SetSize(float size)
	{
	}

	private void RefreshSize()
	{
	}

	protected override void TriggerEnter(EntityBase entity)
	{
	}

	private void Skill2088Update(float delta)
	{
	}
}
