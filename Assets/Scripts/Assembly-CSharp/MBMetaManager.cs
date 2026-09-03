using System.Collections.Generic;
using TableTool;

public class MBMetaManager
{
	private static MBMetaManager _instance;

	public List<Farm_VictoryReward> FilteredVictoryRewards;

	public static MBMetaManager Instance => null;

	public List<Farm_BattleMonster> MonsterMetaList => null;

	public Farm_BattleConfigModel BattleConfig => null;

	public int DailyFreeCount => 0;

	public int DailyPayCount => 0;

	public string[] MatchCostArr => null;

	public int WinDeltaScore => 0;

	public int RankWeight => 0;

	public int LoseDeltaScore => 0;

	public Farm_BattleMonster GetBattleMonsterByMonsterId(int _monsterID)
	{
		return null;
	}

	public Farm_BattleMonster GetBattleMonsterByCharID(int _charID)
	{
		return null;
	}

	public Farm_VictoryReward GetVictoryReward(uint victoryTimes)
	{
		return null;
	}

	public List<Farm_VictoryReward> GetFilteredVictoryRewards()
	{
		return null;
	}

	public void Init()
	{
	}

	public void Clear()
	{
	}

	public int GetBonusScore(bool isWin, bool haveBonusMonster)
	{
		return 0;
	}
}
