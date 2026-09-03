using System.Collections.Generic;
using TableTool;

public class RandomPickRobotMonster
{
	private Farm_BattleAI battleAI;

	private int minPoints;

	private int maxPoints;

	private float baseProbability_pool1;

	private float deltaProbability_pool1;

	private float baseProbability_pool2;

	private float deltaProbability_pool2;

	private List<MonsterRandVO> pool1;

	private List<MonsterRandVO> pool2;

	private List<MonsterRandVO> pool3;

	private List<List<MonsterRandVO>> poolList;

	private Dictionary<int, int> poolPointsDict;

	private List<float> baseProbabilityList;

	private List<float> deltaProbabiltyList;

	private int poolIndex;

	private List<RandomMonsterVO> resultList;

	private int totalMonsterPoints;

	public void Init(Farm_BattleAI _meta)
	{
	}

	private RandomMonsterVO createRandomMonsterVO(MonsterRandVO randVO)
	{
		return null;
	}

	private void generateMonster(List<MonsterRandVO> curPool, float currentProbability)
	{
	}

	public List<RandomMonsterVO> RandomMonster()
	{
		return null;
	}

	private void initProbability()
	{
	}

	private float convertProbability(float value)
	{
		return 0f;
	}

	private int getRandomMonsterPoints()
	{
		return 0;
	}

	private List<MonsterRandVO> getMonsterRandomPool(string[] _MonsterRand)
	{
		return null;
	}
}
