using System;
using Newtonsoft.Json;
using XLua;

[Serializable]
public class Vault2023GameShowRewardItemConfigData
{
	public int ID;

	[JsonIgnore]
	public int haveCount;

	public int[][] Need;

	public int[][] Reward;

	public int Position;

	private static DelegateBridge __Hotfix0_SyncHaveCount;

	private static DelegateBridge __Hotfix0_AddHaveCount;

	private static DelegateBridge __Hotfix0_ResetGame;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void SyncHaveCount(int haveCount)
	{
	}

	public void AddHaveCount()
	{
	}

	public void ResetGame()
	{
	}
}
