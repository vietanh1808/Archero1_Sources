using System;
using Dxx.Net;
using GameProtocol;
using XLua;

public class PuzzleManager : SingletonNet<PuzzleManager, STReqActivityPuzzle, STRespActivityPuzzle>
{
	private static DelegateBridge __Hotfix0_get_Name;

	private static DelegateBridge __Hotfix0_get_PuzzleData;

	private static DelegateBridge __Hotfix0_set_PuzzleData;

	private static DelegateBridge __Hotfix0_get_PuzzleTaskData;

	private static DelegateBridge __Hotfix0_set_PuzzleTaskData;

	private static DelegateBridge __Hotfix0_get_PuzzleChestData;

	private static DelegateBridge __Hotfix0_set_PuzzleChestData;

	private static DelegateBridge __Hotfix0_get_OpenLevel;

	private static DelegateBridge __Hotfix0_set_OpenLevel;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Clear;

	private static DelegateBridge __Hotfix0_RequestPacket;

	private static DelegateBridge __Hotfix0_RequestTime;

	private static DelegateBridge __Hotfix0_AllowBurstRequest;

	private static DelegateBridge __Hotfix0_Response;

	private static DelegateBridge __Hotfix0_RequestCond;

	private static DelegateBridge __Hotfix0_GetPuzzleData;

	private static DelegateBridge __Hotfix0_GetPuzzleTaskData;

	private static DelegateBridge __Hotfix0_GetPuzzleChestData;

	private static DelegateBridge __Hotfix0_Request;

	private static DelegateBridge __Hotfix0_RequestTaskReward;

	private static DelegateBridge __Hotfix0_RequestFinalReward;

	private static DelegateBridge __Hotfix0_RequestChestReward;

	private static DelegateBridge __Hotfix0_GetRewardCompleteCount;

	private static DelegateBridge __Hotfix0_HaveRed;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected override string Name { get; }

	private PuzzleData PuzzleData { get; set; }

	private PuzzleTaskData PuzzleTaskData { get; set; }

	private PuzzleChestData PuzzleChestData { get; set; }

	private int OpenLevel { get; set; }

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	protected override STReqActivityPuzzle RequestPacket()
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

	protected override void Response(NetResponse response, STRespActivityPuzzle data, TimeRequest timeRequest = TimeRequest.None)
	{
	}

	protected override bool RequestCond()
	{
		return false;
	}

	public PuzzleData GetPuzzleData()
	{
		return null;
	}

	public PuzzleTaskData GetPuzzleTaskData()
	{
		return null;
	}

	public PuzzleChestData GetPuzzleChestData()
	{
		return null;
	}

	public void Request()
	{
	}

	public void RequestTaskReward(int id, Action<STRespActivityPuzzle> success = null, Action failure = null)
	{
	}

	public void RequestFinalReward(Action<STRespActivityPuzzle> success = null, Action failure = null)
	{
	}

	public void RequestChestReward(int id, Action<STRespActivityPuzzle> success = null, Action failure = null)
	{
	}

	public int GetRewardCompleteCount()
	{
		return 0;
	}

	public bool HaveRed()
	{
		return false;
	}
}
