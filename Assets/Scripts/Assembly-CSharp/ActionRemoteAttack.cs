public class ActionRemoteAttack : ActionBasic.ActionBase
{
	public AIBase aiBase;

	public EntityBase attackTarget;

	private AIBase.ActionSequence seq;

	public AIBase.ActionSequence Seq => null;

	public virtual bool CanFlee => false;

	public ActionRemoteAttack(EntityBase _entity)
	{
	}

	private void initSeq()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnForceEnd()
	{
	}

	protected override void OnUpdate()
	{
	}

	protected override void OnDeInit()
	{
	}
}
