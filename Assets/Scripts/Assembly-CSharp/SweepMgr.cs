using System;
using System.Collections.Generic;
using TableTool;

public sealed class SweepMgr : CInstance<SweepMgr>
{
	private bool isBusy;

	public uint[] vecShopIds;

	public long timeToday;

	public List<Drop_DropModel.DropData> Drops { get; private set; }

	public Dictionary<int, int> ChapFinishs { get; private set; }

	public Dictionary<int, int> HeroChapFinishs { get; private set; }

	public Dictionary<int, int> HellChapFinishs { get; private set; }

	public int SweepCnt { get; private set; }

	public int SweepCntAdd { get; private set; }

	public Dictionary<int, int> HatchSteps { get; private set; }

	public Dictionary<int, int> MonKills { get; private set; }

	public bool isUnlockSweep => false;

	private bool CanSweep => false;

	public int TotalSweepCount => 0;

	public void ReqBattleSweep(ushort nType, ushort nId, Action callBack = null)
	{
	}

	public bool isUnlockStageSweep(int stage, bool isHero = false)
	{
		return false;
	}

	public bool isUnlockStageSweep(int stage, GameMode mode)
	{
		return false;
	}

	public int GetStageSweepCount(int stage)
	{
		return 0;
	}

	public void CheckSweep()
	{
	}
}
