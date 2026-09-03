using System;
using System.Collections.Generic;
using GameProtocol;

public class MonopolyManager
{
	public class BaseConfig
	{
		public int Tag;

		public int Version;

		public int StartTime;

		public int GameEndTime;

		public int RewardEndTime;

		public int EndTime;

		public int OpenGameLevel;

		public int[] FreeItem;

		public int[][] DiceBaitUse;

		public int[] Layer;

		public int GroupRankNum;

		public int[] Grade;

		public int[] TicketId;
	}

	public class TileConfig
	{
		public int ID;

		public int Layer;

		public int Position;

		public int Design;

		public int EventType;

		public int Weight;

		public int[][] Reward;
	}

	public class ThrowConfig
	{
		public int ID;

		public int DiceMin;

		public int DiceMax;

		public int Position;
	}

	public class WheelConfig
	{
		public int ID;

		public int Layer;

		public int[][] Rewards;

		public int[] Wheel;

		public int[] Weight;
	}

	public class PrisonConfig
	{
		public int ID;

		public int Dice1;

		public int Dice2;

		public int Weight;
	}

	public class AchievementConfig
	{
		public int ID;

		public int Layer;

		public int Value;

		public int[][] Rewards;
	}

	public class RankConfigData
	{
		public int ID;

		public int Tag;

		public int[] Rank;

		public int Layer;

		public int Grade;

		public string Reward1;

		public string Reward2;

		public string Reward3;

		public string Reward_img;
	}

	public class MonopolyGameConfig
	{
		public BaseConfig[] Base;

		public TileConfig[] Tile;

		public ThrowConfig[] Throw;

		public PrisonConfig[] Prison;

		public WheelConfig[] Wheel;

		public AchievementConfig[] Achievement;

		public List<RankConfigData> Rank;
	}

	private static MonopolyManager instance;

	public MonopolyActData actData;

	public MonopolyGiftData GiftData;

	public MonopolyShopData ShopData;

	public MonopolyTaskData TaskData;

	public MonopolyRankingData RankingData;

	public MonopolyGameData GameData;

	public MonopolyAchievementData AchievementData;

	private MonopolyGameConfig config;

	private STRespActivityMonopoly severData;

	private STCommonQuickBuyData diceBuyCount;

	public Action OnRatioChange;

	public bool isHavePullData;

	public bool isHaveReReqS3;

	public MonopolyRankingItemData myRankData;

	public static MonopolyManager Instance => null;

	public ulong StartTime => 0uL;

	public ulong EndTime => 0uL;

	public ulong GameEndTime => 0uL;

	public ulong RewardEndTime => 0uL;

	public int DiceId => 0;

	public int DiceNum
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int DiceBuyHaveCount => 0;

	public int DiceBuyMaxCount => 0;

	public int DiceBuyNeedDiamond => 0;

	public int Ratio
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int MaxRatio => 0;

	public int[] Ratios => null;

	public bool isS3Open => false;

	public bool isOpen => false;

	public int Tag_S3 => 0;

	public long LeftTime => 0L;

	public long LeftTimePlay => 0L;

	public List<MonopolyTaskItemData> taskDataList => null;

	public long LeftTimeTask => 0L;

	public List<MonopolyGiftItemData> giftDataList => null;

	public List<MonopolyShopItemData> shopDataList => null;

	public int PropIdShopA => 0;

	public int PropIdShopB => 0;

	public long LeftTime_Shop => 0L;

	public long rankLeftTime => 0L;

	public List<MonopolyRankingItemData> rankList => null;

	public int GetGroupRankCount => 0;

	public int GetGroupGradeCount => 0;

	private MonopolyManager()
	{
	}

	public BaseConfig GetBaseConfig(int tag)
	{
		return null;
	}

	public void ReqS3()
	{
	}

	private void ParseJson()
	{
	}

	public void InitData()
	{
	}

	public void ClearData()
	{
	}

	public bool isOpenPlay()
	{
		return false;
	}

	public bool isPassDay()
	{
		return false;
	}

	public void setPassDayTime()
	{
	}

	public void requestActData(Action<STRespActivityMonopoly, int> action = null)
	{
	}

	private void parseActData(STRespActivityMonopoly data)
	{
	}

	private void parseGiveItem(STRespActivityMonopoly data)
	{
	}

	private void parseTaskData(STActivityMonopolyTask data)
	{
	}

	public void requestTaskGet(int taskId, Action<STRespActivityMonopoly, int> action = null)
	{
	}

	public void requestInfo_Gift_Task(Action<STRespActivityMonopoly, int> action = null)
	{
	}

	public MonopolyTaskItemData GetTaskItemData(int taskId)
	{
		return null;
	}

	public List<MonopolyTaskItemData> GetTaskShowList()
	{
		return null;
	}

	public bool isHaveTaskReward()
	{
		return false;
	}

	public void requestGiftAd(int giftId, Action<STRespActivityMonopoly, int> action = null)
	{
	}

	public MonopolyGiftItemData GetGiftItemData(int giftId)
	{
		return null;
	}

	private void parseGiftData(STActivityMonopolyGift data)
	{
	}

	public bool isGiftCanAd()
	{
		return false;
	}

	private void parseShopData(STActivityMonopolyShop data)
	{
	}

	public void requestShopBuyItem(int itemId, int count, Action<STRespActivityMonopoly, int> action = null)
	{
	}

	public void requestDiceBuyItem(int count, Action<STRespActivityMonopoly, int> action = null)
	{
	}

	public List<MonopolyShopItemData> GetSubShopList(int tab)
	{
		return null;
	}

	public MonopolyShopItemData GetShopItemData(int shopId)
	{
		return null;
	}

	public bool isHaveShopItemExch()
	{
		return false;
	}

	public bool isOpenShop()
	{
		return false;
	}

	public void clearRankData()
	{
	}

	public void openRankUI()
	{
	}

	public void requestRankData(Action<STRespActivityMonopoly, int> action = null)
	{
	}

	private void setRankDataList(STActivityMonopolyRankItem[] array, int mrank, int mvalue)
	{
	}

	public RankConfigData GetRankConfigDataOne(int tag, int grade, int zone, int rank)
	{
		return null;
	}

	public List<string> GetRankRewards(int tag, int grade, int zone, int rank)
	{
		return null;
	}

	public string GetRankRewardIcon(int tag, int grade, int zone, int rank)
	{
		return null;
	}

	public int[] GetGroupGradeScore(int tag)
	{
		return null;
	}

	public int GetGroupGradeCountValue(int grade)
	{
		return 0;
	}

	public string GetGroupIconName(int grade)
	{
		return null;
	}

	public string GetGroupName(int grade)
	{
		return null;
	}

	private void showRewardWindow(STCommonData stcd)
	{
	}

	public List<WheelConfig> GetSlotRewards()
	{
		return null;
	}

	public List<TileConfig> GetTiles(ushort[] ids)
	{
		return null;
	}

	public void ClearSeverData()
	{
	}

	public bool isIconRed()
	{
		return false;
	}
}
