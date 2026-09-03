using System;
using System.Collections.Generic;
using GameProtocol;
using XLua;

public class HalloweenActManager : CInstance<HalloweenActManager>
{
	public const float RewardItemScaleSize = 0.62f;

	public const string RewardItemAdBgName = "Blue_Bt";

	public const string RewardItemMoneyBgName = "Green_Bt";

	public HalloweenJsonData hallJsonData;

	public List<HalloweenComData> hallComDataList;

	private Dictionary<int, int> hallComGroupCountDict;

	public int CrystalMatID;

	public int MonsterFragmentID;

	public int ExchMatID;

	public int BottleID;

	public long TimeBegin;

	public long TimeEnd;

	public long ExcTimeEnd;

	public int Style;

	public int Tag;

	public int RoundFinishCount;

	public int CrystalLightNum;

	public int CrystalBallCostOnce;

	public int ExchNeedCount;

	public int ExchGiveNum;

	public int GroupOneNeedTicket;

	private int lastId;

	private int currentId;

	public List<int> tabIdList;

	public List<int> totalIdList;

	public Dictionary<int, int> crtMonsterNum;

	private static DelegateBridge __Hotfix0_get_HalloweenShopData;

	private static DelegateBridge __Hotfix0_set_HalloweenShopData;

	private static DelegateBridge __Hotfix0_get_HalloweenTaskData;

	private static DelegateBridge __Hotfix0_set_HalloweenTaskData;

	private static DelegateBridge __Hotfix0_get_HalloweenExcData;

	private static DelegateBridge __Hotfix0_set_HalloweenExcData;

	private static DelegateBridge __Hotfix0_get_monsterDatas;

	private static DelegateBridge __Hotfix0_set_monsterDatas;

	private static DelegateBridge __Hotfix0_get_QuickBuyData;

	private static DelegateBridge __Hotfix0_set_QuickBuyData;

	private static DelegateBridge __Hotfix0_get_IsHaveSyncData;

	private static DelegateBridge __Hotfix0_set_IsHaveSyncData;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Clear;

	private static DelegateBridge __Hotfix0_GetHalloweenShopData;

	private static DelegateBridge __Hotfix0_GetHalloweenTaskData;

	private static DelegateBridge __Hotfix0_GetHalloweenExchangeData;

	private static DelegateBridge __Hotfix0_GetHalloweenExchangeDataByID;

	private static DelegateBridge __Hotfix0_GetMonsterDataByIndex;

	private static DelegateBridge __Hotfix0_HaveSyncData;

	private static DelegateBridge __Hotfix0_IsActivityOpen;

	private static DelegateBridge __Hotfix0_HaveRed;

	private static DelegateBridge __Hotfix0_HaveShopRed;

	private static DelegateBridge __Hotfix0_HaveTaskRed;

	private static DelegateBridge __Hotfix0_HaveExchangeRed;

	private static DelegateBridge __Hotfix0_RequestShopReward;

	private static DelegateBridge __Hotfix0_RequestTaskReward;

	private static DelegateBridge __Hotfix0_requestCrystal;

	private static DelegateBridge __Hotfix0_parseComFinishList;

	private static DelegateBridge __Hotfix0_parseGiveItem;

	private static DelegateBridge __Hotfix0_checkOpen;

	private static DelegateBridge __Hotfix0_checkActivityOpen;

	private static DelegateBridge __Hotfix0_initConfigData;

	private static DelegateBridge __Hotfix0_GetGroupComList;

	private static DelegateBridge __Hotfix0_GetComDataOne;

	private static DelegateBridge __Hotfix0_GetComRewardOne;

	private static DelegateBridge __Hotfix0_GetComRate;

	private static DelegateBridge __Hotfix0_GetGroupRewardOne;

	private static DelegateBridge __Hotfix0_GetMonsterNumByMonsterId;

	private static DelegateBridge __Hotfix0_get_RoundMaxCount;

	private static DelegateBridge __Hotfix0_get_MaxComCount;

	private static DelegateBridge __Hotfix0_get_LastId;

	private static DelegateBridge __Hotfix0_get_CurrentId;

	private static DelegateBridge __Hotfix0_GetColorID;

	private static DelegateBridge __Hotfix0_GetColorIndexState;

	private static DelegateBridge __Hotfix0_GetCrystalClickCode;

	private static DelegateBridge __Hotfix0_GetCrystalClickIndex;

	private static DelegateBridge __Hotfix0_GetPosColor;

	private static DelegateBridge __Hotfix0_get_BallCount;

	private static DelegateBridge __Hotfix0_get_TicketCount;

	private static DelegateBridge __Hotfix0_get_HammerCount;

	private static DelegateBridge __Hotfix0_get_MFragmentCount;

	private static DelegateBridge __Hotfix0_get_isBigRoundStage;

	private static DelegateBridge __Hotfix0_isShowRedPoint_Bottle;

	private static DelegateBridge __Hotfix0_isShowRedPoint_ExchTicket;

	private static DelegateBridge __Hotfix0_isShowRedPoint_CanGetBigReward;

	private static DelegateBridge __Hotfix0_GetQuickBuyData;

	private static DelegateBridge _c__Hotfix0_ctor;

	private HalloweenShopData HalloweenShopData { get; set; }

	private HalloweenTaskData HalloweenTaskData { get; set; }

	private HalloweenExchangeData HalloweenExcData { get; set; }

	private List<HalloweenMonsterData> monsterDatas { get; set; }

	private HalloweenQuickBuyData QuickBuyData { get; set; }

	private bool IsHaveSyncData { get; set; }

	public int RoundMaxCount => 0;

	public int MaxComCount => 0;

	public int LastId => 0;

	public int CurrentId => 0;

	public int BallCount => 0;

	public int TicketCount => 0;

	public int HammerCount => 0;

	public int MFragmentCount => 0;

	public bool isBigRoundStage => false;

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	public HalloweenShopData GetHalloweenShopData()
	{
		return null;
	}

	public HalloweenTaskData GetHalloweenTaskData()
	{
		return null;
	}

	public HalloweenExchangeData GetHalloweenExchangeData()
	{
		return null;
	}

	public HalloweenExchangeItemData GetHalloweenExchangeDataByID(int id)
	{
		return null;
	}

	public HalloweenMonsterData GetMonsterDataByIndex(int index)
	{
		return null;
	}

	public bool HaveSyncData()
	{
		return false;
	}

	public bool IsActivityOpen()
	{
		return false;
	}

	public bool HaveRed()
	{
		return false;
	}

	public bool HaveShopRed()
	{
		return false;
	}

	public bool HaveTaskRed()
	{
		return false;
	}

	public bool HaveExchangeRed()
	{
		return false;
	}

	public void RequestShopReward(int id, Action<STRespActivityMagicCrystal> success = null, Action<STRespActivityMagicCrystal> failure = null)
	{
	}

	public void RequestTaskReward(int id, Action<STRespActivityMagicCrystal> success = null, Action<STRespActivityMagicCrystal> failure = null)
	{
	}

	public void requestCrystal(int type, int cid, Action<bool> action = null, bool isEnter = false, bool isSkip = false, int count = 0)
	{
	}

	private void parseComFinishList(STRespActivityMagicCrystal info)
	{
	}

	private void parseGiveItem(STRespActivityMagicCrystal data)
	{
	}

	public bool checkOpen()
	{
		return false;
	}

	public bool checkActivityOpen()
	{
		return false;
	}

	private void initConfigData()
	{
	}

	public List<HalloweenComData> GetGroupComList(int group)
	{
		return null;
	}

	public HalloweenComData GetComDataOne(int colorId)
	{
		return null;
	}

	public string GetComRewardOne(int colorId)
	{
		return null;
	}

	public int GetComRate(int colorID)
	{
		return 0;
	}

	public List<string> GetGroupRewardOne(int group)
	{
		return null;
	}

	public void GetMonsterNumByMonsterId(int monsterID)
	{
	}

	public int GetColorID(int totalId)
	{
		return 0;
	}

	public int GetColorIndexState(int totalId, int index)
	{
		return 0;
	}

	public int GetCrystalClickCode(int index)
	{
		return 0;
	}

	public int GetCrystalClickIndex(int code)
	{
		return 0;
	}

	private string GetPosColor(int colorId, int click)
	{
		return null;
	}

	public bool isShowRedPoint_Bottle()
	{
		return false;
	}

	public bool isShowRedPoint_ExchTicket()
	{
		return false;
	}

	public bool isShowRedPoint_CanGetBigReward()
	{
		return false;
	}

	public HalloweenQuickBuyData GetQuickBuyData()
	{
		return null;
	}
}
