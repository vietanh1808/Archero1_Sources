using System;
using Dxx.Net;
using GameProtocol;
using XLua;

public class LuckyWheelManager : SingletonNet<LuckyWheelManager, CReqActivityLuckyWheel, CRespActivityLuckyWheel>
{
	public const int LuckyWheelAverageCount = 8;

	public const string LuckyWheelItemBgName = "LuckyWheel_Item_";

	public const float LuckyWheelTaskAniTime = 0.25f;

	public const string LuckyWheelExtraRewardStatusName = "Vip_Box";

	public const string LuckyWheelTaskName = "LuckyWheel_Task_Type";

	public const float LuckyWheelExtraRewardWidth = 51f;

	public const float LuckyWheelExtraRewardTipItemScale = 0.65f;

	public const float LuckyWheelRewardAniTime = 6f;

	public const float LuckyWheelRewardAniOffsetAngle = 1080f;

	public const float LuckyWheelRewardAniResultWaitTime = 1f;

	public const float LuckyWheelRewardLightSwitchingInterval = 1f;

	public const float LuckyWheelRewardLightSwitchingWaitInterval = 0.12f;

	public const float LuckyWheelRewardLightSwitchingStartInterval = 0.05f;

	private LuckyWheelData LuckyWheelData;

	private LuckyWheelRewardData LuckyWheelRewardData;

	private LuckyWheelTaskData LuckyWheelTaskData;

	private LuckyWheelExtraRewardData LuckyWheelExtraRewardData;

	private bool haveSyncData;

	private bool haveSyncCondData;

	private static DelegateBridge __Hotfix0_get_Name;

	private static DelegateBridge __Hotfix0_get_LuckyWheelPerAverageAngle;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Clear;

	private static DelegateBridge __Hotfix0_RequestPacket;

	private static DelegateBridge __Hotfix0_RequestTime;

	private static DelegateBridge __Hotfix0_AllowBurstRequest;

	private static DelegateBridge __Hotfix0_RequestCond;

	private static DelegateBridge __Hotfix0_Response;

	private static DelegateBridge __Hotfix0_IsActivityOpen;

	private static DelegateBridge __Hotfix0_HaveSyncData;

	private static DelegateBridge __Hotfix0_GetLuckyWheelData;

	private static DelegateBridge __Hotfix0_GetLuckyWheelRewardData;

	private static DelegateBridge __Hotfix0_GetLuckyWheelTaskData;

	private static DelegateBridge __Hotfix0_GetLuckyWheelExtraRewardData;

	private static DelegateBridge __Hotfix0_AllowDrawCount;

	private static DelegateBridge __Hotfix0_HaveRed;

	private static DelegateBridge __Hotfix0_HaveFreeDrawRed;

	private static DelegateBridge __Hotfix0_HaveExtraRewardRed;

	private static DelegateBridge __Hotfix0_HaveTaskRed;

	private static DelegateBridge __Hotfix0_RequestWheelReward;

	private static DelegateBridge __Hotfix0_RequestTaskReward;

	private static DelegateBridge __Hotfix0_RequestExtraReward;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected override string Name => null;

	public float LuckyWheelPerAverageAngle => 0f;

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	protected override CReqActivityLuckyWheel RequestPacket()
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

	protected override bool RequestCond()
	{
		return false;
	}

	protected override void Response(NetResponse response, CRespActivityLuckyWheel data, TimeRequest timeRequest = TimeRequest.None)
	{
	}

	public bool IsActivityOpen()
	{
		return false;
	}

	public bool HaveSyncData()
	{
		return false;
	}

	public LuckyWheelData GetLuckyWheelData()
	{
		return null;
	}

	public LuckyWheelRewardData GetLuckyWheelRewardData()
	{
		return null;
	}

	public LuckyWheelTaskData GetLuckyWheelTaskData()
	{
		return null;
	}

	public LuckyWheelExtraRewardData GetLuckyWheelExtraRewardData()
	{
		return null;
	}

	public int AllowDrawCount()
	{
		return 0;
	}

	public bool HaveRed()
	{
		return false;
	}

	public bool HaveFreeDrawRed()
	{
		return false;
	}

	public bool HaveExtraRewardRed()
	{
		return false;
	}

	public bool HaveTaskRed()
	{
		return false;
	}

	public void RequestWheelReward(int num, Action<CRespActivityLuckyWheel> success = null, Action<CRespActivityLuckyWheel> failure = null)
	{
	}

	public void RequestTaskReward(int id, Action<CRespActivityLuckyWheel> success = null, Action<CRespActivityLuckyWheel> failure = null)
	{
	}

	public void RequestExtraReward(int id, Action<CRespActivityLuckyWheel> success = null, Action failure = null)
	{
	}
}
