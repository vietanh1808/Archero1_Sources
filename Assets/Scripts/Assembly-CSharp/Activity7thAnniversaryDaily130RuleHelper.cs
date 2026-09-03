using System.Collections.Generic;
using TableTool;
using UnityEngine;

public static class Activity7thAnniversaryDaily130RuleHelper
{
	public sealed class WeaknessRule
	{
		private readonly List<int> fixedOrder;

		private readonly List<int> randomPool;

		private int fixedIndex;

		public int RuleId { get; }

		public int StrategySkillId { get; }

		public int OrderType { get; }

		public List<WeaknessRuleEntry> Entries { get; }

		public WeaknessRule(int ruleId, int strategySkillId, int orderType, List<WeaknessRuleEntry> entries)
		{
		}

		public WeaknessRuleEntry Next()
		{
			return null;
		}

		private void ResetRandomPool()
		{
		}

		private int GetRandomWeightedPoolIndex()
		{
			return 0;
		}
	}

	public sealed class WeaknessRuleEntry
	{
		public int AbilityId { get; }

		public int ActionType { get; }

		public int SkillType { get; }

		public string[] ValueId { get; }

		public float SwitchTime { get; }

		public float DurationTime { get; }

		public int Weight { get; }

		public int FxId { get; }

		public WeaknessRuleEntry(int abilityId, int actionType, int skillType, string[] valueId, float switchTime, float durationTime, int weight, int fxId)
		{
		}
	}

	public sealed class PotionRule
	{
		private readonly WeaknessRule innerRule;

		public int RuleId { get; }

		public int StrategySkillId { get; }

		public int OrderType { get; }

		public List<PotionRuleEntry> Entries { get; }

		public PotionRule(int ruleId, int strategySkillId, int orderType, List<PotionRuleEntry> entries)
		{
		}

		public PotionRuleEntry Next()
		{
			return null;
		}

		private static List<WeaknessRuleEntry> BuildBridgeEntries(List<PotionRuleEntry> entries)
		{
			return null;
		}
	}

	public sealed class PotionRuleEntry
	{
		public int AbilityId { get; }

		public int ActionType { get; }

		public int SkillType { get; }

		public string[] ValueId { get; }

		public int FxId { get; }

		public float SwitchTime { get; }

		public float DurationTime { get; }

		public int Count { get; }

		public int Weight { get; }

		public PotionRuleEntry(int abilityId, int actionType, int skillType, string[] valueId, int fxId, float switchTime, float durationTime, int count, int weight)
		{
		}
	}

	public sealed class CircleRule
	{
		public List<CircleRuleEntry> Entries { get; }

		public CircleRule(List<CircleRuleEntry> entries)
		{
		}
	}

	public sealed class CircleRuleEntry
	{
		private readonly List<int> fixedOrder;

		private readonly List<int> randomPool;

		private int fixedIndex;

		public int RuleId { get; }

		public int Type { get; }

		public string InitPosRaw { get; }

		public int OrderType { get; }

		public string[] TargetPosRaw { get; }

		public float WaitTime { get; }

		public float MoveSpeed { get; }

		public int ActionType { get; }

		public int SkillId { get; }

		public int FxId { get; }

		public CircleRuleEntry(int ruleId, int type, string initPosRaw, int orderType, string[] targetPosRaw, float waitTime, float moveSpeed, int actionType, int skillId, int fxId)
		{
		}

		public string GetNextTargetPosRaw()
		{
			return null;
		}

		public bool TryParseGridPosition(string raw, out Vector2Int gridPosition)
		{
			gridPosition = default;
			return false;
		}

		public bool IsRandomPosition(string raw)
		{
			return false;
		}

		private void ResetRandomPool()
		{
		}
	}

	public sealed class BundleRule
	{
		public List<BundleRuleEntry> Entries { get; }

		public BundleRule(List<BundleRuleEntry> entries)
		{
		}
	}

	public sealed class BundleRuleEntry
	{
		public int RuleId { get; }

		public int Type { get; }

		public int InitNum { get; }

		public int MaxNum { get; }

		public float IntervalTime { get; }

		public int RunNum { get; }

		public int ActionType { get; }

		public int SkillId { get; }

		public int FxId { get; }

		public BundleRuleEntry(int ruleId, int type, int initNum, int maxNum, float intervalTime, int runNum, int actionType, int skillId, int fxId)
		{
		}
	}

	public const int DailyId = 130;

	public const int WeaknessRuleType = 1;

	public const int PotionRuleType = 2;

	public const int AbilitySkillTypeSkill = 0;

	public const int AbilitySkillTypeBuff = 1;

	public const int AbilitySkillTypeAttribute = 2;

	public const int AbilitySkillTypeBullet = 3;

	public static bool TryBuildWeaknessRule(int stageId, out WeaknessRule rule)
	{
		rule = null;
		return false;
	}

	public static bool TryBuildPotionRule(int stageId, out PotionRule rule)
	{
		rule = null;
		return false;
	}

	public static bool TryBuildCircleRule(int stageId, out CircleRule rule)
	{
		rule = null;
		return false;
	}

	public static bool TryBuildBundleRule(int stageId, out BundleRule rule)
	{
		rule = null;
		return false;
	}

	public static List<int> GetBossRoomStrategySkillIds(Daily_StageInfo_130 stageInfo)
	{
		return null;
	}

	private static bool TryGetOrderBean(int stageId, int ruleType, bool allowFallback, out Daily_NormalAbilityOrder_130 orderBean)
	{
		orderBean = null;
		return false;
	}

	private static bool TryParseOrderItem(string raw, out int abilityId, out int weight)
	{
		abilityId = default;
		weight = default;
		return false;
	}

	private static bool TryParsePotionRandomOrderItem(string raw, out int abilityId, out int count, out int weight)
	{
		abilityId = default;
		count = default;
		weight = default;
		return false;
	}

	private static float GetSwitchTime(Daily_NormalAbilityOrder_130 orderBean, Daily_NormalAbilityList_130 abilityBean, int index)
	{
		return 0f;
	}

	private static float NormalizeTime(int rawTime)
	{
		return 0f;
	}

	private static bool IsEmptyAbilityId(string[] abilityId)
	{
		return false;
	}
}
