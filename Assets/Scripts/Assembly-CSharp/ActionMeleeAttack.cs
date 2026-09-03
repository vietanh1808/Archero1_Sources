public class ActionMeleeAttack : ActionBasic.ActionBase
{
	public AIBase aiBase;

	public EntityBase attackTarget;

	private AIBase.ActionSequence seq;

	public AIBase.ActionSequence Seq => null;

	public ActionMeleeAttack(EntityBase _entity)
	{
	}

	private void initSeq()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnUpdate()
	{
	}

	protected override void OnForceEnd()
	{
	}

	protected override void OnDeInit()
	{
	}
}
