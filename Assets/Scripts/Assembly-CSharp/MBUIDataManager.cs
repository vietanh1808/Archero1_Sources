using GameProtocol;
using TableTool;

public class MBUIDataManager
{
	private static MBUIDataManager _instance;

	private STFarmPvpRespInfo meadowBattleInfo;

	private int[] diamondArr;

	private const int configId = 3169;

	public static MBUIDataManager Instance => null;

	public bool IsMeadowBattleUnlocked => false;

	public int BattleMonsterCount => 0;

	public STFarmPvpRespInfo MeadowBattleInfo => null;

	public uint OldScore { get; set; }

	public ushort CurWinBoxes => 0;

	public uint CurGachaCoin => 0u;

	public uint BattleMatches => 0u;

	public int[] BonusMonsters => null;

	public FarmSeasonData CurFarmSeasonData => null;

	public long CurSeasonEndTime => 0L;

	public bool IsCurrentSeasonEnd => false;

	public int GachaCoinCost => 0;

	public uint SubDivision => 0u;

	public uint CurScore => 0u;

	public int CurFreeCount => 0;

	public int CurPayCount => 0;

	public bool HasMBInfo => false;

	public int CurSeasonId => 0;

	public int CurRank => 0;

	public int CurDiamondLayer => 0;

	public int MaxDiamondLayer => 0;

	public void Init()
	{
	}

	public void Clear()
	{
	}

	public void SetMeadowBattleInfo(STFarmPvpRespInfo _meadowBattleInfo)
	{
	}

	public int VictoryRewardID(Farm_VictoryReward meta)
	{
		return 0;
	}

	public bool HaveWinBox(Farm_VictoryReward meta)
	{
		return false;
	}

	public bool HaveGotBox(Farm_VictoryReward meta)
	{
		return false;
	}

	public bool CanGetWinBox(Farm_VictoryReward meta)
	{
		return false;
	}

	public void UpdateWinBoxes(STFarmPvpRewardRespInfo data)
	{
	}

	public void UpdateGachaCoin(STFarmPvpRewardRespInfo data)
	{
	}

	public void UpdateDiamondCount(STFarmPvpRewardRespInfo data)
	{
	}

	public void UpdateScore(STFarmPvpBattleRespInfo data, int clientScore = 0)
	{
	}

	public void UpdateCount(STFarmPvpBattleRespInfo data)
	{
	}

	public bool CanFreePlay()
	{
		return false;
	}

	public bool CanPayPlay()
	{
		return false;
	}

	public bool IsNetworkDown()
	{
		return false;
	}

	public void InitDiamondArr()
	{
	}

	public int GetCurDiamondCount()
	{
		return 0;
	}
}
