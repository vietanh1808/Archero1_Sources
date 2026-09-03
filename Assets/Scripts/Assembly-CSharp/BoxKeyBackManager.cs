using System;
using System.Collections.Generic;
using ActivityConsumeCommon;
using Dxx.Net;
using GameProtocol;

public class BoxKeyBackManager : SingletonNet<BoxKeyBackManager, STReqActivityRebate, STRespActivityRebate>
{
	private bool isSyncData;

	protected override string Name { get; }

	private ConsumeData Data { get; set; }

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	protected override STReqActivityRebate RequestPacket()
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

	protected override void Response(NetResponse response, STRespActivityRebate data, TimeRequest timeRequest = TimeRequest.None)
	{
	}

	protected override bool RequestCond()
	{
		return false;
	}

	public ConsumeItemData GetBoxKeyBackDataByTab(ConsumeTab tab)
	{
		return null;
	}

	public List<ConsumeTaskItemData> GetTaskData(ConsumeTab tab)
	{
		return null;
	}

	public void Request(bool isClick, Action<bool> callback = null)
	{
	}

	public void ReqRewardPersonalTask(int id, Action<bool> callback, int boxType)
	{
	}

	private void OnReqRewardPersonalTaskResponse(NetResponse response, int id, Action<bool> callback, int boxType)
	{
	}

	private static bool ValidateResponse(NetResponse response, out STRespActivityRebate data, int id)
	{
		data = null;
		return false;
	}

	private int TaskDataSorter(STActivityRebateTask a, STActivityRebateTask b)
	{
		return 0;
	}

	public long GetTabBeginTime(ConsumeTab tab)
	{
		return 0L;
	}

	public long GetTabEndTime(ConsumeTab tab)
	{
		return 0L;
	}

	public bool IsTabOpen(ConsumeTab tab)
	{
		return false;
	}

	public bool HaveRed(ConsumeTab tab)
	{
		return false;
	}
}
