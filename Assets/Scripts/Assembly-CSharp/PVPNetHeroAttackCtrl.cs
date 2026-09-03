using UnityEngine;

public class PVPNetHeroAttackCtrl : NetHeroAttackControl
{
	private int fixAngleValue;

	private int needAttackCount;

	private float attackTimer;

	protected override void OnStart()
	{
	}

	protected virtual void InitAimCtl()
	{
	}

	protected override void OnDestroys()
	{
	}

	protected virtual void onMove(bool value)
	{
	}

	public override void SetAniCtlRot(Quaternion sor, Quaternion linedir)
	{
	}

	public override Quaternion GetAttackDir()
	{
		return default;
	}

	public override Quaternion GetLineDir()
	{
		return default;
	}

	protected override void AutoAttackUpdate()
	{
	}

	protected virtual void UpdateMoveing()
	{
	}

	protected virtual void UpdateNoMoveing()
	{
	}

	protected void SendAttackStateCmd(AttackState pState)
	{
	}

	public override void ChangeAttackState(ChangeAttackStateCommand pCmd)
	{
	}

	protected virtual void UpdateAniCtrl()
	{
	}

	protected virtual void UpdateAttacking()
	{
	}

	private void UpdateNoSelfAttack()
	{
	}

	protected virtual void AttackTarget()
	{
	}

	protected virtual void DoAttack()
	{
	}

	protected virtual void DoAttackByCmd(float angle)
	{
	}

	protected virtual void DoAttackByAngle(float angle, EntityBase targetobj)
	{
	}

	public override bool CanAttackTarget()
	{
		return false;
	}

	public override void OnRecAttackCommand(AttackCommand cmd)
	{
	}

	public override void OnOtherAttackStart()
	{
	}
}
