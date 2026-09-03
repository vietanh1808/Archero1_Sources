using System;
using System.Collections.Generic;
using UnityEngine;

public class EntityPartBodyBase : EntityCallBase
{
	public enum CreateSourceEnum
	{
		Unkown = 0,
		SkillMagicBook = 1
	}

	protected ActionBasic action;

	protected ConditionTime mCondition;

	public Action<EntityPartBodyBase, int> OnRemoveEvent;

	public bool bGotoRoomRemove;

	[Header("是否需要分身有抵挡子弹的效果")]
	[SerializeField]
	private bool _BulletTrigger;

	public CreateSourceEnum CreateSource { get; set; }

	protected override string ModelPath => null;

	public bool BulletTrigger => false;

	public virtual bool IgnorePartBodyShader => false;

	public void Init(int id, float time)
	{
	}

	protected override void OnInitBefore()
	{
	}

	protected override void SetShadowSetting()
	{
	}

	protected override void OnInit()
	{
	}

	protected virtual void InitAtkControl()
	{
	}

	protected virtual void InitMoveControl()
	{
	}

	protected override void StartInit()
	{
	}

	protected virtual int GetDefaultHPSliderId()
	{
		return 0;
	}

	protected virtual bool IsInvincible()
	{
		return false;
	}

	protected virtual bool GetColliderEnabled()
	{
		return false;
	}

	protected virtual bool CanShowHP()
	{
		return false;
	}

	protected virtual bool CanPlayBirthCallEffect()
	{
		return false;
	}

	protected virtual bool CanPlayDisappearEffect()
	{
		return false;
	}

	protected override void InitAnimations()
	{
	}

	protected override void OnDeInitLogic()
	{
	}

	protected virtual void PlayCallEffect()
	{
	}

	public void SetAliveTime(float time)
	{
	}

	public float GetAliveTime()
	{
		return 0f;
	}

	public void AddAliveTime(float time)
	{
	}

	protected override void UpdateProcess(float delta)
	{
	}

	protected virtual void PartBodyUpdate(float delta)
	{
	}

	public void DestroyPartBody()
	{
	}

	protected virtual void TimeUp()
	{
	}

	private new void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	protected virtual void OnGotoNextRooms(RoomGenerateBase.Room room)
	{
	}

	protected override void OnDeInit()
	{
	}

	protected void OnDeInitInterval()
	{
	}

	public void SetParentAttackSpeed(float parentValue)
	{
	}

	public void InheritParentAttackSpeed(float percent)
	{
	}

	public void LearnParentSkillIds(int[] skillIds)
	{
	}

	public void LearnRandomDebuffs(int[] randomDebuffs)
	{
	}

	public virtual void UpdateElitePartBody()
	{
	}

	public void SetPartBodyCompsVisible(List<string> visibleList, bool visible)
	{
	}
}
