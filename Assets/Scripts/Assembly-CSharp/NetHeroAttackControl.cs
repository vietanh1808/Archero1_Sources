using UnityEngine;

public class NetHeroAttackControl : HeroAttackControl
{
	public enum AttackState
	{
		none = 0,
		moveing = 1,
		attacking = 2
	}

	public AttackState attState { get; protected set; }

	public PVPAimCtrlBase aimctl { get; protected set; }

	public virtual void SetAniCtlRot(Quaternion sor, Quaternion linedir)
	{
	}

	public void SetAimRendererSortingLayer(bool isInPvpGrass)
	{
	}

	public virtual void ChangeAttackState(ChangeAttackStateCommand pState)
	{
	}

	public virtual Quaternion GetAttackDir()
	{
		return default;
	}

	public virtual Quaternion GetLineDir()
	{
		return default;
	}

	public virtual bool CanAttackTarget()
	{
		return false;
	}

	public override void RotateHero(float angle)
	{
	}

	protected override void AutoAttackUpdate()
	{
	}

	protected void SetTarget(EntityBase tar, bool needPush = false)
	{
	}

	protected void UpdateMoveTarget()
	{
	}

	public virtual void OnRecAttackCommand(AttackCommand cmd)
	{
	}

	public virtual void OnOtherAttackStart()
	{
	}

	protected void UpdateTargetRed()
	{
	}
}
