using System;
using Newtonsoft.Json;
using XLua;

[Serializable]
public class FishingTaskItemConfigData
{
	public int ID;

	public int Type;

	public int UnlockId;

	public int CondTypeArgs;

	public int[][] Rewards;

	public int Position;

	[JsonIgnore]
	public int progress;

	[JsonIgnore]
	public bool isDone;

	private static DelegateBridge __Hotfix0_UpdateStatus;

	private static DelegateBridge __Hotfix0_UpdateData;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void UpdateStatus()
	{
	}

	public void UpdateData(int progress, bool isDone)
	{
	}
}
