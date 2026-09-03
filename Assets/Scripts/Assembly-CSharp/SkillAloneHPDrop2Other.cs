public class SkillAloneHPDrop2Other : SkillAloneBase
{
	private float factor;

	private float maxPercentage;

	protected int curDropCount;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void onCreatePlayer()
	{
	}

	private float GetDeltaPercentage(int dropCount)
	{
		return 0f;
	}

	protected virtual string GetAttr()
	{
		return null;
	}

	private void onDrop()
	{
	}

	protected void printLog(float oldPercentage, float newPercentage)
	{
	}

	protected virtual float GetAttrValue()
	{
		return 0f;
	}
}
