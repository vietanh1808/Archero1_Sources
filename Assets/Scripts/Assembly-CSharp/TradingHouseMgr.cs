using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Dxx.Net;
using GameProtocol;
using TableTool;

public class TradingHouseMgr
{
	public class TradingHouseConfig
	{
		public TradingHouseBaseConfig[] Base;

		public TradingHouseRewardPreviewConfig[] RewardPreview;

		public TradingHouseRankRewardConfig[] Rank;
	}

	public class TradingHouseBaseConfig
	{
		public int Tag;

		public int Version;

		public long ShowTime;

		public long StartTime;

		public long GameEndTime;

		public long RewardEndTime;

		public long EndTime;

		public int[] DailyTime;

		public int OpenGameLevel;

		public int[] TicketId;

		public int[] FreeItem;

		public int[] ItemBuy;

		public int GroupRankNum;

		public int GroupRankNumShow;

		public int RefreshTime;

		public int BuyCount;

		public int SellCount;

		public int[] DailyX;

		public int[] HistoryX;
	}

	public class TradingHouseRewardPreviewConfig
	{
		public int ID;

		public int MinLevel;

		public int MaxLevel;

		public int Position;

		public int[][] Reward;

		public int RewardPreview;
	}

	public class TradingHouseRankRewardConfig
	{
		public int ID;

		public int Tag;

		public int MinLevel;

		public int MaxLevel;

		public int[] Rank;

		public int[][] Reward;

		public string Reward_img;
	}

	private static TradingHouseMgr instance;

	public TradingHouseConfig S3Config;

	public Dictionary<int, TradingHouseCommodity> tradingHouseCommodities;

	public TradingAchievementData AchievementData;

	public TradingShopData ShopData;

	private STRespActivityTradingPost severData;

	public int HistoryMaxAsset;

	public int[] DailyXTime;

	public int[] HistoryXTime;

	public int[] TradingTime;

	private const string guideKey = "TradingHousePop";

	[CompilerGenerated]
	private Action<bool> m_OnReqInfoCallBack;

	[CompilerGenerated]
	private Action<bool> m_OnReqRankInfoCallBack;

	[CompilerGenerated]
	private Action<bool> m_OnReqQuickBuyCallBack;

	[CompilerGenerated]
	private Action<bool> m_OnReqBuyGoodsCallBack;

	[CompilerGenerated]
	private Action<bool> m_OnReqSellGoodsCallBack;

	private List<TradingHouseLogData> tradingHouseLogs;

	private List<Drop_DropModel.DropData> previewData;

	private TradingHouseRankingItemData[] tradingHouseRankings;

	private TradingHouseRankingItemData myRankData;

	public static TradingHouseMgr Instance => null;

	public TradingHouseBaseConfig S3BaseConfig => null;

	public bool isS3Open => false;

	public int Tag_S3 => 0;

	public int Tag => 0;

	public int OpenVersion => 0;

	public long S3PreviewTime => 0L;

	public long S3StartTime => 0L;

	public long S3GameEndTime => 0L;

	public long S3ewardEndTime => 0L;

	public long S3EndTime => 0L;

	public bool isS3TimeOpen => false;

	public bool isS3OpenReward => false;

	public bool isS3OpenPlay => false;

	public long leftS3PlayTime => 0L;

	public long leftS3RewardTime => 0L;

	public long leftS3Time => 0L;

	public long StartTime => 0L;

	public long GameEndTime => 0L;

	public long RewardEndTime => 0L;

	public long EndTime => 0L;

	public int OpenLevel => 0;

	public bool isPreview => false;

	public bool isOpen => false;

	public bool isOpenReward => false;

	public bool isOpenPlay => false;

	public long leftPreviewTime => 0L;

	public long leftPlayTime => 0L;

	public long leftRewardTime => 0L;

	public long leftTime => 0L;

	public int DayTradeStartTimeMinute => 0;

	public int DayTradeEndTimeMinute => 0;

	public int RefreshMinute => 0;

	public int NowDayFormMinutes => 0;

	public bool isOpenTrade => false;

	public long nextRefreshTime => 0L;

	public int MatId => 0;

	public int MatCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int ShopCoinId => 0;

	public int ShopCoinCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int CurTimeNode => 0;

	public int CurDay => 0;

	public int BuyCount => 0;

	public int SellCount => 0;

	public int MaxBuyCount => 0;

	public int MaxSellCount => 0;

	public bool isCanBuy => false;

	public bool isCanSell => false;

	public int TotalAssets => 0;

	public int TotalProfit => 0;

	public STCommonQuickBuyData QuickBuy => null;

	public int QuickBuyCountOne => 0;

	public int PriceCount => 0;

	public int HistoryPriceCount => 0;

	public bool isPoped
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private TradingHouseRankRewardConfig[] vecRankRewardData => null;

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

	public event Action<bool> OnReqRankInfoCallBack
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

	public event Action<bool> OnReqBuyGoodsCallBack
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

	public event Action<bool> OnReqSellGoodsCallBack
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

	private TradingHouseMgr()
	{
	}

	public void ReqS3(Action callBack = null)
	{
	}

	private void ParseJson()
	{
	}

	public void ReqInfo(Action<bool> callBack = null)
	{
	}

	public void ReqRankInfo()
	{
	}

	public void ReqQuickBuy(int buyNum)
	{
	}

	public void ReqBuyGoods(int id, int buyNum)
	{
	}

	public void ReqSellGoods(int id, int buyNum)
	{
	}

	public void RequestBuyShop(int id, int count, Action<bool> callback = null)
	{
	}

	private void SetShopData(STActivityTradingPostShop serverShopData)
	{
	}

	private bool ValidResponse(NetResponse response, Action<bool> action)
	{
		return false;
	}

	public List<TradingHouseLogData> GetTradingHouseLogs()
	{
		return null;
	}

	public List<Drop_DropModel.DropData> GetPreviewData()
	{
		return null;
	}

	public TradingHouseRankingItemData[] GetTradingHouseRanks()
	{
		return null;
	}

	public TradingHouseRankingItemData GetMyRankData()
	{
		return null;
	}

	private void setRankDataList(STActivityTradingPostRankItem[] array, int mrank, long mvalue)
	{
	}
}
