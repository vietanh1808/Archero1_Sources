using System;

public class AdventureTaskMgr : CInstance<AdventureTaskMgr>
{
	private AdventureTaskBase mAdventureTask;

	private int mTaskID;

	public void InitAdventureTask()
	{
	}

	private int GetRandomTaskID()
	{
		return 0;
	}

	public void SetUIUpdateEvent(Action<string> callback)
	{
	}

	public string GetShowTaskString()
	{
		return null;
	}

	public bool IsTaskFinish()
	{
		return false;
	}

	public void OnHitted(EntityBase source)
	{
	}
}
