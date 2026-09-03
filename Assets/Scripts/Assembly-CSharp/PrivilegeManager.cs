using System;
using System.Collections.Generic;
using Dxx.Net;
using GameProtocol;

public class PrivilegeManager : SingletonNet<PrivilegeManager, CReqPrivilegeCard, CRespPrivilegeCard>
{
	public const int PermanentID = 3;

	public const int DiamondID = 4;

	protected override string Name { get; }

	private PrivilegeData PrivilegeData { get; set; }

	private PermanentPrivilegeData PermanentPrivilegeData { get; set; }

	private DiamondPrivilegeData DiamondPrivilegeData { get; set; }

	private bool HaveSyncData { get; set; }

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	protected override CReqPrivilegeCard RequestPacket()
	{
		return null;
	}

	public void ReqDiamondRequest(int type, int id, Action<bool> action)
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

	protected override bool RequestCond()
	{
		return false;
	}

	protected override void Response(NetResponse response, CRespPrivilegeCard data, TimeRequest timeRequest = TimeRequest.None)
	{
	}

	private void SetData(List<PrivilegeConfig> config, List<PrivilegePowerConfig> powerConfig, bool isPermanentActive, bool isDiamondActive, bool isDiamondDailyRewardGot)
	{
	}

	private void InitData()
	{
	}

	public PrivilegeData GetPrivilegeData()
	{
		return null;
	}

	public PermanentPrivilegeData GetPermanentPrivilegeData()
	{
		return null;
	}

	public DiamondPrivilegeData GetDiamondPrivilegeData()
	{
		return null;
	}

	public PrivilegePowerConfig GetPrivilegePowerConfig(int id)
	{
		return null;
	}

	public List<PrivilegePowerConfig> GetPrivilegeAllPowerConfig()
	{
		return null;
	}

	public int GetPrivilegeValueByType(PrivilegeType type)
	{
		return 0;
	}

	public bool IsPermanentActive()
	{
		return false;
	}

	public bool IsPermanentOpen()
	{
		return false;
	}

	public bool IsPermanentCanBuy()
	{
		return false;
	}

	public bool IsDiamondActive()
	{
		return false;
	}

	public bool IsDiamondOpen()
	{
		return false;
	}

	public bool IsDiamondCanBuy()
	{
		return false;
	}

	public bool IsDiamondDailyRewardGot()
	{
		return false;
	}
}
