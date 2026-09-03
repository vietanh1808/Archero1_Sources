public class SkillAlone1447 : SkillAloneBase
{
	private ActionTrackEnemies track;

	private float maxFactor;

	private float dizzyFactor;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private float onEnemyHitted(EntityBase entity, HitStruct hit)
	{
		return 0f;
	}
}
