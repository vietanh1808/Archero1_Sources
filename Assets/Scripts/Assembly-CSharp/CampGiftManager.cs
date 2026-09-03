using System;
using Dxx.Net;
using GameProtocol;
using XLua;

public class CampGiftManager : SingletonNet<CampGiftManager, CCampSeasonGift, CRespCampSeasonGift>
{
	public const int CampTimingShowTabCount = 3;

	public const string CampNormalTitle = "Slg_Gift_Title";

	public const string CampGiftAddImg = "CampGift_Add_";

	public const string CampGiftBgImg = "CampGift_Bg_";

	public const string CampGiftItemBgImg = "CampGift_ItemBg_";

	public const string CampGiftLightImg = "CampGift_Light_";

	public const string CampGiftSubBgImg = "CampGift_SubBg_";

	public const string CampGiftTabImg = "CampGift_Tab_";

	public const string CampGiftTitleImg = "CampGift_Title_";

	public const int CampDailyIndex = 0;

	public const int CampBattleIndex = 1;

	public const int CampTeamIndex = 2;

	public const int CampTimingNormalHeight = 72;

	public const int CampTimingSelectHeight = 85;

	private static DelegateBridge __Hotfix0_get_Name;

	private static DelegateBridge __Hotfix0_get_DailyGift;

	private static DelegateBridge __Hotfix0_set_DailyGift;

	private static DelegateBridge __Hotfix0_get_BattleGift;

	private static DelegateBridge __Hotfix0_set_BattleGift;

	private static DelegateBridge __Hotfix0_get_TeamGift;

	private static DelegateBridge __Hotfix0_set_TeamGift;

	private static DelegateBridge __Hotfix0_get_TimingGift;

	private static DelegateBridge __Hotfix0_set_TimingGift;

	private static DelegateBridge __Hotfix0_get_HaveSyncData;

	private static DelegateBridge __Hotfix0_set_HaveSyncData;

	private static DelegateBridge __Hotfix0_get_TimeSyncData;

	private static DelegateBridge __Hotfix0_set_TimeSyncData;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Clear;

	private static DelegateBridge __Hotfix0_RequestPacket;

	private static DelegateBridge __Hotfix0_RequestTime;

	private static DelegateBridge __Hotfix0_AllowBurstRequest;

	private static DelegateBridge __Hotfix0_Response;

	private static DelegateBridge __Hotfix0_RequestCond;

	private static DelegateBridge __Hotfix0_IsCampBattleOpen;

	private static DelegateBridge __Hotfix0_GetCampBattleLeftTime;

	private static DelegateBridge __Hotfix0_GetDailyGift;

	private static DelegateBridge __Hotfix0_GetBattleGift;

	private static DelegateBridge __Hotfix0_GetTeamGift;

	private static DelegateBridge __Hotfix0_GetSyncDataTime;

	private static DelegateBridge __Hotfix0_IsDataPassDay;

	private static DelegateBridge __Hotfix0_GetNormalGift;

	private static DelegateBridge __Hotfix0_AddNormalBuyCount;

	private static DelegateBridge __Hotfix0_AddTimingBuyCount;

	private static DelegateBridge __Hotfix0_GetTimingGift;

	private static DelegateBridge __Hotfix0_GetTimingThemeType;

	private static DelegateBridge __Hotfix0_GetFirstTimingCanBuyIndex;

	private static DelegateBridge __Hotfix0_GetMaxTimingCanBuyIndex;

	private static DelegateBridge __Hotfix0_IsSyncData;

	private static DelegateBridge __Hotfix0_TryShowPopupGift;

	private static DelegateBridge __Hotfix0_IsNeedPopupNormalGift;

	private static DelegateBridge __Hotfix0_IsNeedPopupTimingGift;

	private static DelegateBridge __Hotfix0_HaveNormalRed;

	private static DelegateBridge __Hotfix0_RequestReward;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected override string Name { get; }

	private CampNormalGiftData DailyGift { get; set; }

	private CampNormalGiftData BattleGift { get; set; }

	private CampNormalGiftData TeamGift { get; set; }

	private CampTimingGiftData TimingGift { get; set; }

	private bool HaveSyncData { get; set; }

	private long TimeSyncData { get; set; }

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	protected override CCampSeasonGift RequestPacket()
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

	protected override void Response(NetResponse response, CRespCampSeasonGift data, TimeRequest timeRequest = TimeRequest.None)
	{
	}

	protected override bool RequestCond()
	{
		return false;
	}

	public bool IsCampBattleOpen()
	{
		return false;
	}

	public long GetCampBattleLeftTime()
	{
		return 0L;
	}

	public CampNormalGiftData GetDailyGift()
	{
		return null;
	}

	public CampNormalGiftData GetBattleGift()
	{
		return null;
	}

	public CampNormalGiftData GetTeamGift()
	{
		return null;
	}

	public long GetSyncDataTime()
	{
		return 0L;
	}

	public bool IsDataPassDay(long compareTime)
	{
		return false;
	}

	public CampNormalGiftData GetNormalGift(CampGiftType giftType)
	{
		return null;
	}

	public void AddNormalBuyCount(CampGiftType giftType, int id, int count)
	{
	}

	public void AddTimingBuyCount(int id, int count)
	{
	}

	public CampTimingGiftData GetTimingGift()
	{
		return null;
	}

	public CampTimingGiftThemeType GetTimingThemeType(int index)
	{
		return CampTimingGiftThemeType.None;
	}

	public int GetFirstTimingCanBuyIndex()
	{
		return 0;
	}

	public int GetMaxTimingCanBuyIndex()
	{
		return 0;
	}

	public bool IsSyncData()
	{
		return false;
	}

	public void TryShowPopupGift()
	{
	}

	public bool IsNeedPopupNormalGift()
	{
		return false;
	}

	public bool IsNeedPopupTimingGift()
	{
		return false;
	}

	public bool HaveNormalRed()
	{
		return false;
	}

	public void RequestReward(int rewardID, CampGiftType rewardType, Action<CRespCampSeasonGift> success = null, Action failure = null)
	{
	}
}
