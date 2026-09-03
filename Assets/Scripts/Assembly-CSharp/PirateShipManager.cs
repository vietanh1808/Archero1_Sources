using System;
using Dxx.Net;
using GameProtocol;

public class PirateShipManager : SingletonNet<PirateShipManager, CReqActivityShip, CRespActivityShip>
{
	public const float PirateShipNormalItemScale = 0.47f;

	protected override string Name => null;

	private PirateShipData PirateShipData { get; set; }

	private bool HaveSynData { get; set; }

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	protected override CReqActivityShip RequestPacket()
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

	protected override void Response(NetResponse response, CRespActivityShip data, TimeRequest timeRequest = TimeRequest.None)
	{
	}

	public PirateShipData GetPirateShipData()
	{
		return null;
	}

	public bool IsOpen()
	{
		return false;
	}

	public bool HaveRed()
	{
		return false;
	}

	public bool HaveCanBuy()
	{
		return false;
	}

	public bool IsSyncData()
	{
		return false;
	}

	public void UpdatePopData()
	{
	}

	public void CheckPop()
	{
	}

	public void RequestReward(int id, Action<CRespActivityShip> success = null, Action<CRespActivityShip> failure = null)
	{
	}
}
