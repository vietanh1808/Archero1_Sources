public class AdventureTask1002 : AdventureTaskBase
{
	private int mCritCount;

	private int CritMaxCount;

	private void OnCrit(EntityBase source, int hit)
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
