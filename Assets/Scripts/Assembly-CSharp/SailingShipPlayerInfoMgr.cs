using System;
using System.Collections.Generic;
using Dxx.Net;
using GameProtocol;

public class SailingShipPlayerInfoMgr : SingletonNet<SailingShipPlayerInfoMgr, STReqShipBattleSeasonPlayerInfo, STRespShipBattleSeasonPlayerInfo>
{
	public Dictionary<string, double> AttMap { get; set; }

	protected override string Name => null;

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	protected override STReqShipBattleSeasonPlayerInfo RequestPacket()
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

	protected override void Response(NetResponse response, STRespShipBattleSeasonPlayerInfo data, TimeRequest timeRequest = TimeRequest.None)
	{
	}

	public void RequestPlayerCardInfo(ulong userID, Action<SailingPlayerInfoData> callback)
	{
	}

	private Dictionary<string, double> GetAttMap(Dictionary<string, double> aMap)
	{
		return null;
	}
}
