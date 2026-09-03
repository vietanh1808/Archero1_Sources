using System;
using System.Collections.Generic;
using Dxx.Net;
using TableTool;
using XLua;

public sealed class CleverNotificationMgr : CInstance<CleverNotificationMgr>
{
	private Dictionary<CleverBuyType, Dictionary<int, Shop_Push>> typeToPushConfig;

	private const int BATTLE_COUNT_BEFORE_FIRST_BUY_PUSH = 8;

	private bool newRecord;

	private bool needShowEquipDoubleBuy;

	private bool forceShowEquipBuy;

	private PlayerPrefsMgr.PrefDataDic<int, int> newFunctionPropsCounts;

	private PlayerPrefsMgr.PrefDataDic<int, int> newFunctionPropsIsPush;

	private int higherLevelGemsPushId;

	private int higherLevelRelicsPushId;

	private int higherLevelWorkersPushId;

	private Dictionary<CleverBuyType, MaterialBuyCond> materialConds;

	private Shop_Push curEquipDoubleBuyPush;

	private Dictionary<CleverBuyType, CleverShowType> typeToShowTypes;

	private HashSet<string> equipProductIds;

	private HashSet<string> awakenProductIds;

	private HashSet<string> otherProductIds;

	public const long SEC_30_MIN = 1800L;

	public const long SEC_1_HOUR = 3600L;

	public const long SEC_2_HOUR = 7200L;

	public const long SEC_4_HOUR = 14400L;

	public const long SEC_8_HOUR = 28800L;

	public const long SEC_12_HOUR = 43200L;

	public const long SEC_24_HOUR = 86400L;

	public const long SEC_48_HOUR = 172800L;

	public uint curPurchasingProductId;

	public int pushLevel;

	private int FragmentBuyNewPushCharId;

	private int GemBuyNewPushGemId;

	private int scrollId;

	private bool isValidEquipBuy;

	private int validPushCookie;

	private int validPushScroll;

	private int validPushStone;

	private static Dictionary<CleverBuyType, PushSource> _typeToPushSource;

	private static DelegateBridge __Hotfix0_OnMainPageShowStart;

	private static DelegateBridge __Hotfix0_OnMainPageShowEnd;

	private static DelegateBridge __Hotfix0_OnAccept;

	private static DelegateBridge __Hotfix0_OnPurchaseFinish;

	private static DelegateBridge __Hotfix0_IfAppendPurchaseExtraInfo;

	private static DelegateBridge __Hotfix0_DeInit;

	private static DelegateBridge __Hotfix0_Clear;

	private static DelegateBridge __Hotfix0_CanShow;

	private static DelegateBridge __Hotfix0_IsGlobalCD;

	private static DelegateBridge __Hotfix0_get_IsFull;

	private static DelegateBridge __Hotfix0_CheckConditions;

	private static DelegateBridge __Hotfix0_CheckOdds;

	private static DelegateBridge __Hotfix0_IsForcePush;

	private static DelegateBridge __Hotfix0_CheckConditionsMaterialDetail;

	private static DelegateBridge __Hotfix0_CheckConditionsMaterial;

	private static DelegateBridge __Hotfix0_CheckConditionsOnce;

	private static DelegateBridge __Hotfix0_get_battleCount;

	private static DelegateBridge __Hotfix0_set_battleCount;

	private static DelegateBridge __Hotfix0_IsStuckAtBattle;

	private static DelegateBridge __Hotfix0_get_alreadyShownFirstBuy;

	private static DelegateBridge __Hotfix0_CheckConditionsFirstBuy;

	private static DelegateBridge __Hotfix0_IsAlreadyShownStage;

	private static DelegateBridge __Hotfix0_IfNewStage;

	private static DelegateBridge __Hotfix0_CheckConditionsStageBuy;

	private static DelegateBridge __Hotfix0_GetUpgradableEquipments;

	private static DelegateBridge __Hotfix0_CalcCheapestEquipPush;

	private static DelegateBridge __Hotfix0_CanGetEquipPush;

	private static DelegateBridge __Hotfix0_CheckConditionsEquipBuy;

	private static DelegateBridge __Hotfix0_CheckConditionsEquipDoubleBuy;

	private static DelegateBridge __Hotfix0_CheckConditionNewFunctionProps;

	private static DelegateBridge __Hotfix0_CheckConditionHigherLevelGems;

	private static DelegateBridge __Hotfix0_CheckConditionHigherLevelRelics;

	private static DelegateBridge __Hotfix0_CheckConditionHigherLevelWorker;

	private static DelegateBridge __Hotfix0_UpdateCondition;

	private static DelegateBridge __Hotfix0_UpdateConditionsFirstBuy;

	private static DelegateBridge __Hotfix0_UpdateConditionsStageBuy;

	private static DelegateBridge __Hotfix0_UpdateConditionsEquipmentBuy;

	private static DelegateBridge __Hotfix0_CheckInterval;

	private static DelegateBridge __Hotfix0_GeneratePushItemIdBraceletNecklace;

	private static DelegateBridge __Hotfix0_UpdateConditionsBraceletNecklaceBuy;

	private static DelegateBridge __Hotfix0_GeneratePushItemIdBook;

	private static DelegateBridge __Hotfix0_UpdateConditionsBookBuy;

	private static DelegateBridge __Hotfix0_UpdateConditionsAwakenBuy;

	private static DelegateBridge __Hotfix0_UpdateConditionsFragmentBuyNew;

	private static DelegateBridge __Hotfix0_UpdateConditionsGemBuy;

	private static DelegateBridge __Hotfix0_UpdateConditionsNewFunctionProps;

	private static DelegateBridge __Hotfix0_UpdateConditionsHigherLevelGems;

	private static DelegateBridge __Hotfix0_UpdateConditionsHigherLevelRelics;

	private static DelegateBridge __Hotfix0_UpdateConditionsHigherLevelWorkers;

	private static DelegateBridge __Hotfix0_IsActive;

	private static DelegateBridge __Hotfix0_SavePushItemIdBraceletNecklace;

	private static DelegateBridge __Hotfix0_SavePushItemIdBook;

	private static DelegateBridge __Hotfix0_Show;

	private static DelegateBridge __Hotfix0_ValidateFirstBuy;

	private static DelegateBridge __Hotfix0_TryShowStage;

	private static DelegateBridge __Hotfix0_TryShowEquipBuy;

	private static DelegateBridge __Hotfix0_OnValidateCallback;

	private static DelegateBridge __Hotfix0_ValidateAndShowEquipDoubleBuy;

	private static DelegateBridge __Hotfix0_NeedSaveItems;

	private static DelegateBridge __Hotfix0_GetEquipJsonOnce;

	private static DelegateBridge __Hotfix0_GetValidPushEquipIdMaterial;

	private static DelegateBridge __Hotfix0_GetValidPushItemCountMaterial;

	private static DelegateBridge __Hotfix0_GetEquipJsonMaterial;

	private static DelegateBridge __Hotfix0_OnResponseValidateOnce;

	private static DelegateBridge __Hotfix0_OnResponseSaveOnce;

	private static DelegateBridge __Hotfix0_ValidateAndShowOnce;

	private static DelegateBridge __Hotfix0_GetIndexOfMaterialPush;

	private static DelegateBridge __Hotfix0_OnResponseValidateMaterial;

	private static DelegateBridge __Hotfix0_OnResponseSaveMaterial;

	private static DelegateBridge __Hotfix0_ValidateAndShowMaterial;

	private static DelegateBridge __Hotfix0_GetPushDataMaterial;

	private static DelegateBridge __Hotfix0_DoShowMaterial;

	private static DelegateBridge __Hotfix0_OnShowSuccessEquipBuy;

	private static DelegateBridge __Hotfix0_OnValidationFailedOnce;

	private static DelegateBridge __Hotfix0_GetPushItemIdBook;

	private static DelegateBridge __Hotfix0_GenerateNewPushItemIdBraceletNecklace;

	private static DelegateBridge __Hotfix0_GetPushItemIdBraceletNecklace;

	private static DelegateBridge __Hotfix0_GetPushItemList;

	private static DelegateBridge __Hotfix0_GetOrGeneratePushId;

	private static DelegateBridge __Hotfix0_GeneratePushId;

	private static DelegateBridge __Hotfix0_ShowPushWindow;

	private static DelegateBridge __Hotfix0_SavePushDataOnce;

	private static DelegateBridge __Hotfix0_UpdatePushStatesAfterShown;

	private static DelegateBridge __Hotfix0_RequestIfPurchasedFirst;

	private static DelegateBridge __Hotfix0_CalcEquipDoubleData;

	private static DelegateBridge __Hotfix0_UploadEquipList;

	private static DelegateBridge _c__Hotfix0_ctor;

	private static DelegateBridge __Hotfix0_InitConfig;

	private static DelegateBridge __Hotfix0_GetMaterialCond;

	private static DelegateBridge __Hotfix0_UpdateConditionsMaterials;

	private static DelegateBridge __Hotfix0_UpdateConditionsEquipDoubleBuy;

	private static DelegateBridge __Hotfix0_get_prefs;

	private static DelegateBridge __Hotfix0_GetPushSource;

	private static DelegateBridge __Hotfix0_CurrentPushTypes;

	private static DelegateBridge __Hotfix0_PushExist;

	private static DelegateBridge __Hotfix0_CountCurrentPush;

	private static DelegateBridge __Hotfix0_GetTypeFromInt;

	private static DelegateBridge __Hotfix0_LoadPushDataFromJson;

	private static DelegateBridge __Hotfix0_LoadPushData;

	private static DelegateBridge __Hotfix0_get_twoWeekCash;

	private static DelegateBridge __Hotfix0_GetUnlockLevelCount;

	private static DelegateBridge __Hotfix1_GetUnlockLevelCount;

	private static DelegateBridge __Hotfix0_GetIndexPushLevel;

	private static DelegateBridge __Hotfix1_GetIndexPushLevel;

	private static DelegateBridge __Hotfix0_GetIntervalSeconds;

	private static DelegateBridge __Hotfix0_IsCoolingDown;

	private static DelegateBridge __Hotfix1_IsCoolingDown;

	private static DelegateBridge __Hotfix0_GetTotalCoinsByHour;

	private static DelegateBridge __Hotfix0_IsValidByHistoryPurchase;

	private static DelegateBridge __Hotfix0_GetPushTypeConfig;

	public bool IsFull => false;

	private int battleCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private bool alreadyShownFirstBuy => false;

	private PlayerPrefsMgr prefs => null;

	private int twoWeekCash => 0;

	public void OnMainPageShowStart()
	{
	}

	public void OnMainPageShowEnd()
	{
	}

	public void OnAccept(CleverBuyType type)
	{
	}

	public void OnPurchaseFinish(CleverBuyType type, string productId, List<Drop_DropModel.DropData> list)
	{
	}

	public bool IfAppendPurchaseExtraInfo(string productId, out uint extraInfo, out int pushLevel)
	{
		extraInfo = default;
		pushLevel = default;
		return false;
	}

	public void DeInit()
	{
	}

	private new void Clear()
	{
	}

	public bool CanShow(CleverBuyType type)
	{
		return false;
	}

	public bool IsGlobalCD()
	{
		return false;
	}

	public void CheckConditions(CleverBuyType type, out string info, bool showWindow = true)
	{
		info = null;
	}

	private bool CheckOdds(int times, CleverBuyType type, out int percentage, out int random)
	{
		percentage = default;
		random = default;
		return false;
	}

	private bool IsForcePush(CleverBuyType type)
	{
		return false;
	}

	private bool CheckConditionsMaterialDetail(CleverBuyType type, ref string info)
	{
		return false;
	}

	private bool CheckConditionsMaterial(CleverBuyType type, ref string info)
	{
		return false;
	}

	private bool CheckConditionsOnce(CleverBuyType type, ref string info)
	{
		return false;
	}

	private bool IsStuckAtBattle()
	{
		return false;
	}

	private bool CheckConditionsFirstBuy(ref string info)
	{
		return false;
	}

	private bool IsAlreadyShownStage()
	{
		return false;
	}

	private bool IfNewStage()
	{
		return false;
	}

	private bool CheckConditionsStageBuy(ref string info)
	{
		return false;
	}

	private List<LocalSave.EquipOne> GetUpgradableEquipments(List<LocalSave.EquipOne> allEquips, out Dictionary<int, int> equipIdToCount)
	{
		equipIdToCount = null;
		return null;
	}

	private bool CalcCheapestEquipPush(int equipId, Dictionary<int, int> equipIdToCount, out int pushId)
	{
		pushId = default;
		return false;
	}

	private bool CanGetEquipPush(out string info)
	{
		info = null;
		return false;
	}

	private bool CheckConditionsEquipBuy(ref string info)
	{
		return false;
	}

	private bool CheckConditionsEquipDoubleBuy(ref string info)
	{
		return false;
	}

	private bool CheckConditionNewFunctionProps(CleverBuyType type, ref string info)
	{
		return false;
	}

	private bool CheckConditionHigherLevelGems(ref string info)
	{
		return false;
	}

	private bool CheckConditionHigherLevelRelics(ref string info)
	{
		return false;
	}

	private bool CheckConditionHigherLevelWorker(ref string info)
	{
		return false;
	}

	public bool UpdateCondition(CleverBuyType type, object param)
	{
		return false;
	}

	private void UpdateConditionsFirstBuy(object param)
	{
	}

	private void UpdateConditionsStageBuy(object param)
	{
	}

	private void UpdateConditionsEquipmentBuy(object param)
	{
	}

	private bool CheckInterval(CleverBuyType type)
	{
		return false;
	}

	private int[] GeneratePushItemIdBraceletNecklace()
	{
		return null;
	}

	private void UpdateConditionsBraceletNecklaceBuy(object param)
	{
	}

	private int GeneratePushItemIdBook()
	{
		return 0;
	}

	private void UpdateConditionsBookBuy(object param)
	{
	}

	private void UpdateConditionsAwakenBuy(object param)
	{
	}

	private void UpdateConditionsFragmentBuyNew(object param)
	{
	}

	private void UpdateConditionsGemBuy(object param)
	{
	}

	private bool UpdateConditionsNewFunctionProps(CleverBuyType type, object param)
	{
		return false;
	}

	public void UpdateConditionsHigherLevelGems(object param)
	{
	}

	public void UpdateConditionsHigherLevelRelics(object param)
	{
	}

	public void UpdateConditionsHigherLevelWorkers(object param)
	{
	}

	private bool IsActive(CleverBuyType type)
	{
		return false;
	}

	private void SavePushItemIdBraceletNecklace(List<Drop_DropModel.DropData> list)
	{
	}

	private void SavePushItemIdBook(List<Drop_DropModel.DropData> list)
	{
	}

	private void Show(CleverBuyType type)
	{
	}

	private void ValidateFirstBuy()
	{
	}

	private void TryShowStage(CleverBuyType type)
	{
	}

	private void TryShowEquipBuy()
	{
	}

	private void OnValidateCallback(bool purchased)
	{
	}

	private void ValidateAndShowEquipDoubleBuy()
	{
	}

	private bool NeedSaveItems(CleverBuyType type)
	{
		return false;
	}

	private string GetEquipJsonOnce(CleverBuyType type)
	{
		return null;
	}

	private int GetValidPushEquipIdMaterial(CleverBuyType type)
	{
		return 0;
	}

	private int GetValidPushItemCountMaterial(CleverBuyType type)
	{
		return 0;
	}

	private string GetEquipJsonMaterial(CleverBuyType type)
	{
		return null;
	}

	private void OnResponseValidateOnce(NetResponse response, CleverBuyType type)
	{
	}

	private void OnResponseSaveOnce(NetResponse response2, CleverBuyType type)
	{
	}

	private void ValidateAndShowOnce(CleverBuyType type)
	{
	}

	private int GetIndexOfMaterialPush(CleverBuyType type)
	{
		return 0;
	}

	private void OnResponseValidateMaterial(NetResponse response, CleverBuyType type)
	{
	}

	private void OnResponseSaveMaterial(NetResponse response2, CleverBuyType type)
	{
	}

	private void ValidateAndShowMaterial(CleverBuyType type)
	{
	}

	private CleverMaterialItemItemData[] GetPushDataMaterial(CleverBuyType type)
	{
		return null;
	}

	private void DoShowMaterial(CleverBuyType type)
	{
	}

	private void OnShowSuccessEquipBuy()
	{
	}

	private void OnValidationFailedOnce(CleverBuyType type, int errorCode)
	{
	}

	private int GetPushItemIdBook()
	{
		return 0;
	}

	private int[] GenerateNewPushItemIdBraceletNecklace()
	{
		return null;
	}

	private int[] GetPushItemIdBraceletNecklace()
	{
		return null;
	}

	private List<Drop_DropModel.DropData>[] GetPushItemList(CleverBuyType type, Shop_Push push)
	{
		return null;
	}

	private int GetOrGeneratePushId(CleverBuyType type)
	{
		return 0;
	}

	private int GeneratePushId(CleverBuyType type)
	{
		return 0;
	}

	private void ShowPushWindow(CleverBuyType type)
	{
	}

	private bool SavePushDataOnce(CleverBuyType type)
	{
		return false;
	}

	private void UpdatePushStatesAfterShown(CleverBuyType type)
	{
	}

	private void RequestIfPurchasedFirst(Action<bool> callBack)
	{
	}

	private Shop_Push CalcEquipDoubleData()
	{
		return null;
	}

	private void UploadEquipList(Action<bool> callBack)
	{
	}

	private void InitConfig()
	{
	}

	private MaterialBuyCond GetMaterialCond(CleverBuyType type)
	{
		return null;
	}

	private void UpdateConditionsMaterials(CleverBuyType type, object param)
	{
	}

	private void UpdateConditionsEquipDoubleBuy(object param)
	{
	}

	private static PushSource GetPushSource(CleverBuyType type)
	{
		return PushSource.equipment;
	}

	public CleverBuyType[] CurrentPushTypes(IEnumerable<CleverBuyType> filter)
	{
		return null;
	}

	private bool PushExist(CleverBuyType type)
	{
		return false;
	}

	public int CountCurrentPush()
	{
		return 0;
	}

	public static CleverBuyType GetTypeFromInt(int t)
	{
		return CleverBuyType.none;
	}

	public CleverMaterialItemItemData[] LoadPushDataFromJson(CleverBuyType type)
	{
		return null;
	}

	public CleverOnceItemItemData[] LoadPushData(CleverBuyType type)
	{
		return null;
	}

	public int GetUnlockLevelCount(CleverPushItemDataBase[] dataArr)
	{
		return 0;
	}

	public int GetUnlockLevelCount(Shop_Push pushData)
	{
		return 0;
	}

	public int GetIndexPushLevel(Shop_Push pushData)
	{
		return 0;
	}

	public int GetIndexPushLevel(CleverPushItemDataBase[] dataArr)
	{
		return 0;
	}

	private long GetIntervalSeconds(CleverBuyType type)
	{
		return 0L;
	}

	private bool IsCoolingDown(CleverBuyType type, ref string info)
	{
		return false;
	}

	private bool IsCoolingDown(CleverBuyType type, long timestamp, ref string info)
	{
		return false;
	}

	private static int GetTotalCoinsByHour(int hour)
	{
		return 0;
	}

	private static bool IsValidByHistoryPurchase(int pushId)
	{
		return false;
	}

	private static Shop_PushType GetPushTypeConfig(CleverBuyType type)
	{
		return null;
	}
}
