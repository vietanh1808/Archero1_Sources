using System;
using System.Collections.Generic;
using UnityEngine;

public class SkillAlone2214GoodCtrl : SkillAloneAttrGoodBase
{
	[SerializeField]
	private Transform curSkill;

	[SerializeField]
	private Transform effectParent;

	[SerializeField]
	private AutoDespawn autoDespawn;

	[SerializeField]
	private ParticleSystem selfPar;

	[SerializeField]
	private ParticleSystem enemyPar;

	private const float CheckSkillInterval = 0.1f;

	private float lastCheckTime;

	private Action<EntityBase> triggerEntityEnter;

	private Action<EntityBase> triggerEntityExit;

	private Vector3 pos;

	private EntityBase triggerEntity;

	private float radius;

	private Quaternion rotate;

	private float extraRadius;

	private Action<EntityBase> extraTriggerEntityEnter;

	private Action<EntityBase> extraTriggerEntityExit;

	private bool isSelf;

	private bool CanTriggerEntity => false;

	private List<EntityBase> AllEntity => null;

	private List<EntityBase> AllActiveEntity => null;

	public void Refresh(bool isSelf, Vector3 pos, Quaternion rotate, float radius, Action<EntityBase> triggerEntityEnter, Action<EntityBase> triggerEntityExit, float extraRadius, Action<EntityBase> extraTriggerEntityEnter, Action<EntityBase> extraTriggerEntityExit)
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

	public void SetSize(float size)
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
