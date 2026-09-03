using System;
using Dxx.Net;
using GameProtocol;

public class Act7thManager : SingletonNet<Act7thManager, STReqActivity7thAnniversary, STRespActivity7thAnniversary>
{
	public Act7thConfigData ConfigData;

	public Act7thMainActivityData ActivityData;

	public bool IsSyncData;

	private bool CheckOk;

	public STRespActivity7thAnniversary mSeverData;

	public Func<bool>[] IsHaveRed;

	public int Tag => 0;

	public long StartTime => 0L;

	public long EndTime => 0L;

	public long RankEndTime => 0L;

	public bool IsOpen => false;

	public int OpenLevel => 0;

	public long ShopOpenTime => 0L;

	public long ShopCloseTime => 0L;

	public long SignStartTime => 0L;

	public long SignCloseTime => 0L;

	public long BpStartTime => 0L;

	public long BpEndTime => 0L;

	public long LuckyPlinkoStartTime => 0L;

	public long LuckyPlinkoGameEndTime => 0L;

	public long LuckyPlinkoEndTime => 0L;

	public long ArtifactStartTime => 0L;

	public long ArtifactEndTime => 0L;

	public long ArtifactGameEndTime => 0L;

	public long GiftTowerStartTime => 0L;

	public long GiftTowerGameEndTime => 0L;

	public long GiftTowerEndTime => 0L;

	public long AngelPurifyStartTime => 0L;

	public long AngelPurifyGameEndTime => 0L;

	public long AngelPurifyEndTime => 0L;

	public long AnniversaryCardStartTime => 0L;

	public long AnniversaryCardGameEndTime => 0L;

	public long AnniversaryCardEndTime => 0L;

	protected override string Name => null;

	private void Check()
	{
	}

	public void ParseConfigData()
	{
	}

	private bool CheckConfigData()
	{
		return false;
	}

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	protected override STReqActivity7thAnniversary RequestPacket()
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

	protected override void Response(NetResponse response, STRespActivity7thAnniversary data, TimeRequest timeRequest = TimeRequest.None)
	{
	}

	public void requestAct7thData(Action<STRespActivity7thAnniversary, int> action = null)
	{
	}

	private void parseAct7thData(STRespActivity7thAnniversary data)
	{
	}

	public void ReqAct7thCleanData()
	{
	}

	public void InitProps(STRespActivity7thAnniversary data)
	{
	}

	private bool ValidResponse(NetResponse response, Action<bool> action)
	{
		return false;
	}

	public bool EntanceRed()
	{
		return false;
	}

	public bool IsWindowPopUp()
	{
		return false;
	}
}
