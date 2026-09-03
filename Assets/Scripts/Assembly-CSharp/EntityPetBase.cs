using System;
using System.Collections.Generic;
using UnityEngine;

public class EntityPetBase : EntityCallBase
{
	public Action<BulletBase> OnEnableBullet1543;

	public const string ANIM_IDLE = "idle";

	public const string ANIM_ATTACK = "attack";

	public const string ANIM_MOVE = "move";

	public const string ANIM_SKILL = "skill";

	protected ActionBasic action;

	public BattlePetVO BattlePetVO { get; set; }

	public LocalSave.PetOne PetOne { get; private set; }

	protected override void OnInitAfter()
	{
	}

	protected override void OnTriggerEnterExtra(Collider collider)
	{
	}

	private EntityBase GetTarget(Collider other)
	{
		return null;
	}

	protected override void OnTriggerExitExtra(Collider collider)
	{
	}

	public void Init(LocalSave.PetOne petOne)
	{
	}

	protected override void OnInitBefore()
	{
	}

	protected override void OnInit()
	{
	}

	protected virtual void OnFlySetUp()
	{
	}

	protected override void StartInit()
	{
	}

	protected override void UpdateProcess(float delta)
	{
	}

	protected override void InitAnimations()
	{
	}

	public override void OnAfterAnimCtrlInitialized()
	{
	}

	protected void AddExtraAnimWrapper(string animName)
	{
	}

	protected virtual List<string> getAllAnims()
	{
		return null;
	}

	protected override void OnDeInit()
	{
	}
}
