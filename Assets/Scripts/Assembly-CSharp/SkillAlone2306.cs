public class SkillAlone2306 : SkillAloneBase
{
	private int energyPerHit;

	private const int waterBallFlySwordId = 5382;

	private bool isWearingTrident;

	private LocalSave.TridentDivinityV0 tridentDivinityV0 => null;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnHit(EntityBase enemy, HitStruct hs, HittedData ht)
	{
	}
}
