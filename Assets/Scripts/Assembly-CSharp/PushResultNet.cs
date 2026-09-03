using System.Collections.Generic;
using GameProtocol;
using TableTool;

public class PushResultNet
{
	public bool isDone;

	public bool isSuccess;

	public int errorCode;

	public int[] pushedCounts;

	public List<Drop_DropModel.DropData> droppedRewards;

	public bool triggerRefresh;

	public STActivityPushPillarUpgradeEvent[] upgradeEvents;

	public int pushedColumn;

	public int moveCount;
}
