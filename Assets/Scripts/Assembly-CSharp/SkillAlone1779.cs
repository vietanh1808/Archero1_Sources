public class SkillAlone1779 : SkillAloneBase
{
	private int lightningBaseProbability;

	private float lightningImproveProbability;

	private float lightningFirstDmgRatio;

	private float lightningDmgDecreaseRatio;

	private float lightningDmgMinRatio;

	private int ejectCount;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}

	private void SendCreateLightingMsg()
	{
	}

	private void SyncCreateLighting(EntityBase entity)
	{
	}

	private void OnRecover(long hp)
	{
	}

	private void OnAttack()
	{
	}

	private long CalcLightningProbability()
	{
		return 0L;
	}

	private void RandomLightning()
	{
	}

	private void CreateLightning(EntityBase entity)
	{
	}
}
