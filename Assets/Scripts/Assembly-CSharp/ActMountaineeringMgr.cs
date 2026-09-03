using System;
using System.Collections.Generic;
using Dxx.Net;
using GameProtocol;
using TableTool;

public class ActMountaineeringMgr : CInstance<ActMountaineeringMgr>
{
	private List<MountainTaskData> taskData;

	private MountainConfigData configData;

	private List<MountainGiftData> giftData;

	private List<MountainAchievementData> achieveData;

	public MountainPlayData playData;

	private MountainActivityData m_ActivityData;

	private Dictionary<uint, STCommonQuickBuyData> quickBuyData;

	public List<Drop_DropModel.DropData> crtRewards;

	public List<MountainShopData> shopDatas;

	public bool IsChangeRoad;

	public int PropID;

	public bool isSyncData;

	private STActivityHikingPanel nextData;

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

	public float CloudSpeed => 0f;

	public float RunCloudSpeed => 0f;

	public int ShopPropID => 0;

	public int Tag => 0;

	public long GameEndTime => 0L;

	public long ShopEndTime => 0L;

	public long ActivityOpenTime => 0L;

	public long ActivityEndTime => 0L;

	public bool IsGameOpen => false;

	public bool IsActivityOpen => false;

	public bool IsShopOpen => false;

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

	public void ReqMountainInfo(int type, int id, Action<bool> action = null)
	{
	}

	public void ReqMountainTask(int type, int id, Action<bool> action = null)
	{
	}

	public void ReqMountainGift(int type, int id, Action<bool> action = null)
	{
	}

	public void ReqMountainAchievement(int type, int id, Action<bool> action = null)
	{
	}

	public void ReqActMountainQuickBuyInfo(int type, int num, Action<bool> action = null)
	{
	}

	public void ReqActMountainShop(int type, int id, int num, Action<bool> action = null)
	{
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

	public MountainGiftData GetGiftItemDataByID(int id)
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

	private void SyncActivityData(STRespActivityHiking data)
	{
	}

	private void SyncPlayData(STActivityHikingPanel data)
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

	public List<MountainTaskData> GetTaskShowList()
	{
		return null;
	}

	public MountainTaskData GetTaskItemData(int taskId)
	{
		return null;
	}

	public List<MountainGiftData> GetGiftShowData()
	{
		return null;
	}

	public List<MountainAchievementData> GetAchievementDatas()
	{
		return null;
	}

	public List<MountainShopData> GetShopData()
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

	public long GetShopLeftTime()
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

	public int GetShopPropID()
	{
		return 0;
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
}
