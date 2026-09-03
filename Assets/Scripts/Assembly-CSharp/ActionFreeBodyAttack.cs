public class ActionFreeBodyAttack : ActionBodyAttack
{
	private int attackCount;

	public int MaxAttackCount { get; set; }

	public ActionFreeBodyAttack(EntityBase entity)
		: base(null)
	{
	}

	protected override void OnInit()
	{
	}

	protected override void AttackEnd()
	{
	}

	private void increaseAttackCount()
	{
	}

	private void randomMaxAttackCount()
	{
	}

	protected override void OnForceEnd()
	{
	}
}
