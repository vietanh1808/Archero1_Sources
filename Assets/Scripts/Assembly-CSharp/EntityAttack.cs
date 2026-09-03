public class EntityAttack : EntityAttackBase
{
	public EntityBase CustomHatredTarget;

	private ActionBasic action;

	protected bool bInstall;

	protected virtual EntityBase HatredTarget => null;

	protected virtual bool condition => false;

	protected override void OnInit()
	{
	}

	protected override void DeInit()
	{
	}

	protected virtual void OnHatredTarget()
	{
	}

	public override void SetData(params object[] args)
	{
	}

	protected override void UpdateAttackAngle()
	{
	}

	protected virtual void AttackStart()
	{
	}

	protected void AttackEnd()
	{
	}

	public override void Install()
	{
	}

	protected void UnInstalls()
	{
	}
}
