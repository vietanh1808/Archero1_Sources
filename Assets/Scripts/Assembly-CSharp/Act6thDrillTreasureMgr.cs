using System;
using System.Collections.Generic;
using Dxx.Net;
using GameProtocol;
using TableTool;

public class Act6thDrillTreasureMgr : CInstance<Act6thDrillTreasureMgr>
{
	private List<Act6thDrillTreasureTaskData> taskData;

	private Act6thDrillTreasureConfigData configData;

	private List<Act6thDrillTreasureGiftData> giftData;

	private List<Act6thDrillTreasureAchievementData> achieveData;

	public Act6thDrillTreasurePlayData playData;

	private Act6thDrillTreasureActivityData m_ActivityData;

	private Dictionary<uint, STCommonQuickBuyData> quickBuyData;

	public List<Drop_DropModel.DropData> crtRewards;

	public List<Act6thDrillTreasureShopItemData> shopDatas;

	public bool IsChangeRoad;

	public int PropID;

	public bool isSyncData;

	private STActivityMineCarPanel nextData;

	private bool CheckOk;

	public string RoadPic => null;

	public Action AniEndAction => null;

	public long RefreshTime => 0L;

	public int BoosterID => 0;

	public int BoosterAddHeight => 0;

	public int AddTime => 0;

	public int AddHeight => 0;

	public int CrtComsume => 0;

	public float RunTime => 0f;

	public float RoadSpeed => 0f;

	public float RunRoadSpeed => 0f;

	public int ShopPropA => 0;

	public int ShopPropB => 0;

	public int Tag => 0;

	public long GameEndTime => 0L;

	public long ActivityOpenTime => 0L;

	public long ActivityEndTime => 0L;

	public bool IsGameOpen => false;

	public bool IsActivityOpen => false;

	public bool IsS3Open => false;

	protected override void Init()
	{
	}

	private void Check()
	{
	}

	private bool CheckConfigData()
	{
		return false;
	}

	public void ParseConfigData()
	{
	}

	protected override void Clear()
	{
	}

	public void ReqCleanData()
	{
	}

	public void ReqDrillTreasureInfo(int type, int id, Action<bool> action = null)
	{
	}

	public void ReqDrillTreasureTask(int type, int id, Action<bool> action = null)
	{
	}

	public void ReqReqDrillTreasureGift(int type, int id, Action<bool> action = null)
	{
	}

	public void ReqDrillTreasureAchievement(int type, int id, Action<bool> action = null)
	{
	}

	public void ReqActDrillTreasureQuickBuyInfo(int type, int num, Action<bool> action = null)
	{
	}

	public void ReqActDrillTreasureShop(int tab, int id, int num, Action<bool> action = null)
	{
	}

	public int GetShopPropID(int tab)
	{
		return 0;
	}

	private bool ValidResponse(NetResponse response, Action<bool> action)
	{
		return false;
	}

	private void OnAniEnd()
	{
	}

	private void showRewardWindow(STCommonData stcd, int type, Action action = null)
	{
	}

	public Act6thDrillTreasureGiftData GetGiftItemDataByID(int id)
	{
		return null;
	}

	public int GetOncePriceByPropID(int propID)
	{
		return 0;
	}

	public int GetLeftCountByPropID(int propID)
	{
		return 0;
	}

	private void SyncActivityData(STRespActivityMineCar data)
	{
	}

	private void SyncPlayData(STActivityMineCarPanel data)
	{
	}

	private void SyncTaskData(STCommonTaskData[] tData)
	{
	}

	private void SyncGiftData(STCommonGiftData[] gData)
	{
	}

	private void SyncAchievementData(STCommonAchievementData[] aData)
	{
	}

	private void SyncShopData(STCommonShopData[] sData)
	{
	}

	public List<Act6thDrillTreasureTaskData> GetTaskShowList()
	{
		return null;
	}

	public Act6thDrillTreasureTaskData GetTaskItemData(int taskId)
	{
		return null;
	}

	public List<Act6thDrillTreasureGiftData> GetGiftShowData()
	{
		return null;
	}

	public List<Act6thDrillTreasureAchievementData> GetAchievementDatas()
	{
		return null;
	}

	public long GetGameLeftTime()
	{
		return 0L;
	}

	public long GetActivityLeftTime()
	{
		return 0L;
	}

	public bool IsSpecialIndex()
	{
		return false;
	}

	public bool IsCardOpened(int index)
	{
		return false;
	}

	public void AddCardOpenIndex(int index)
	{
	}

	public int GetCrtHeight()
	{
		return 0;
	}

	public int GetAchievementHeightByIndex(int index)
	{
		return 0;
	}

	public Drop_DropModel.DropData GetOpenCardReward(int count)
	{
		return null;
	}

	public List<Drop_DropModel.DropData> GetLeftCardRewards()
	{
		return null;
	}

	public Drop_DropModel.DropData GetOpenedCardRewardByIndex(int index)
	{
		return null;
	}

	public bool IsHaveTaskRed()
	{
		return false;
	}

	public bool IsHaveAchievementRed()
	{
		return false;
	}

	public bool IsHaveGiftRed()
	{
		return false;
	}

	public bool HaveRed()
	{
		return false;
	}

	public List<Act6thDrillTreasureShopItemData> GetSubShopList(int tab)
	{
		return null;
	}

	public bool IsHaveItemCanBuy(int tab)
	{
		return false;
	}

	public bool IsPropFly(int propID)
	{
		return false;
	}
}
