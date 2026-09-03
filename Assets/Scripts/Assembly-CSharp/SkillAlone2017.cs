public class SkillAlone2017 : SkillAloneBase
{
	private float lossHp2AtkRatio;

	private float maxLossHp2AtkPercent;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private AllHitActionVO OnAllHitAction(EntityBase enemy, HitStruct hs, HittedData hd)
	{
		return null;
	}
}
