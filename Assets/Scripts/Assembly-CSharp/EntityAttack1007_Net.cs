public class EntityAttack1007_Net : EntityAttackBase
{
	private ActionBattle action;

	private bool bInstall;

	protected float delaytime;

	protected RedLinesCtrl mRedLinesCtrl;

	protected virtual float linetimemin => 0f;

	protected virtual float linetimemax => 0f;

	protected virtual int count => 0;

	protected virtual float perangle => 0f;

	protected virtual float offsetX => 0f;

	protected virtual int ReboundCount => 0;

	protected virtual bool ThroughWall => false;

	protected override void OnInit()
	{
	}

	protected virtual void InitRedLines()
	{
	}

	protected override void DeInit()
	{
	}

	private void RedLineDeInit()
	{
	}

	public override void SetData(params object[] args)
	{
	}

	private void AttackStart()
	{
	}

	protected override void UpdateProcess(float delta)
	{
	}

	private void AttackEnd()
	{
	}

	public override void Install()
	{
	}

	private void OnUnInstalls()
	{
	}
}
