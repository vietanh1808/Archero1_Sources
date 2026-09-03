using System;
using System.Collections.Generic;
using Dxx.Net;
using GameProtocol;

public class ConsumeLifeMgr : SingletonNet<ConsumeLifeMgr, STReqActivityCostLife, STRespActivityCostLife>
{
	private bool isSyncData;

	protected override string Name { get; }

	private ConsumeItemData Data { get; set; }

	public bool EventExists => false;

	public long beginTime => 0L;

	public long endTime => 0L;

	public bool EventStart => false;

	public bool EventEnd => false;

	public bool IsOpen => false;

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	protected override STReqActivityCostLife RequestPacket()
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

	protected override void Response(NetResponse response, STRespActivityCostLife data, TimeRequest timeRequest = TimeRequest.None)
	{
	}

	protected override bool RequestCond()
	{
		return false;
	}

	public ConsumeItemData GetData()
	{
		return null;
	}

	public List<ConsumeTaskItemData> GetTaskData()
	{
		return null;
	}

	public void Request(bool isClick, Action<bool> callback = null)
	{
	}

	public void ReqRewardPersonalTask(int id, Action<bool> callback)
	{
	}

	private void OnReqRewardPersonalTaskResponse(NetResponse response, int id, Action<bool> callback)
	{
	}

	private static bool ValidateResponse(NetResponse response, out STRespActivityCostLife data, int id)
	{
		data = null;
		return false;
	}

	private int TaskDataSorter(STActivityRebateTask a, STActivityRebateTask b)
	{
		return 0;
	}

	public bool HaveRed()
	{
		return false;
	}
}
