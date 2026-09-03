public class AIFireDragon : AIDragonBase
{
	private const int BULLET_ID = 1202;

	private float totalTime;

	private int attackLoopCount;

	protected override float deltaSpeed => 0f;

	protected override int AttackLoopCount => 0;

	protected override void OnInit1()
	{
	}

	public override void BeforeStartAttack()
	{
	}

	protected override void BeforeSkillAttackPre()
	{
	}

	protected override void AfterSkillAttackPre()
	{
	}

	protected override void BeforeSkillContinuousAttack()
	{
	}

	protected override void AfterSkillContinuousAttack()
	{
	}

	protected override void BeforeSkillAttackEnd()
	{
	}

	protected override void AfterSkillAttackEnd()
	{
	}

	protected override AIBase.ActionSequence getAnimSequenceAction()
	{
		return null;
	}
}
