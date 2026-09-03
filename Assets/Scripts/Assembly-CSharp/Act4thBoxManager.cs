using System;
using System.Collections.Generic;
using Dxx.Net;
using GameProtocol;
using XLua;

public sealed class Act4thBoxManager
{
	public enum BoxSource
	{
		Unknown = 0,
		Bag = 1,
		Queue = 2
	}

	public class QueueData
	{
		public BoxSource source;

		public int pos;

		public int itemid;

		public long start_time;

		private static DelegateBridge _c__Hotfix0_ctor;
	}

	public class BoxTaskData
	{
		public int tid;

		public int need;

		public int have;

		public bool done;

		public int count;

		public int type;

		public int pid;

		private static DelegateBridge _c__Hotfix0_ctor;
	}

	public class BoxRewardConfig
	{
		public int ID;

		public string Name;

		public int Time;

		public int[] Layer;

		public int[] DropID;

		public int[][] show;

		public int[][] show2;

		public int[][] show3;

		public int[][] show4;

		public int[][] show5;

		public int[][] show6;

		public int[][] show7;

		public int[][] show8;

		public int[][] show9;

		public int[][] show10;
	}

	private static Act4thBoxManager instance;

	private static object Locker;

	public long Time_Begin;

	public long Time_End;

	public bool isPullData;

	public int DropItemB;

	public int DropItemC;

	public int[] queueCostConfig;

	public int ExtraBoxTotal;

	public int ExtraBoxNeed;

	public int ExtraBoxMax;

	public int ExtraBoxHave;

	public int ExtraBoxItem;

	public int BoxLayerIndex;

	public int Queue_KeyNum;

	public Dictionary<int, QueueData> queueDataDict;

	public List<BoxTaskData> boxTaskDataList;

	public int ExchBoxCanMaxCount;

	public int ExchBoxId;

	public List<List<int>> ExchBoxNeedItemList;

	public List<List<int>> ExchBoxPercentList;

	public List<int> BoxIds;

	private BoxRewardConfig[] boxRewards;

	private static DelegateBridge __Hotfix0_get_Instance;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_uninit;

	private static DelegateBridge __Hotfix0_ReqS3;

	private static DelegateBridge __Hotfix0_ReqInfo;

	private static DelegateBridge __Hotfix0_OnResponseInfo;

	private static DelegateBridge __Hotfix0_requestAct4thBox;

	private static DelegateBridge __Hotfix0_initReqBoxData;

	private static DelegateBridge __Hotfix0_isOpen;

	private static DelegateBridge __Hotfix0_GetQueueQuickNeedKey;

	private static DelegateBridge __Hotfix0_parseQueueData;

	private static DelegateBridge __Hotfix0_parseBoxTaskData;

	private static DelegateBridge __Hotfix0_changeBoxTaskData;

	private static DelegateBridge __Hotfix0_GetBoxRewardConfigByBoxId;

	private static DelegateBridge __Hotfix0_sortBoxTask;

	private static DelegateBridge __Hotfix0_GetBoxTaskData;

	private static DelegateBridge __Hotfix0_GetQueueBoxCount;

	private static DelegateBridge __Hotfix0_GetQueueEmptyPos;

	private static DelegateBridge __Hotfix0_GetQueueData;

	private static DelegateBridge __Hotfix0_GetExchBoxPercent;

	private static DelegateBridge __Hotfix0_GetExchBoxNeedItem;

	private static DelegateBridge __Hotfix0_isShowRedPoint;

	private static DelegateBridge __Hotfix0_isCanGetExchangeBox;

	private static DelegateBridge __Hotfix0_isHaveTaskCanGet;

	private static DelegateBridge __Hotfix0_isHaveItemCanExchange;

	private static DelegateBridge __Hotfix0_isHaveQueueBoxCanGet;

	private static DelegateBridge __Hotfix0_GetBoxRewardPreview;

	private static DelegateBridge _c__Hotfix0_ctor;

	public static Act4thBoxManager Instance => null;

	public void init()
	{
	}

	public void uninit()
	{
	}

	public void ReqS3()
	{
	}

	public void ReqInfo(Action<bool> callback)
	{
	}

	public void OnResponseInfo(NetResponse response, Action<bool> callback)
	{
	}

	public void requestAct4thBox(int type, int pos, int rtype, int taskid, int boxid, int exchid, Action<bool> callback = null)
	{
	}

	public void initReqBoxData(STRespActivityOpenBox boxData)
	{
	}

	public bool isOpen()
	{
		return false;
	}

	public int GetQueueQuickNeedKey(int minute)
	{
		return 0;
	}

	private void parseQueueData(string jsons)
	{
	}

	private void parseBoxTaskData(STRespActivityOpenBox boxData)
	{
	}

	private void changeBoxTaskData(int taskid, bool state)
	{
	}

	public BoxRewardConfig GetBoxRewardConfigByBoxId(int boxId)
	{
		return null;
	}

	private void sortBoxTask()
	{
	}

	private BoxTaskData GetBoxTaskData(int taskid)
	{
		return null;
	}

	public int GetQueueBoxCount(int boxid)
	{
		return 0;
	}

	public int GetQueueEmptyPos()
	{
		return 0;
	}

	public QueueData GetQueueData(int pos)
	{
		return null;
	}

	public int GetExchBoxPercent(int boxid)
	{
		return 0;
	}

	public int GetExchBoxNeedItem(int equipid)
	{
		return 0;
	}

	public bool isShowRedPoint()
	{
		return false;
	}

	public bool isCanGetExchangeBox()
	{
		return false;
	}

	public bool isHaveTaskCanGet()
	{
		return false;
	}

	public bool isHaveItemCanExchange()
	{
		return false;
	}

	public bool isHaveQueueBoxCanGet()
	{
		return false;
	}

	public int[][] GetBoxRewardPreview(int boxid, int index)
	{
		return null;
	}
}
