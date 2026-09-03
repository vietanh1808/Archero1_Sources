using System;
using System.Collections.Generic;
using UnityEngine;

public class SkillAlone2337 : SkillAloneBase
{
	private sealed class BossBindContext
	{
		private readonly Dictionary<int, BoundGroup> boundGroupMap;

		public EntityBase Boss { get; }

		public HashSet<int> ActiveBindSkillIds { get; }

		public BossBindContext(EntityBase boss)
		{
		}

		public BoundGroup TryEnsureGroup(Activity7thAnniversaryDaily130RuleHelper.BundleRuleEntry entry)
		{
			return null;
		}

		public bool HasAnyGroupActive(int bindSkillId)
		{
			return false;
		}

		public void Clear(Action onBoundMonsterWillDead, Dictionary<int, BoundGroup> globalMonsterMap)
		{
		}
	}

	private sealed class BoundGroup
	{
		private readonly Dictionary<int, EntityBase> entityMap;

		private readonly Dictionary<int, Activity7thAnniversaryBindLineCtrl> lineMap;

		private GameObject bossBindEffect;

		private float nextRefreshTime;

		public int BossGuid { get; }

		public Activity7thAnniversaryDaily130RuleHelper.BundleRuleEntry Rule { get; }

		public int ActiveCount => 0;

		public BoundGroup(int bossGuid, Activity7thAnniversaryDaily130RuleHelper.BundleRuleEntry rule)
		{
		}

		public void AddEntity(EntityBase entity, Activity7thAnniversaryBindLineCtrl lineCtrl)
		{
		}

		public bool ContainsEntity(int guid)
		{
			return false;
		}

		public EntityBase GetEntity(int guid)
		{
			return null;
		}

		public bool RemoveEntity(int guid)
		{
			return false;
		}

		public void ResetNextRefreshTime(float currentAliveTime)
		{
		}

		public bool TryConsumeInterval(float currentAliveTime)
		{
			return false;
		}

		public void Clear(Action onBoundMonsterWillDead, Dictionary<int, BoundGroup> globalMonsterMap)
		{
		}

		public void EnsureBossBindEffect(EntityBase boss)
		{
		}

		private void RemoveBossBindEffect()
		{
		}
	}

	private const float SearchBossRadius = 1000f;

	private readonly List<Activity7thAnniversaryDaily130RuleHelper.BundleRuleEntry> activeRules;

	private readonly Dictionary<int, BossBindContext> bossContextMap;

	private readonly Dictionary<int, BoundGroup> monsterGuidToGroupMap;

	private string updateName;

	private bool isInBossRoom;

	private Activity7thAnniversaryDaily130RuleHelper.BundleRule bundleRule;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void TryLoadRule()
	{
	}

	private void OnInBossRoom()
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void OnEntityWillDead()
	{
	}

	private void OnBossWillDead()
	{
	}

	private void RefreshBossContexts()
	{
	}

	private List<EntityBase> FindBossEntities()
	{
		return null;
	}

	private void RemoveStaleBossContexts(List<EntityBase> latestBosses)
	{
	}

	private void InitializeBindingsForBoss(BossBindContext context)
	{
	}

	private void TryBindMonsters(BossBindContext context, BoundGroup group, int desiredCount, bool first = false)
	{
	}

	private List<EntityBase> FindBindableMonsters(BossBindContext context, BoundGroup group)
	{
		return null;
	}

	private bool CanBindEntity(BoundGroup group, EntityBase entity)
	{
		return false;
	}

	private void BindOneMonster(BossBindContext context, BoundGroup group, EntityBase entity)
	{
	}

	private void OnBoundMonsterWillDead()
	{
	}

	private void CleanupInvalidBoundMonsters()
	{
	}

	private void RemoveBoundMonsterByGuid(int guid)
	{
	}

	private static List<int> CollectInvalidBoundMonsterGuidsForTest(IDictionary<int, BoundGroup> guidToGroupMap)
	{
		return null;
	}

	private void RefreshBossBindSkill(BossBindContext context, int bindSkillId)
	{
	}

	private void RemoveBossContext(int bossGuid)
	{
	}

	private void ClearAllBindings()
	{
	}

	private static bool IsValidBoss(EntityBase entity)
	{
		return false;
	}
}
