using System;
using System.Collections.Generic;

public class EntityLifeCtrl : EntityCtrlBase
{
	public Action<EntityBase, EntityBase> OnHitBabyAction;

	public float lastFightBackTime;

	private float pveFightBackCD;

	private float pvpFightBackCD;

	private float lastFightBackCheckTime;

	private float pvpFightBackCheckCD;

	private bool ForbiddenHitted => false;

	public override void OnStart(List<EBattleAction> actIds)
	{
	}

	public override void ExcuteCommend(EBattleAction id, object action)
	{
	}

	private void debugHit(long realhit)
	{
	}

	protected virtual void OnEntityHittedOnce(HitStruct data)
	{
	}

	private bool isImmunnityFromHurt(HitStruct otherhs)
	{
		return false;
	}

	private void ReboundHit(HitStruct data)
	{
	}

	public virtual void OnCheckDataOver(HitStruct data)
	{
	}

	protected virtual void StartChangeHP(HitStruct data)
	{
	}

	protected virtual void OnPlayEffect(HitStruct data)
	{
	}

	protected virtual void OnHPChanged(HitStruct data)
	{
	}

	private void OnDeadEvent(HitStruct data)
	{
	}

	private void OnEntityDeadBefore(BattleStruct.DeadStruct data)
	{
	}

	private void OnEntityDead(BattleStruct.DeadStruct data)
	{
	}

	private bool CanFightBack()
	{
		return false;
	}

	private bool CanFightBackCheck()
	{
		return false;
	}

	public override void OnRemove()
	{
	}
}
