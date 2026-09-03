public class ActionMeleeAttack2024 : ActionBasic.ActionBase
{
	public AI2024 aiBase;

	protected EntityBase attackTarget;

	private const int ATTACK_INTERVAL = 100;

	private AIBase.ActionSequence seq;

	public AIBase.ActionSequence Seq => null;

	public ActionMeleeAttack2024(EntityBase _entity)
	{
	}

	private void initSeq()
	{
	}

	protected override void OnForceEnd()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnUpdate()
	{
	}

	protected override void OnDeInit()
	{
	}
}
