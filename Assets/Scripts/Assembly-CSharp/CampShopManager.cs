using System;
using Dxx.Net;
using GameProtocol;
using TableTool;
using XLua;

public class CampShopManager : SingletonNet<CampShopManager, CReqCampSeasonStore, CRespCampSeasonStore>
{
	public const string ShopACurrency = "Currency_CampShopCoinA";

	public const string ShopBCurrency = "Currency_CampShopCoinB";

	public const int PerCowItemCount = 3;

	public const float ScrollOffset = 23f;

	private static DelegateBridge __Hotfix0_get_Name;

	private static DelegateBridge __Hotfix0_get_CampShopData;

	private static DelegateBridge __Hotfix0_set_CampShopData;

	private static DelegateBridge __Hotfix0_get_HaveSyncData;

	private static DelegateBridge __Hotfix0_set_HaveSyncData;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_LateInit;

	private static DelegateBridge __Hotfix0_Clear;

	private static DelegateBridge __Hotfix0_RequestPacket;

	private static DelegateBridge __Hotfix0_RequestTime;

	private static DelegateBridge __Hotfix0_AllowBurstRequest;

	private static DelegateBridge __Hotfix0_Response;

	private static DelegateBridge __Hotfix0_RequestCond;

	private static DelegateBridge __Hotfix0_GetCampShopData;

	private static DelegateBridge __Hotfix0_IsCampActivityOpen;

	private static DelegateBridge __Hotfix0_CampActivityLeftTime;

	private static DelegateBridge __Hotfix0_IsSyncData;

	private static DelegateBridge __Hotfix0_GetShopItemName;

	private static DelegateBridge __Hotfix0_RequestShopData;

	private static DelegateBridge __Hotfix0_RequestReward;

	private static DelegateBridge __Hotfix0_SetData;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected override string Name { get; }

	private CampShopData CampShopData { get; set; }

	private bool HaveSyncData { get; set; }

	protected override void Init()
	{
	}

	protected override void LateInit()
	{
	}

	protected override void Clear()
	{
	}

	protected override CReqCampSeasonStore RequestPacket()
	{
		return null;
	}

	public override SendRequestTime RequestTime()
	{
		return SendRequestTime.None;
	}

	protected override bool AllowBurstRequest()
	{
		return false;
	}

	protected override void Response(NetResponse response, CRespCampSeasonStore data, TimeRequest timeRequest = TimeRequest.None)
	{
	}

	protected override bool RequestCond()
	{
		return false;
	}

	public CampShopData GetCampShopData()
	{
		return null;
	}

	public bool IsCampActivityOpen()
	{
		return false;
	}

	public long CampActivityLeftTime()
	{
		return 0L;
	}

	public bool IsSyncData()
	{
		return false;
	}

	public string GetShopItemName(Drop_DropModel.DropData reward)
	{
		return null;
	}

	public void RequestShopData()
	{
	}

	public void RequestReward(int rewardID, int type, Action<CRespCampSeasonStore> success = null, Action failure = null)
	{
	}

	private void SetData(CCampExchangeData[] shopAData, CCampExchangeData[] shopBData, int coinA, int coinB)
	{
	}
}
