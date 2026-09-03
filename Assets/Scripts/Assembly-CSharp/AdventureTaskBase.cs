using System;

public abstract class AdventureTaskBase
{
	public Action Event_GameFinish;

	public Action<int> Event_RecoverHP;

	public Action<EntityBase> Event_OnMiss;

	public Action<EntityBase, int> Event_OnCrit;

	public Action<EntityBase> Event_OnHitted;

	private Action<string> UIEvent_Update;

	public AdventureTaskBase()
	{
	}

	public bool IsTaskFinish()
	{
		return false;
	}

	public void SetUIUpdateEvent(Action<string> callback)
	{
	}

	protected void UpdateUI()
	{
	}

	protected virtual bool _IsTaskFinish()
	{
		return false;
	}

	public abstract string GetShowTaskString();
}
