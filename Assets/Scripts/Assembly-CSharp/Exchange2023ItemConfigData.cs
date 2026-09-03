using System;
using Newtonsoft.Json;
using XLua;

[Serializable]
public class Exchange2023ItemConfigData
{
	public int ID;

	public int[][] Need;

	public int Count;

	public int[][] Reward;

	public int Position;

	[JsonIgnore]
	public int leftBuyCount;

	private static DelegateBridge __Hotfix0_AddBuyCount;

	private static DelegateBridge __Hotfix0_UpdateData;

	private static DelegateBridge __Hotfix0_UpdateLeftExchangeCount;

	private static DelegateBridge __Hotfix0_ResetBuyCount;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void AddBuyCount(int count)
	{
	}

	public void UpdateData(int count, int leftBuyCount, int[][] need, int[][] reward)
	{
	}

	public void UpdateLeftExchangeCount(int leftExchangeCount)
	{
	}

	public void ResetBuyCount()
	{
	}
}
