using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameProtocol;

public class BraveCampMgr
{
	public class BraveCampConfig
	{
		public BraveCampBaseConfig[] Base;

		public BraveCampRewardConfig[] Rewards;

		public BraveCampTaskConfig[] Task;
	}

	public class BraveCampBaseConfig
	{
		public int Tag;

		public int Version;

		public long StartTime;

		public long GameEndTime;

		public long EndTime;

		public int[] ShowNum;

		public int ChargeNum;

		public long IconCloseTime;

		public int OpenLevel;
	}

	public class BraveCampRewardConfig
	{
		public int ID;

		public int MinLevel;

		public int MaxLevel;

		public int[][] SpecialRewards;

		public int[][] Rewards;
	}

	public class BraveCampTaskConfig
	{
		public int ID;

		public string Notes;

		public int MinLevel;

		public int MaxLevel;

		public int Type;

		public int Position;

		public int UnlockId;

		public int CondTypeArgs;

		public int[][] Rewards;

		public int ShowVersion;
	}

	private static BraveCampMgr instance;

	private BraveCampConfig S3Config;

	private STRespActivitySummonArchers severData;

	private List<BraveCampTaskItemData> taskItemDatas;

	[CompilerGenerated]
	private Action<bool> m_OnReqInfoCallBack;

	[CompilerGenerated]
	private Action<bool> m_OnReqTaskCallBack;

	public static BraveCampMgr Instance => null;

	public BraveCampBaseConfig S3BaseConfig => null;

	public bool isS3Open => false;

	public int Tag_S3 => 0;

	public int OpenGameLevel => 0;

	public int Tag_Sever => 0;

	public bool isOpen => false;

	public long StartTime => 0L;

	public long GameEndTime => 0L;

	public long EndTime => 0L;

	public bool isSeverOpen => false;

	public bool isSeverOpenPlay => false;

	public long leftPlayTime => 0L;

	public long leftTime => 0L;

	public BraveCampBaseConfig S3BaseConfigIconShow => null;

	public long IconCloseTime => 0L;

	public long leftIconCloseTime => 0L;

	public bool isIconShow => false;

	public int MaxGameLevel => 0;

	public BraveCampRewardConfig CurReward => null;

	public int CurRewardID => 0;

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

	public event Action<bool> OnReqTaskCallBack
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

	private BraveCampMgr()
	{
	}

	public List<BraveCampTaskItemData> GetTaskShowList()
	{
		return null;
	}

	public List<BraveCampRewardConfig> GetRewardhowList()
	{
		return null;
	}

	public bool isComplete(int id)
	{
		return false;
	}

	public BraveCampRewardConfig GetReward(int id)
	{
		return null;
	}

	public bool IsHasRed()
	{
		return false;
	}

	public void ReqS3()
	{
	}

	private void ParseJson()
	{
	}

	public void ReqInfo(int id = 0, Action<STActivitySummonArchersRank> callBack = null)
	{
	}

	public void ReqTaskGet(BraveCampTaskItemData task)
	{
	}
}
