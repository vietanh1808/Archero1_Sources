public class AILavaDragon : AIDragonBase
{
	private const int PART_ID = 1829;

	public const int ELITE_BABY_WEAPON_ID = 1216;

	public const int BABY_WEAPON_ID = 1215;

	private EntityBase m_Target;

	private float deltaAttackingSpeed;

	protected override void AfterSkillAttackPre()
	{
	}

	protected override void OnUpdate(float delta)
	{
	}

	protected override void BeforeSkillContinuousAttack()
	{
	}

	protected override void AfterSkillContinuousAttack()
	{
	}

	private void try2CallDragonBaby()
	{
	}

	public static float GetAttackRatio(int weaponID)
	{
		return 0f;
	}
}
