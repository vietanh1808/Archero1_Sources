using System;
using System.Collections.Generic;
using GameProtocol;
using TableTool;
using XLua;

public class ActivityMiningMgr : CInstance<ActivityMiningMgr>
{
	public int DestroyIndex;

	public int LineIndex;

	public const int row = 8;

	public const int column = 6;

	public const int cellSize = 80;

	public int MattockID;

	public int DrillId;

	public int BombId;

	private Dictionary<int, List<Drop_DropModel.DropData>> rewardConfig;

	private Dictionary<int, List<int>> rewardRateDict;

	private int moveValue;

	private MiningPropType crtUseProp;

	public int cacheLine;

	public MiningActData actData;

	public STActivityMiningBlockMap cacheMapData;

	public List<MiningBoxItemData> boxDataList;

	public List<MiningGiftItemData> giftDataList;

	public int PropIdShopA;

	public int PropIdShopB;

	public List<MiningShopItemData> shopDataList;

	private Dictionary<int, MiningQuickItemData> quickDataDict;

	public List<MiningTaskItemData> taskDataList;

	private static DelegateBridge __Hotfix0_get_mapData;

	private static DelegateBridge __Hotfix0_set_mapData;

	private static DelegateBridge __Hotfix0_get_Consume;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Clear;

	private static DelegateBridge __Hotfix0_ReqMiningInfo;

	private static DelegateBridge __Hotfix0_SyncMapData;

	private static DelegateBridge __Hotfix0_GetMapData;

	private static DelegateBridge __Hotfix0_GetCellDataStateByPosIndex;

	private static DelegateBridge __Hotfix0_GetMoveValue;

	private static DelegateBridge __Hotfix0_GetRewardOne;

	private static DelegateBridge __Hotfix0_GetRewardList;

	private static DelegateBridge __Hotfix0_GetRewardRateList;

	private static DelegateBridge __Hotfix0_CheckAroundRound;

	private static DelegateBridge __Hotfix0_Check;

	private static DelegateBridge __Hotfix0_GetLineIndex;

	private static DelegateBridge __Hotfix0_get_GetCurrentDepth;

	private static DelegateBridge __Hotfix0_SetCrtUseProp;

	private static DelegateBridge __Hotfix0_GetCrtUsePorp;

	private static DelegateBridge __Hotfix0_isOpenMaxLevel;

	private static DelegateBridge __Hotfix0_isOpen;

	private static DelegateBridge __Hotfix0_isOpenPlay;

	private static DelegateBridge __Hotfix0_isOpenTask;

	private static DelegateBridge __Hotfix0_get_LeftTime;

	private static DelegateBridge __Hotfix0_get_LeftTimePlay;

	private static DelegateBridge __Hotfix0_get_LeftTimeTask;

	private static DelegateBridge __Hotfix0_parseDepthBoxData;

	private static DelegateBridge __Hotfix0_requestDepthBox;

	private static DelegateBridge __Hotfix0_GetBoxItemData;

	private static DelegateBridge __Hotfix0_get_theLastBoxDepth;

	private static DelegateBridge __Hotfix0_parseGiftData;

	private static DelegateBridge __Hotfix0_requestGiftAd;

	private static DelegateBridge __Hotfix0_GetGiftItemData;

	private static DelegateBridge __Hotfix0_parseShopData;

	private static DelegateBridge __Hotfix0_parseQuickItemData;

	private static DelegateBridge __Hotfix0_requestShopBuyItem;

	private static DelegateBridge __Hotfix0_requestShopQuickBuy;

	private static DelegateBridge __Hotfix0_get_PropIdA;

	private static DelegateBridge __Hotfix0_get_PropIdB;

	private static DelegateBridge __Hotfix0_get_PropIdC;

	private static DelegateBridge __Hotfix0_TypeToPropId;

	private static DelegateBridge __Hotfix0_GetQuickItemData;

	private static DelegateBridge __Hotfix0_GetShopItemData;

	private static DelegateBridge __Hotfix0_GetSubShopList;

	private static DelegateBridge __Hotfix0_parseTaskData;

	private static DelegateBridge __Hotfix0_requestInfo_Gift_Task;

	private static DelegateBridge __Hotfix0_requestTaskGet;

	private static DelegateBridge __Hotfix0_GetTaskItemData;

	private static DelegateBridge __Hotfix0_GetTaskShowList;

	private static DelegateBridge __Hotfix0_showRewardWindow;

	private static DelegateBridge __Hotfix0_isHavePropIdA;

	private static DelegateBridge __Hotfix0_isDepthBoxReward;

	private static DelegateBridge __Hotfix0_isHaveTaskReward;

	private static DelegateBridge __Hotfix0_isGiftCanAd;

	private static DelegateBridge __Hotfix0_isHaveShopItemExch;

	private static DelegateBridge __Hotfix0_isMiningProp;

	private static DelegateBridge _c__Hotfix0_ctor;

	private MiningMapShowData mapData { get; set; }

	public int Consume => 0;

	public int GetCurrentDepth => 0;

	public long LeftTime => 0L;

	public long LeftTimePlay => 0L;

	public long LeftTimeTask => 0L;

	public int theLastBoxDepth => 0;

	public int PropIdA => 0;

	public int PropIdB => 0;

	public int PropIdC => 0;

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	public void ReqMiningInfo(int type, int id, int posIndex, Action<STRespActivityMining, int> action = null, bool isClick = true)
	{
	}

	public void SyncMapData()
	{
	}

	public List<MiningBlockShowData> GetMapData()
	{
		return null;
	}

	public bool GetCellDataStateByPosIndex(int index)
	{
		return false;
	}

	public int GetMoveValue()
	{
		return 0;
	}

	public Drop_DropModel.DropData GetRewardOne(int key, int index)
	{
		return null;
	}

	public List<Drop_DropModel.DropData> GetRewardList(int key)
	{
		return null;
	}

	public List<int> GetRewardRateList(int key)
	{
		return null;
	}

	public int CheckAroundRound(MiningBlockShowData data)
	{
		return 0;
	}

	private bool Check(MiningBlockShowData targetData, MiningBlockShowData data)
	{
		return false;
	}

	public int GetLineIndex()
	{
		return 0;
	}

	public void SetCrtUseProp(MiningPropType t)
	{
	}

	public MiningPropType GetCrtUsePorp()
	{
		return (MiningPropType)0;
	}

	private bool isOpenMaxLevel()
	{
		return false;
	}

	public bool isOpen()
	{
		return false;
	}

	public bool isOpenPlay()
	{
		return false;
	}

	public bool isOpenTask()
	{
		return false;
	}

	private void parseDepthBoxData(STActivityMiningAchievement data)
	{
	}

	public void requestDepthBox(int boxId, Action<STRespActivityMining, int> action = null)
	{
	}

	public MiningBoxItemData GetBoxItemData(int boxId)
	{
		return null;
	}

	private void parseGiftData(STActivityMiningGift data)
	{
	}

	public void requestGiftAd(int giftId, Action<STRespActivityMining, int> action = null)
	{
	}

	public MiningGiftItemData GetGiftItemData(int giftId)
	{
		return null;
	}

	private void parseShopData(STActivityMiningShop data)
	{
	}

	private void parseQuickItemData(STActivityMiningBlockMap data)
	{
	}

	public void requestShopBuyItem(int itemId, int count, Action<STRespActivityMining, int> action = null)
	{
	}

	public void requestShopQuickBuy(int itemId, int count, Action<STRespActivityMining, int> action = null)
	{
	}

	private int TypeToPropId(int type)
	{
		return 0;
	}

	public MiningQuickItemData GetQuickItemData(int pid)
	{
		return null;
	}

	public MiningShopItemData GetShopItemData(int shopId)
	{
		return null;
	}

	public List<MiningShopItemData> GetSubShopList(int tab)
	{
		return null;
	}

	private void parseTaskData(STActivityMiningTask data)
	{
	}

	public void requestInfo_Gift_Task(Action<STRespActivityMining, int> action = null)
	{
	}

	public void requestTaskGet(int taskId, Action<STRespActivityMining, int> action = null)
	{
	}

	public MiningTaskItemData GetTaskItemData(int taskId)
	{
		return null;
	}

	public List<MiningTaskItemData> GetTaskShowList()
	{
		return null;
	}

	private void showRewardWindow(STCommonData stcd)
	{
	}

	public bool isHavePropIdA()
	{
		return false;
	}

	public bool isDepthBoxReward()
	{
		return false;
	}

	public bool isHaveTaskReward()
	{
		return false;
	}

	public bool isGiftCanAd()
	{
		return false;
	}

	public bool isHaveShopItemExch()
	{
		return false;
	}

	public bool isMiningProp(int propID)
	{
		return false;
	}
}
