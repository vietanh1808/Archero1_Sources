using System;
using Dxx.Net;
using GameProtocol;

public class SailingGhostFleetManager : SingletonNet<SailingGhostFleetManager, STReqShipBattleSeasonGhostShip, STRespShipBattleSeasonGhostShip>
{
	protected override string Name => null;

	private SailingGhostFleetData SailingGhostFleetData { get; set; }

	private bool HaveSyncData { get; set; }

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	protected override STReqShipBattleSeasonGhostShip RequestPacket()
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

	protected override void Response(NetResponse response, STRespShipBattleSeasonGhostShip data, TimeRequest timeRequest = TimeRequest.None)
	{
	}

	public void SyncData(STRespShipBattleSeasonGhostShip data)
	{
	}

	public bool IsOpen()
	{
		return false;
	}

	public bool IsReachNetVersion()
	{
		return false;
	}

	public bool IsSyncData()
	{
		return false;
	}

	public SailingGhostFleetData GetSailingGhostFleetData()
	{
		return null;
	}

	public SailingGhostFleetShipData GetSailingGhostFleetShipData()
	{
		return null;
	}

	public SailingGhostFleetRankingData GetSailingGhostFleetRankingData()
	{
		return null;
	}

	public string GetAttributeColorString(SailingGhostFleetShipItemAttributeColor attributeColor)
	{
		return null;
	}

	public string GetDifficultColorString(int difficult)
	{
		return null;
	}

	public bool HaveRed()
	{
		return false;
	}

	public void RequestGhostFleetData(Action<STRespShipBattleSeasonGhostShip> success = null, Action<STRespShipBattleSeasonGhostShip> failure = null, bool needMask = true, bool isForce = true)
	{
	}

	public void RequestRefreshShip(Action<STRespShipBattleSeasonGhostShip> success = null, Action<STRespShipBattleSeasonGhostShip> failure = null)
	{
	}
}
