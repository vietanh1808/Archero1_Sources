using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using GameProtocol;
using TableTool;

public class SkyLanternMgr
{
	public class SkyLanternConfig
	{
		public SkyLanternBaseConfig[] Base;

		public SkyLanternSamllPoolConfig[] SmallPool;

		public SkyLanternBigPoolConfig[] BigPool;

		public SkyLanternShowRewardConfig[] ShowReward;
	}

	public class SkyLanternBaseConfig
	{
		public int Tag;

		public int Version;

		public int StartTime;

		public int GameEndTime;

		public int EndTime;

		public int OpenGameLevel;

		public int[][] Item;

		public int[] Layer;
	}

	public class SkyLanternSamllPoolConfig
	{
		public int ID;

		public int Group;

		public int IfBig;

		public int Position;

		public int Weight;

		public int ShowWeight;

		public int[][] Reward1;

		public int[][] Reward2;

		public int[][] Reward3;
	}

	public class SkyLanternBigPoolConfig
	{
		public int ID;

		public int Position;

		public int Weight;

		public int ShowWeight;

		public int[][] Reward1;

		public int[][] Reward2;

		public int[][] Reward3;

		public int Img;
	}

	public class SkyLanternShowRewardConfig
	{
		public int ID;

		public int MinLevel;

		public int MaxLevel;

		public int OrderID;

		public int[][] Reward;

		public float Transform;
	}

	private static SkyLanternMgr instance;

	public SkyLanternConfig S3Config;

	private STRespActivityLampWish severData;

	[CompilerGenerated]
	private Action<bool> m_OnReqInfoCallBack;

	[CompilerGenerated]
	private Action<uint[], uint, List<Drop_DropModel.DropData>, bool> m_OnReqLotteryCallBack;

	[CompilerGenerated]
	private Action<bool> m_OnReqSelectRewardCallBack;

	public static SkyLanternMgr Instance => null;

	public SkyLanternBaseConfig S3BaseConfig => null;

	public bool isS3Open => false;

	public int Tag_S3 => 0;

	public long StartTime => 0L;

	public long GameEndTime => 0L;

	public long EndTime => 0L;

	public int OpenLevel => 0;

	public int levelIndex => 0;

	public bool isOpen => false;

	public bool isOpenPlay => false;

	public long leftPlayTime => 0L;

	public long leftTime => 0L;

	public int CurRound => 0;

	public int CurPrice => 0;

	public int RoundPrice => 0;

	public bool isCanOne => false;

	public bool isCanRound => false;

	public event Action<bool> OnReqInfoCallBack
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<uint[], uint, List<Drop_DropModel.DropData>, bool> OnReqLotteryCallBack
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<bool> OnReqSelectRewardCallBack
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private SkyLanternMgr()
	{
	}

	public void ReqS3()
	{
	}

	private void ParseJson()
	{
	}

	public void ReqInfo()
	{
	}

	public void ReqLottery()
	{
	}

	public void ReqLotteryRound()
	{
	}

	public void ReqSelectReward(SkyLanternRewardData sdata, int index)
	{
	}

	public SkyLanternSamllPoolConfig GetSmallConfig(int id)
	{
		return null;
	}

	public SkyLanternBigPoolConfig GetBigConfig(int id)
	{
		return null;
	}

	public IOrderedEnumerable<IGrouping<int, SkyLanternRewardData>> GetShowSkyLanternSmallRewardDatas()
	{
		return null;
	}

	public List<SkyLanternRewardData> GetSkyLanternSmallRewardDatas()
	{
		return null;
	}

	public List<SkyLanternRewardData> GetSkyLanternBigRewardDatas()
	{
		return null;
	}

	public List<SkyLanternShowRewardConfig> GetShowRewardDatas()
	{
		return null;
	}

	public void ReqCleanData()
	{
	}

	public int GetPrice(int round)
	{
		return 0;
	}
}
