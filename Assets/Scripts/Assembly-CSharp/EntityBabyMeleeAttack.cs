public class EntityBabyMeleeAttack : EntityAttack
{
	protected override EntityBase HatredTarget => null;

	protected override bool condition => false;

	protected override void UpdateAttackAngle()
	{
	}
}
