using System;
using System.Collections.Generic;
using GameProtocol;
using TableTool;

public sealed class SuperRouletteMgr : CInstance<SuperRouletteMgr>
{
	public ushort activityType;

	public uint Tag;

	public ulong EndTime;

	public ushort NormalFreeCount;

	public ushort NormalCount;

	public uint NormalCost;

	public ushort SuperFreeCount;

	public ushort SuperCount;

	public uint SuperCost;

	public List<CActivitySuperRouletteTask> RouletteTask;

	public List<CActivitySuperRouletteTask> FinishTask;

	public List<CActivitySuperRouletteTask> CanFinishTask;

	public List<CActivitySuperRouletteTask> NotFinishTask;

	public List<Drop_DropModel.DropData> Droplist;

	public List<PlayerCharacter_Skin> SkinList;

	public List<SuperTurntableData> NormalTurntable;

	public List<SuperTurntableData> SuperTurntable;

	public ushort IsSuper;

	public ushort RandIndex;

	public ushort Type;

	public uint TotalCount;

	public uint CountRewardLog;

	public ushort SuperRewardIndex;

	public List<SuperRewardData> SuperReward;

	public bool isFirst;

	public static long timeToday;

	public bool isBusy;

	private bool _isUIBusy;

	private Queue<CRespActivitySuperRoulette> pendingData;

	public bool isUIBusy
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void FlushRouletteTask()
	{
	}

	public void GetRouletteTask(CRespActivitySuperRoulette roulettedata)
	{
	}

	private void RunRouletteTask(CRespActivitySuperRoulette roulettedata)
	{
	}

	public void GetTaskStage(string rewardnum)
	{
	}

	public string BitConvert(uint Log, int count)
	{
		return null;
	}

	public void GetSuperRouletteMsg(ushort type = 1, ushort index = 0, bool isOpen = false, ushort CountRewardIndex = 0, Action callback = null)
	{
	}

	private List<SuperTurntableData> GetGiftOne(string table)
	{
		return null;
	}

	private List<SuperRewardData> GetSuperReward(string table)
	{
		return null;
	}

	private void ResetSuperReward(string rewardnum)
	{
	}

	public bool IfCanShow()
	{
		return false;
	}

	public bool CanShow()
	{
		return false;
	}

	public int GetRewardNeedTotalCount()
	{
		return 0;
	}
}
