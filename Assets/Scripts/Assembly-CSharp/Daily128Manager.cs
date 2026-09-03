using System;
using System.Collections.Generic;
using System.Diagnostics;
using Dxx.Net;
using GameProtocol;
using TableTool;

public class Daily128Manager : SingletonNet<Daily128Manager, STReqActivityArtifactTrial, STRespActivityArtifactTrial>
{
	private int m_nTag;

	private long m_lStartTime;

	private long m_lEndTime;

	private long m_lRewardTime;

	private int m_nCurLevel;

	private int m_nMaxLevel;

	private uint[] m_aryArtifactIds;

	private STActivityArtifactPointRewardData[] m_vecPointRewardData;

	public const int Integral = 34111;

	private const string LogTag = "Daily128Manager";

	public int Tag => 0;

	public bool IsInSeason => false;

	public long LeftTime => 0L;

	public long RewardLeftTime => 0L;

	public int CurrentLevel
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int MaxLevel => 0;

	public uint[] UIArtifacts => null;

	public STActivityArtifactPointRewardData[] PointRewardDatas => null;

	public List<LocalSave.ArtifactOne> BattleArtifacts => null;

	protected override string Name => null;

	public List<Daily_TrialPoints_128> CurSeasonData => null;

	public List<Drop_DropModel.DropData> MySeasonRewardDatas => null;

	public List<Drop_DropModel.DropData> NextSeasonRewardDatas => null;

	public int IntegralCnt => 0;

	public int NextRewardNeedIntegral => 0;

	public List<ArtifactItemData> GetTalentSkillIDs()
	{
		return null;
	}

	public List<Tuple<int, int>> GetUnlockedSkillTalentArtifacts()
	{
		return null;
	}

	public List<float> GetSpeeds()
	{
		return null;
	}

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	protected override STReqActivityArtifactTrial RequestPacket()
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

	protected override void Response(NetResponse response, STRespActivityArtifactTrial data, TimeRequest timeRequest = TimeRequest.None)
	{
	}

	private void SetData(STRespActivityArtifactTrial data)
	{
	}

	public void SetCurrentLevel(int level)
	{
	}

	[Conditional("EnableLog")]
	public static void Log(string log)
	{
	}

	[Conditional("EnableLog")]
	public static void LogError(string log)
	{
	}
}
