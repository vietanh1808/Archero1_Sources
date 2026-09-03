using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameProtocol;
using TableTool;

public class PushPillarMgr
{
	public class PushPillarConfig
	{
		public PushPillarBaseConfig[] Base;

		public PushPillarMultiplierConfig[] Multiplier;

		public PushPillarMultiplierGroupConfig[] MultiplierGroup;

		public PushPillarPushProbabilityConfig[] PushProbability;

		public PushPillarPushDynamicConfig[] PushDynamic;

		public PushPillarChoiceRewardConfig[] ChoiceReward;

		public PushPillarRandomTypeConfig[] RandomType;

		public PushPillarRandomRewardsConfig[] RandomRewards;

		public PushPillarRandomRowConfig[] RandomRow;

		public PushPillarAchievementConfig[] Achievement;

		public PushPillarTaskConfig[] Task;

		public PushPillarShopConfig[] Shop;

		public PushPillarGiftConfig[] Gift;
	}

	public class PushPillarBaseConfig
	{
		public int Tag;

		public int Version;

		public long StartTime;

		public long GameEndTime;

		public long RewardEndTime;

		public long EndTime;

		public int OpenGameLevel;

		public int[] FreeItem;

		public int[][] CostItem;

		public int[][] PushBase;

		public int[] ShopItem;

		public int[] ItemBuy;
	}

	public class PushPillarMultiplierConfig
	{
		public int ID;

		public int Type;

		public int MaxNum;

		public int Multiplier;

		public int Weight;

		public string Img;
	}

	public class PushPillarMultiplierGroupConfig
	{
		public int ID;

		public int RowNum3;

		public int RowNum4;

		public int RowNum5;

		public int RowNum6;

		public int Weight;

		public int Nums;
	}

	public class PushPillarPushProbabilityConfig
	{
		public int ID;

		public int Type;

		public int SubType;

		public int[][] Probability;
	}

	public class PushPillarPushDynamicConfig
	{
		public int ID;

		public int[] VisitRange;

		public int SubType;

		public int MinConsume;

		public int MaxConsume;
	}

	public class PushPillarChoiceRewardConfig
	{
		public int ID;

		public int MinLevel;

		public int MaxLevel;

		public int ReNum;

		public int[][] Rewards;

		public int Num;

		public string Note;

		public int[][] Rewards1;

		public int[][] Rewards2;
	}

	public class PushPillarRandomTypeConfig
	{
		public int ID;

		public int[] Num;
	}

	public class PushPillarRandomRewardsConfig
	{
		public int ID;

		public int MinLevel;

		public int MaxLevel;

		public int[][] Rewards;

		public int Type;

		public int Weight;

		public int Count;
	}

	public class PushPillarRandomRowConfig
	{
		public int ID;

		public int TypeIWeight1;

		public int TypeIWeight2;

		public int TypeIWeight3;

		public int TypeIWeight4;

		public int TypeIWeight5;
	}

	public class PushPillarAchievementConfig
	{
		public int ID;

		public int MinLevel;

		public int MaxLevel;

		public int Value;

		public int[][] Rewards;
	}

	public class PushPillarTaskConfig
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

	public class PushPillarShopConfig
	{
		public int ID;

		public int Type;

		public int MinLevel;

		public int MaxLevel;

		public int Position;

		public int[][] Product;

		public string Note;

		public int[][] Price;

		public int Count;

		public int Discount;

		public int DailyReset;

		public int ShowVersion;
	}

	public class PushPillarGiftConfig
	{
		public int ID;

		public int Position;

		public int MinLevel;

		public int MaxLevel;

		public string Price;

		public int ShowCond;

		public int Quota;

		public int[][] Rewards;

		public int Discount;

		public int DailyReset;

		public int ShowVersion;
	}

	private static PushPillarMgr instance;

	public PushPillarConfig S3Config;

	public int[] PillarPositions;

	public PushPillarGridData[,] BoardGrids;

	public int CurrentRoundPushCount;

	public long TotalCostCoin;

	public int TotalRefreshCount;

	public bool RoundPushed;

	public int DailyBuyCoinCount;

	public List<uint> SelectedChoiceRewardIds;

	public long CurProgress;

	public ulong[] VecProgressRewardBits;

	public STCommonQuickBuyData QuickBuy;

	[CompilerGenerated]
	private Action<bool> m_OnReqInfoCallBack;

	[CompilerGenerated]
	private Action<bool> m_OnReqPushCallBack;

	[CompilerGenerated]
	private Action<bool> m_OnReqRefreshCallBack;

	[CompilerGenerated]
	private Action<bool> m_OnReqChoicePlaceCallBack;

	[CompilerGenerated]
	private Action<bool> m_OnReqTaskCallBack;

	[CompilerGenerated]
	private Action<bool> m_OnReqGiftCallBack;

	[CompilerGenerated]
	private Action<bool> m_OnShopBuyCallBack;

	[CompilerGenerated]
	private Action<bool> m_OnReqQuickBuyCallBack;

	public Action OnReqProgressRewardCallBack;

	private readonly List<PushPillarTaskItemData> taskItemDatas;

	private readonly List<ViewCellData> giftItemDatas;

	private readonly List<ViewCellData> progressItemDatas;

	private readonly List<PushPillarShopData> shopItemDatas;

	private readonly List<PushPillarChoiceRewardData> choiceRewardDatas;

	private STRespActivityPushPillar severData;

	public static PushPillarMgr Instance => null;

	public PushPillarBaseConfig S3BaseConfig => null;

	public bool isS3Open => false;

	public long StartTime => 0L;

	public long GameEndTime => 0L;

	public long RewardEndTime => 0L;

	public long EndTime => 0L;

	public long DailyTime => 0L;

	public int OpenLevel => 0;

	public bool IsDailyExpired => false;

	public bool isOpen => false;

	public bool isOpenPlay => false;

	public long leftPlayTime => 0L;

	public long leftTime => 0L;

	public int PushCoinId => 0;

	public int ShopPointId => 0;

	public int propShopIdA => 0;

	public int propShopIdB => 0;

	public int PushCoinCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int ShopPointCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int DailyBuyCoinRemain => 0;

	public bool AllChoicePlaced => false;

	public bool AnyPillarAtBottom => false;

	public bool AllPillarsAtBottom => false;

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

	public event Action<bool> OnReqPushCallBack
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

	public event Action<bool> OnReqRefreshCallBack
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

	public event Action<bool> OnReqChoicePlaceCallBack
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

	public event Action<bool> OnReqGiftCallBack
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

	public event Action<bool> OnShopBuyCallBack
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

	public event Action<bool> OnReqQuickBuyCallBack
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

	private PushPillarMgr()
	{
	}

	public bool ProgressRewardIsClaimed(int index)
	{
		return false;
	}

	public int GetCurrentPushCost()
	{
		return 0;
	}

	public bool isEntanceRed()
	{
		return false;
	}

	public bool isTaskRed()
	{
		return false;
	}

	public bool isShopRed()
	{
		return false;
	}

	public bool isGiftRed()
	{
		return false;
	}

	public bool isProgressRed()
	{
		return false;
	}

	public List<ViewCellData> GetTaskShowList()
	{
		return null;
	}

	private int GetTaskSortPriority(PushPillarTaskItemData task)
	{
		return 0;
	}

	public List<ViewCellData> GetGiftShowList()
	{
		return null;
	}

	public List<ViewCellData> GetProgressShowList()
	{
		return null;
	}

	public List<PushPillarShopData> GetShopList()
	{
		return null;
	}

	public List<PushPillarShopData> GetSubShopList(int tab)
	{
		return null;
	}

	public bool isHaveItemExch(int type)
	{
		return false;
	}

	public List<PushPillarChoiceRewardData> GetChoiceRewardList()
	{
		return null;
	}

	public void ClearData()
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

	public void ReqSetChoiceReward(uint[] choiceRewardIds)
	{
	}

	public void ReqChoicePlace(int rewardId, int row)
	{
	}

	public PushResultNet ReqPush()
	{
		return null;
	}

	public void ReqRefreshBoard()
	{
	}

	public void ReqProgressReward(PushPillarProgressData item)
	{
	}

	public void ReqShopBuy(PushPillarShopData item, int count)
	{
	}

	public void ReqGiftBuy(PushPillarGiftItemData gift)
	{
	}

	public void ReqTaskGet(PushPillarTaskItemData task)
	{
	}

	public void ReqQuickBuy(int buyNum)
	{
	}

	public void ReqCleanData()
	{
	}

	private void ParseBoardData(STRespActivityPushPillar data)
	{
	}

	private void ParseColumnPushedRows(STRespActivityPushPillar data)
	{
	}

	private void ParseChoiceRewardIds(STRespActivityPushPillar data)
	{
	}

	private void ParseAchievementData(STRespActivityPushPillar data)
	{
	}

	private PushPillarTaskItemData CreateTaskData(STCommonTaskData td)
	{
		return null;
	}

	private PushPillarGiftItemData CreateGiftData(STCommonGiftData gd)
	{
		return null;
	}

	private PushPillarShopData CreateShopData(STCommonShopData sd)
	{
		return null;
	}

	private void ReportPushPillarChoice()
	{
	}

	private void ReportPushPillarPush(PushResultNet net, int cost)
	{
	}

	private string GetRowRewardsLeft(int row)
	{
		return null;
	}

	private string FormatRewardList(List<Drop_DropModel.DropData> rewards)
	{
		return null;
	}
}
