using System;
using Dxx.Net;
using GameProtocol;
using XLua;

public class DailyBackManager : SingletonNet<DailyBackManager, CReqResourceFindBack, CRespResourceFindBack>
{
	private bool haveData;

	public const int ReachCondID = 3209;

	public const int DayCountID = 3210;

	public const int PercentID = 3211;

	public const int DailyBackKey = 1001;

	public const int DailyBackPersonalRisk = 2001;

	public const int DailyBackBulletsFlying = 3001;

	public const int DailyVipPrivilegeConfigID = 58;

	private static DelegateBridge __Hotfix0_get_DailyBackData;

	private static DelegateBridge __Hotfix0_set_DailyBackData;

	private static DelegateBridge __Hotfix0_get_DailyBackRewardData;

	private static DelegateBridge __Hotfix0_set_DailyBackRewardData;

	private static DelegateBridge __Hotfix0_get_Name;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Clear;

	private static DelegateBridge __Hotfix0_RequestTime;

	private static DelegateBridge __Hotfix0_AllowBurstRequest;

	private static DelegateBridge __Hotfix0_RequestPacket;

	private static DelegateBridge __Hotfix0_Response;

	private static DelegateBridge __Hotfix0_RequestCond;

	private static DelegateBridge __Hotfix0_RequestReward;

	private static DelegateBridge __Hotfix0_UpdateProgress;

	private static DelegateBridge __Hotfix0_GetDailyBackData;

	private static DelegateBridge __Hotfix0_GetDailyBackRewardData;

	private static DelegateBridge __Hotfix0_HaveData;

	private static DelegateBridge __Hotfix0_HaveAnyReward;

	private static DelegateBridge _c__Hotfix0_ctor;

	private DailyBackData DailyBackData { get; set; }

	private DailyBackRewardData DailyBackRewardData { get; set; }

	protected override string Name => null;

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	public override SendRequestTime RequestTime()
	{
		return SendRequestTime.None;
	}

	protected override bool AllowBurstRequest()
	{
		return false;
	}

	protected override CReqResourceFindBack RequestPacket()
	{
		return null;
	}

	protected override void Response(NetResponse response, CRespResourceFindBack data, TimeRequest timeRequest = TimeRequest.None)
	{
	}

	protected override bool RequestCond()
	{
		return false;
	}

	public void RequestReward(int rewardID, int backType, int backCount, Action<CRespResourceFindBack> success = null, Action failure = null)
	{
	}

	private void UpdateProgress(int rewardID, int backCount)
	{
	}

	public DailyBackData GetDailyBackData()
	{
		return null;
	}

	public DailyBackRewardData GetDailyBackRewardData()
	{
		return null;
	}

	public bool HaveData()
	{
		return false;
	}

	public bool HaveAnyReward()
	{
		return false;
	}
}
