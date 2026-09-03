public class SkillAlone4060 : SkillAloneBase
{
	protected float CONFIG_ATTACK_SPEED_ADD_PERCENT;

	protected float CONFIG_ATTACK_SPEED_MAX;

	protected float CONFIG_MOVE_SPEED_PERCENT;

	protected float CONFIG_MOVE_SPEED_MAX;

	private float CONFIG_INTERVAL;

	private float m_fLastHittedTime;

	private float m_fTotalAttackSpeedAdded;

	private float m_fTotalMoveSpeedAdded;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHitted(EntityBase entity, long hit)
	{
	}
}
