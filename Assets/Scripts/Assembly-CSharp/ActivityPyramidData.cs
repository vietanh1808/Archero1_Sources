using System.Collections.Generic;
using GameProtocol;

public class ActivityPyramidData
{
	public int tag;

	public int openLevel;

	public int starTime;

	public int gameEndTime;

	public int actEndTime;

	public ulong refreshTime;

	public int propID;

	public Dictionary<uint, STCommonQuickBuyData> quickBuyData;

	public Dictionary<uint, ushort> InitItemNum;
}
