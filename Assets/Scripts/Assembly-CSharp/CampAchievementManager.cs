using System;
using Dxx.Net;
using GameProtocol;
using XLua;

public class CampAchievementManager : SingletonNet<CampAchievementManager, CCampSeasonAchieve, CRespCampSeasonAchieve>
{
	public const int NobilityType = 112;

	public const float TipItemScaleSize = 0.667f;

	private static DelegateBridge __Hotfix0_get_Name;

	private static DelegateBridge __Hotfix0_get_CampAchievementData;

	private static DelegateBridge __Hotfix0_set_CampAchievementData;

	private static DelegateBridge __Hotfix0_get_HaveSyncData;

	private static DelegateBridge __Hotfix0_set_HaveSyncData;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Clear;

	private static DelegateBridge __Hotfix0_RequestPacket;

	private static DelegateBridge __Hotfix0_RequestTime;

	private static DelegateBridge __Hotfix0_AllowBurstRequest;

	private static DelegateBridge __Hotfix0_Response;

	private static DelegateBridge __Hotfix0_RequestCond;

	private static DelegateBridge __Hotfix0_BattleTime;

	private static DelegateBridge __Hotfix0_GetCampAchievementData;

	private static DelegateBridge __Hotfix0_IsCampActivityOpen;

	private static DelegateBridge __Hotfix0_RequestExtraReward;

	private static DelegateBridge __Hotfix0_RequestReward;

	private static DelegateBridge __Hotfix0_HaveRed;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected override string Name { get; }

	private CampAchievementData CampAchievementData { get; set; }

	private bool HaveSyncData { get; set; }

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	protected override CCampSeasonAchieve RequestPacket()
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

	protected override void Response(NetResponse response, CRespCampSeasonAchieve data, TimeRequest timeRequest = TimeRequest.None)
	{
	}

	protected override bool RequestCond()
	{
		return false;
	}

	public long BattleTime()
	{
		return 0L;
	}

	public CampAchievementData GetCampAchievementData()
	{
		return null;
	}

	public bool IsCampActivityOpen()
	{
		return false;
	}

	public void RequestExtraReward(int rewardID, Action<CCommonRespMsg> success = null, Action failure = null)
	{
	}

	public void RequestReward(int rewardID, Action<CCommonRespMsg> success = null, Action<CRespCampSeasonAchieve> failure = null)
	{
	}

	public bool HaveRed()
	{
		return false;
	}
}
