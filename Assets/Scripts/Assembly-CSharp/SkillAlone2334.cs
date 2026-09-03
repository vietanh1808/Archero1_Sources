using System.Collections.Generic;

public class SkillAlone2334 : SkillAloneBase
{
	private const float SearchBossRadius = 1000f;

	private readonly List<EntityBase> currentBosses;

	private readonly Dictionary<int, int> activeBossWeaknessBuffMap;

	private string updateName;

	private ConditionTime switchTimer;

	private Activity7thAnniversaryDaily130RuleHelper.WeaknessRule weaknessRule;

	private bool isInBossRoom;

	private int activeWeaknessBuffId;

	private Activity7thAnniversaryDaily130RuleHelper.WeaknessRuleEntry curRuleEntry;

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

	private void ApplyNextWeakness()
	{
	}

	private void StartSwitchTimer(Activity7thAnniversaryDaily130RuleHelper.WeaknessRuleEntry entry)
	{
	}

	private bool RefreshCurrentBosses()
	{
		return false;
	}

	private List<EntityBase> FindBossEntities()
	{
		return null;
	}

	private bool RemoveStaleBosses(List<EntityBase> latestBosses)
	{
		return false;
	}

	private void OnBossWillDead()
	{
	}

	private int ResolveWeaknessBuffId(Activity7thAnniversaryDaily130RuleHelper.WeaknessRuleEntry entry)
	{
		return 0;
	}

	private bool IsEmptyWeaknessEntry(Activity7thAnniversaryDaily130RuleHelper.WeaknessRuleEntry entry)
	{
		return false;
	}

	private void ApplyCurrentWeaknessToAllBosses(Activity7thAnniversaryDaily130RuleHelper.WeaknessRuleEntry nextEntry)
	{
	}

	private void ApplyCurrentWeaknessToBoss(EntityBase boss, Activity7thAnniversaryDaily130RuleHelper.WeaknessRuleEntry nextEntry)
	{
	}

	private void RemoveWeaknessFromAllBosses()
	{
	}

	private void RemoveWeaknessFromBoss(EntityBase boss)
	{
	}

	private void StopCurrentBossTracking()
	{
	}
}
