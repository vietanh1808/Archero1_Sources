using System;
using System.Collections.Generic;
using GameProtocol;
using TableTool;

public sealed class FarmManager : CInstance<FarmManager>
{
	public class VisitData
	{
		public ulong uid;

		public string name;

		public int head;

		public int headFrame;

		public ulong headFrameTime;

		public int type;

		public int lId;

		public int monsterId;

		public ulong time;

		public bool isWin;
	}

	public Dictionary<int, FarmOneData> farmEventDict;

	public bool isPullFarmEvent;

	public bool isEnterFarm;

	public bool isClickTabNormal;

	public bool isClickTabBoss;

	public bool haveOpenVisitFunc;

	public bool isMe;

	public int headId;

	public int headBoxId;

	public string visitName;

	public ulong visitUid;

	public ulong headBoxTime;

	public List<LocalSave.EggData> visitEggs;

	public List<LocalSave.MonsterData> visitMonsterList;

	public Dictionary<int, FarmOneData> visitFarmEvents;

	public int haveVisit;

	public int haveAd;

	public int monthCardAddVisitCount;

	public List<VisitData> visitDatas;

	public int haveFindState;

	public List<LocalSave.MonsterData> showMonsterList;

	public List<LocalSave.MonsterData> showMonsterList_Normal;

	public List<LocalSave.MonsterData> showMonsterList_Boss;

	public HashSet<int> hatchTempSet;

	public List<LocalSave.MonsterData> CurrentMonsters => null;

	public Dictionary<int, FarmOneData> CurrentFarmEvents => null;

	public void requestFarm(int type, int eventId, Action action = null)
	{
	}

	public string getFarmOneName(int type)
	{
		return null;
	}

	public void ShowFarmReward(List<Drop_DropModel.DropData> list, string title)
	{
	}

	public bool haveMainFarmRP()
	{
		return false;
	}

	public FarmOneData getFarmOneData(int eventId)
	{
		return null;
	}

	public void clearUsedEvent()
	{
	}

	public void SendFarmEventFinish(int eventId)
	{
	}

	public void setIsMe(bool isme)
	{
	}

	public void removeFarmEvent(int eventId)
	{
	}

	public void requestVisit(int type, int eventId, ulong rowid, Action action = null)
	{
	}

	public void requestHandleEvent(int eventId)
	{
	}

	public int sdkUsedLeftVisitTimes()
	{
		return 0;
	}

	public void setShowMonsterList()
	{
	}

	public void addToHatchTempSet(int mid)
	{
	}

	public int GetHideMonsterCount(int type, int count)
	{
		return 0;
	}

	public void requestMyCleanAll(Action<CRespFarm, int> action = null)
	{
	}

	public void requestOtherCleanAll(Action<CRespFarmPlay, int> action = null)
	{
	}
}
