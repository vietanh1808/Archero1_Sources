using System.Collections.Generic;
using XLua;

public class Exchange2023ConfigData
{
	public long startTime;

	public long endTime;

	public Dictionary<int, int> RoundDict;

	public int exchangeCount;

	public int needExchangeCount;

	public int curRound;

	public List<List<Exchange2023ItemConfigData>> shopItemAData;

	public List<Exchange2023ItemConfigData> shopItemBData;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge __Hotfix0_ResetExchangeLeftCountData;

	private static DelegateBridge __Hotfix0_UpdateTotalExchangeCount;

	private static DelegateBridge __Hotfix0_AddExchangeRound;

	private static DelegateBridge _c__Hotfix0_ctor;

	public static Exchange2023ConfigData Create(long startTime, long endTime, int curRound, int exchangeCount, int needExchangeCount, Dictionary<int, int> dict, List<List<Exchange2023ItemConfigData>> shopItemAData, List<Exchange2023ItemConfigData> shopItemBData)
	{
		return null;
	}

	public void ResetExchangeLeftCountData(int round)
	{
	}

	public void UpdateTotalExchangeCount(int totalExchangeCount)
	{
	}

	public void AddExchangeRound()
	{
	}
}
