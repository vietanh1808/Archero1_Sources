using System.Collections.Generic;
using UnityEngine;
using XLua;

namespace CampBattle
{
	public class RoundVO
	{
		public int RoundId;

		public bool IsBossRound;

		public int MonsterCount;

		public bool IsFinished;

		public bool IsMonsterFinished;

		public int MaxWave;

		private int curWave;

		private RoundController controller;

		private bool isInKillWaitTime;

		private string UpdateName;

		private bool enableCountDown;

		public RoundMeta roundMeta;

		private float internalTime;

		private float createMonsterTime;

		private float totalTime;

		private int minRadius;

		private int maxRadius;

		private float killWaitTime;

		private float curTime;

		private int oldTimeInSeconds;

		private float curTimeInterval;

		private Dictionary<int, MonsterWeightVO> monsterWeightDict;

		private Dictionary<int, int> monsterCountDict;

		private bool isBirthEffectWorking;

		private static DelegateBridge _c__Hotfix0_ctor;

		private static DelegateBridge __Hotfix0_Init;

		private static DelegateBridge __Hotfix0_DeInit;

		private static DelegateBridge __Hotfix0_onMonsterDead;

		private static DelegateBridge __Hotfix0_get_RemainCreateMonsterTime;

		private static DelegateBridge __Hotfix0_Start;

		private static DelegateBridge __Hotfix0_RoundOver;

		private static DelegateBridge __Hotfix0_hasNoMonster;

		private static DelegateBridge __Hotfix0_onUpdate;

		private static DelegateBridge __Hotfix0_IsMaxRound;

		private static DelegateBridge __Hotfix0_IsMaxWaveReached;

		private static DelegateBridge __Hotfix0_getMonsterCount;

		private static DelegateBridge __Hotfix0_GetSoldierCountRange;

		private static DelegateBridge __Hotfix0_CreateWaveMonsters;

		private static DelegateBridge __Hotfix0_GenerateEffects;

		private static DelegateBridge __Hotfix0_GenerateMonsters;

		private static DelegateBridge __Hotfix0_isElite;

		private static DelegateBridge __Hotfix0_getPickedXYList;

		private static DelegateBridge __Hotfix0_GetMonsterIds;

		private static DelegateBridge __Hotfix0_pickMonsterId;

		private static DelegateBridge __Hotfix0_initMonsterWeightDict;

		private static DelegateBridge __Hotfix0_checkIfBossRound;

		private int RemainCreateMonsterTime => 0;

		public RoundVO(RoundController _controller, int roundId)
		{
		}

		public void Init()
		{
		}

		public void DeInit()
		{
		}

		private void onMonsterDead(EntityBase dead)
		{
		}

		public void Start()
		{
		}

		private void RoundOver()
		{
		}

		private bool hasNoMonster()
		{
			return false;
		}

		private void onUpdate(float deltaTime)
		{
		}

		public bool IsMaxRound()
		{
			return false;
		}

		public bool IsMaxWaveReached()
		{
			return false;
		}

		private int getMonsterCount()
		{
			return 0;
		}

		private int GetSoldierCountRange(int value)
		{
			return 0;
		}

		public void CreateWaveMonsters()
		{
		}

		private void GenerateEffects(List<Vector2Int> pickedXYList)
		{
		}

		private void GenerateMonsters(List<int> monsterIds, List<Vector2Int> pickedXYList)
		{
		}

		private bool isElite()
		{
			return false;
		}

		public List<Vector2Int> getPickedXYList(int monsterCount)
		{
			return null;
		}

		private List<int> GetMonsterIds(int monsterCount)
		{
			return null;
		}

		private int pickMonsterId()
		{
			return 0;
		}

		private void initMonsterWeightDict()
		{
		}

		private void checkIfBossRound(int monsterId)
		{
		}
	}
}
