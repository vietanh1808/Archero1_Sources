using System;
using System.Collections.Generic;
using GameProtocol;
using TableTool;

public class PlinkoActManager : CInstance<PlinkoActManager>
{
	public PlinkoActData actData;

	public int specialPosx;

	public int specialPosy;

	public List<PlinkoGuideRewardShowData> rewardList;

	public Dictionary<int, PlinkoHoleItemData> holeDataDict;

	public List<PlinkoBoxItemData> boxDataList;

	public List<PlinkoActGiftItemData> giftDataList;

	public List<PlinkoTaskItemData> taskDataList;

	public List<PlinkoShopItemData> shopDataList;

	private PlinkoQuickItemData quickData;

	public Dictionary<int, Drop_DropModel.DropData> speRewardDict;

	public bool isStateAuto;

	public Dictionary<int, PlinkoBallItem> ballDropDict;

	public int totalCount => 0;

	public int PropId => 0;

	public long LeftTime => 0L;

	public long LeftTimeTask => 0L;

	public long LeftTimePlay => 0L;

	public int GetCrtProgress => 0;

	public int maxBoxDepth => 0;

	public int PropIdShopA => 0;

	public int PropIdShopB => 0;

	public int BallCount => 0;

	public bool isBallDropping => false;

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	public bool isOpen()
	{
		return false;
	}

	public bool isOpenPlay()
	{
		return false;
	}

	private bool isOpenMaxLevel()
	{
		return false;
	}

	private bool isOpenPath()
	{
		return false;
	}

	public void requestActData(Action<STRespActivityLuckyPlinko, int> action = null, bool isClick = false)
	{
	}

	private void parseActData(STRespActivityLuckyPlinko data)
	{
	}

	private void parseSpecialCylinderData(STRespActivityLuckyPlinko data)
	{
	}

	private void parseGiveItem(STRespActivityLuckyPlinko data)
	{
	}

	private void paresePreviewRewardData(STActivityLuckyPlinkoReward data)
	{
	}

	public List<PlinkoGuideRewardShowData> GetRewardList()
	{
		return null;
	}

	private void parseHoleData(STActivityLuckyPlinkoGrid data)
	{
	}

	public bool isHavePropId()
	{
		return false;
	}

	private void parseBottomBoxData(STActivityLuckyPlinkoAchievement data)
	{
	}

	public void requestAchievementBox(int boxId, Action<STRespActivityLuckyPlinko, int> action = null)
	{
	}

	public PlinkoBoxItemData GetBoxItemData(int boxId)
	{
		return null;
	}

	public bool isProgressBoxReward()
	{
		return false;
	}

	public void requestGiftAd(int giftId, Action<STRespActivityLuckyPlinko, int> action = null)
	{
	}

	public PlinkoActGiftItemData GetGiftItemData(int giftId)
	{
		return null;
	}

	private void parseGiftData(STActivityLuckyPlinkoGift data)
	{
	}

	public bool isGiftCanAd()
	{
		return false;
	}

	private void parseTaskData(STActivityLuckyPlinkoTask data)
	{
	}

	public void requestTaskGet(int taskId, Action<STRespActivityLuckyPlinko, int> action = null)
	{
	}

	public void requestInfo_Gift_Task(Action<STRespActivityLuckyPlinko, int> action = null)
	{
	}

	public PlinkoTaskItemData GetTaskItemData(int taskId)
	{
		return null;
	}

	public List<PlinkoTaskItemData> GetTaskShowList()
	{
		return null;
	}

	public bool isHaveTaskReward()
	{
		return false;
	}

	private void parseShopData(STActivityLuckyPlinkoShop data)
	{
	}

	public void requestShopBuyItem(int itemId, int count, int tab, Action<STRespActivityLuckyPlinko, int> action = null)
	{
	}

	public List<PlinkoShopItemData> GetSubShopList(int tab)
	{
		return null;
	}

	public PlinkoShopItemData GetShopItemData(int shopId)
	{
		return null;
	}

	public bool isHaveShopItemExch()
	{
		return false;
	}

	private void showRewardWindow(STCommonData stcd, int type)
	{
	}

	public void requestShopQuickBuy(int count, Action<STRespActivityLuckyPlinko, int> action = null)
	{
	}

	private void parseQuickItemData(STLuckyPlinkoQuickBuyData data)
	{
	}

	public PlinkoQuickItemData GetQuickData()
	{
		return null;
	}

	public void requestBallDrop(int count, Action<STRespActivityLuckyPlinko, int> action = null)
	{
	}

	public PlinkoHoleItemData GetHoleItemData(int hole)
	{
		return null;
	}

	public bool isPropFly(int propID)
	{
		return false;
	}
}
