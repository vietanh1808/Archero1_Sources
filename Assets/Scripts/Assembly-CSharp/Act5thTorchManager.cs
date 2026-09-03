using System;
using System.Collections.Generic;
using GameProtocol;
using TableTool;

public class Act5thTorchManager
{
	public const int DonateMatId = 33088;

	private static Act5thTorchManager instance;

	private static object Locker;

	public int CurSchedule;

	public int NextTargetRate;

	private STActivityFifthAnniversaryAward mSeverData;

	private Act5thTorchAllRewardData mAct5ThTorchAllRewardData;

	public static Act5thTorchManager Instance => null;

	public long EndTime => 0L;

	public long StartTime => 0L;

	public bool IsNoData => false;

	public bool IsOpen => false;

	public bool IsNotStart => false;

	public bool IsEnd => false;

	public int DonateBoxReviceCnt => 0;

	public int MaxDonateNum => 0;

	public int CurDonateNum => 0;

	public bool IsHaveRed => false;

	public int donateMatNum
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private Act5thTorchManager()
	{
	}

	public void SetSeverData(STActivityFifthAnniversaryAward data)
	{
	}

	private void RefreshNextTargetRate()
	{
	}

	public Act5thTorchAllRewardItemData GetNextTargetReward()
	{
		return null;
	}

	public void ReqDoante(int count, Action<List<Drop_DropModel.DropData>> callBack)
	{
	}

	public void ReqAllReward(int id)
	{
	}

	public void ReqDoanteBoxReward(int id)
	{
	}

	public Act5thTorchAllRewardData GetAllReward()
	{
		return null;
	}

	public int DonatePerCount()
	{
		return 0;
	}

	public int CurDonatePerCount()
	{
		return 0;
	}
}
