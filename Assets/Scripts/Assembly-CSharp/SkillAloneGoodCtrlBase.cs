using System;
using System.Collections.Generic;
using UnityEngine;

public class SkillAloneGoodCtrlBase : PauseObject
{
	protected SkillAloneBase mSkillAlone;

	protected EntityBase m_Entity;

	protected float time;

	protected float starttime;

	public Action<SkillAloneGoodCtrlBase> OnGoodDeInit;

	protected List<EntityBase> mList;

	private EntityType m_emEntityType;

	private bool m_bClearFlag;

	protected int[] debuffs;

	public void Init(EntityBase entity, SkillAloneBase alone, bool bClearFlag = false)
	{
	}

	public void Init(EntityBase entity, int[] debuffs, float time, bool bClearFlag = false)
	{
	}

	protected virtual void OnInit()
	{
	}

	public void DeInit()
	{
	}

	protected virtual void OnDeInit()
	{
	}

	protected override void UpdateProcess()
	{
	}

	protected virtual void SendBuffs()
	{
	}

	protected virtual bool CanHitEntity(EntityBase target)
	{
		return false;
	}

	private void OnTriggerEnter(Collider o)
	{
	}

	protected virtual void OnTrigger()
	{
	}

	private void OnTriggerExit(Collider o)
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}
}
