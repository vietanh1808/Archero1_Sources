public class SkillAlone2135 : SkillAloneBase
{
	private float CONFIG_DISTANCE;

	private float CONFIG_HP_RECOVER_PERCENT;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private HitType OnChangeHitType(EntityBase entity, HitStruct hs)
	{
		return HitType.Normal;
	}

	private void OnHit(EntityBase entity, HitStruct hs, HittedData data)
	{
	}
}
