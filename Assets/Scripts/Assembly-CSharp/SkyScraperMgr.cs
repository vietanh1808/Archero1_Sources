using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameProtocol;
using TableTool;

public class SkyScraperMgr
{
	public class SkyScraperConfig
	{
		public SkyScraperBaseConfig[] Base;

		public SkyScraperPreviewRewardConfig[] PreviewRewards;

		public SkyScraperAchievementConfig[] Achievement;

		public SkyScraperSpecialLatticeConfig[] SpecialLattice;
	}

	public class SkyScraperBaseConfig
	{
		public int Tag;

		public int Version;

		public long StartTime;

		public long GameEndTime;

		public long RewardEndTime;

		public long EndTime;

		public int OpenGameLevel;

		public int[] FreeItem;

		public int[] ShopItem;

		public int[] ItemBuy;
	}

	public class SkyScraperPreviewRewardConfig
	{
		public int ID;

		public int TowerNum;

		public int TowerLevel;

		public int MinLevel;

		public int MaxLevel;

		public int Quality;

		public int[][] Rewards;
	}

	public class SkyScraperAchievementConfig
	{
		public int ID;

		public int MinLevel;

		public int MaxLevel;

		public int Value;

		public int[][] Rewards;
	}

	public class SkyScraperSpecialLatticeConfig
	{
		public int ID;

		public int TowerMin;

		public int TowerMax;

		public int Weight1;

		public int Weight2;

		public int Weight3;

		public int Weight4;

		public int Weight5;

		public int Weight6;

		public int Weight7;
	}

	public class BoxNet
	{
		public bool isDone;

		public bool isSuccess;

		public int errorCode;
	}

	public class BuildingBoxNet : BoxNet
	{
		public SkyScraperGameBoxData boxData;
	}

	public class BuilingCompleteBoxNet : BoxNet
	{
		public List<Drop_DropModel.DropData> rewards;

		public int towerLevel;

		public int towerGroup;
	}

	private static SkyScraperMgr instance;

	public SkyScraperConfig S3Config;

	private STRespActivityGiftTower severData;

	public STCommonQuickBuyData QuickBuy;

	[CompilerGenerated]
	private Action<bool> m_OnReqInfoCallBack;

	[CompilerGenerated]
	private Action<bool> m_OnReqTaskCallBack;

	[CompilerGenerated]
	private Action<bool> m_OnReqGiftCallBack;

	public Action OnReqAllRewardCallBack;

	[CompilerGenerated]
	private Action<bool> m_OnReqQuickBuyCallBack;

	[CompilerGenerated]
	private Action<bool> m_OnShopBuyCallBack;

	private List<SkyScraperShopData> shopItemDatas;

	private List<SkyScraperTaskItemData> taskItemDatas;

	private List<ViewCellData> giftItemDatas;

	private List<ViewCellData> rewardItemDatas;

	private Dictionary<int, List<ViewCellData>> previewItemDatas;

	private List<ViewCellData> gameBoxList;

	public static SkyScraperMgr Instance => null;

	public SkyScraperBaseConfig S3BaseConfig => null;

	public bool isS3Open => false;

	public int Tag_S3 => 0;

	public long StartTime => 0L;

	public long GameEndTime => 0L;

	public long RewardEndTime => 0L;

	public long EndTime => 0L;

	public long DailyTime => 0L;

	public int OpenLevel => 0;

	public bool isOpen => false;

	public bool isOpenReward => false;

	public bool isOpenPlay => false;

	public long leftPlayTime => 0L;

	public long leftRewardTime => 0L;

	public long leftTime => 0L;

	public int propShopIdA => 0;

	public int propShopIdB => 0;

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

	public int ShopIdACount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int ShopIdBCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public long CurProgress => 0L;

	public ulong ProgressRewardBits => 0uL;

	public ulong[] VecProgressRewardBits => null;

	public int HasRewardTowerLayer => 0;

	public int HasCompleteCount => 0;

	public int CurBuildingHasNum => 0;

	public int CurBuildingAllNum => 0;

	public bool CurBuildingIsComplete => false;

	public int CurTowerGroup => 0;

	public int CurTowerld => 0;

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

	private SkyScraperMgr()
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

	public BuildingBoxNet ReqBuilingBox()
	{
		return null;
	}

	public BuilingCompleteBoxNet ReqBuilingCompleteBox()
	{
		return null;
	}

	public void ReqTaskGet(SkyScraperTaskItemData task)
	{
	}

	public void ReqGiftBuy(SkyScraperGiftItemData gift)
	{
	}

	public void ReqAllReward(SkyScraperRewardItemData itemData)
	{
	}

	public void ReqQuickBuy(int buyNum)
	{
	}

	public void requestShopBuyItem(SkyScraperShopData itemData, int count)
	{
	}

	private SkyScraperShopData CreatShopData(STCommonShopData d)
	{
		return null;
	}

	public List<SkyScraperShopData> GetSubShopList(int tab)
	{
		return null;
	}

	public bool isHaveItemExch(int type)
	{
		return false;
	}

	public List<ViewCellData> GetTaskShowList()
	{
		return null;
	}

	public List<ViewCellData> GetGiftShowList()
	{
		return null;
	}

	public List<ViewCellData> GetRewardShowList()
	{
		return null;
	}

	public List<ViewCellData> GetPreviewShowList(int level)
	{
		return null;
	}

	public List<int> GetPreviewLevels()
	{
		return null;
	}

	public int GetCurTowerLevel()
	{
		return 0;
	}

	private void CheckPreviewDatas()
	{
	}

	public List<ViewCellData> GetGameBoxList()
	{
		return null;
	}

	public bool ProgressRewardIsClaimed(int index)
	{
		return false;
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

	public bool isRewardRed()
	{
		return false;
	}

	public bool isPropFly(int propID)
	{
		return false;
	}

	public void ReqCleanData()
	{
	}
}
