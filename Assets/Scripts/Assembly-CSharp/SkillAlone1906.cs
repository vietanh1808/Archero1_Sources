public class SkillAlone1906 : SkillAlonePetBase
{
	private float dropRate;

	private float enemyRadius;

	private int enemyDebuffId;

	private float doubleDropRate;

	private int dropCount;

	private int dropFactor;

	protected override void OnInstall(params object[] args)
	{
	}

	protected override void OnUninstall()
	{
	}

	protected virtual void ParseArgs()
	{
	}

	private void OnPetDisappear(BattlePetVO vo)
	{
	}
}
