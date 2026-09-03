public class AdventureTask1001 : AdventureTaskBase
{
	private int mHittedCount;

	private int HittedMaxCount;

	private void OnHitted(EntityBase source)
	{
	}

	protected override bool _IsTaskFinish()
	{
		return false;
	}

	public override string GetShowTaskString()
	{
		return null;
	}
}
