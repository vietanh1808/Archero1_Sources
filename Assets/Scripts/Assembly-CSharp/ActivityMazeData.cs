using System.Collections.Generic;
using GameProtocol;

public class ActivityMazeData
{
	public int tag;

	public int openLevel;

	public long starTime;

	public long gameEndTime;

	public long actEndTime;

	public ulong refreshTime;

	public int propID;

	public Dictionary<uint, STCommonQuickBuyData> quickBuyData;

	public Dictionary<uint, ushort> InitItemNum;
}
