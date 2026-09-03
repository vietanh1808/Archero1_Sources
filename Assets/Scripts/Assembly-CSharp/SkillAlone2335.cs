using System.Collections.Generic;
using UnityEngine;

public class SkillAlone2335 : SkillAloneTimerBase
{
	private const int BulletAbilityTypeFlySword = 1;

	private const int BulletAbilityTypeMeteorite = 2;

	private const int BulletAbilityTypeMeteor = 3;

	private const int BulletAbilityGroupSize = 3;

	private const int SearchMinGridRadius = 3;

	private const int SearchMaxGridRadius = 5;

	private const float PickupDistance = 1.2f;

	private const float PotionBulletCreateInterval = 0.1f;

	private const float PotionFlySwordHitRatio = 1f;

	private const float PotionMeteorDropRadius = 3f;

	private const float PotionMeteorInnerRadius = 1.5f;

	private const float PotionMeteorInnerHitRatio = 2f;

	private const float PotionMeteorOutRadius = 2.5f;

	private const float PotionMeteorOutHitRatio = 1f;

	private const float PotionStarDropRadius = 3f;

	private const float PotionStarHitRatio = 1f;

	private readonly List<Activity7thAnniversaryPotionCtrl> activePotions;

	private Activity7thAnniversaryDaily130RuleHelper.PotionRule potionRule;

	private bool isInBossRoom;

	protected override void ParseArgs()
	{
	}

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected override void OnTimer()
	{
	}

	private void TryLoadRule()
	{
	}

	private void OnInBossRoom()
	{
	}

	private void OnEntityWillDead()
	{
	}

	private bool TryFindSpawnPosition(out Vector3 spawnPos)
	{
		spawnPos = default;
		return false;
	}

	private void CreatePotion(Vector3 spawnPos, Activity7thAnniversaryDaily130RuleHelper.PotionRuleEntry entry)
	{
	}

	private void OnPotionPicked(Activity7thAnniversaryPotionCtrl ctrl, Activity7thAnniversaryDaily130RuleHelper.PotionRuleEntry entry)
	{
	}

	private void OnPotionExpired(Activity7thAnniversaryPotionCtrl ctrl)
	{
	}

	private void ApplyPotionEntry(Activity7thAnniversaryDaily130RuleHelper.PotionRuleEntry entry)
	{
	}

	private void ApplyBulletAbility(Activity7thAnniversaryDaily130RuleHelper.PotionRuleEntry entry)
	{
	}

	private void SchedulePotionFlySword(int abilityId, int bulletId, int count)
	{
	}

	private void CreateOnePotionFlySword(int abilityId, int bulletId)
	{
	}

	private void SchedulePotionMeteorite(int abilityId, int bulletId, int count)
	{
	}

	private void CreateOnePotionMeteorite(int abilityId, int bulletId)
	{
	}

	private void SchedulePotionMeteor(int abilityId, int bulletId, int count)
	{
	}

	private void CreateOnePotionMeteor(int abilityId, int bulletId)
	{
	}

	private void RemoveExpiredPotions()
	{
	}

	private void ClearAllPotions()
	{
	}

	private void RemovePotion(Activity7thAnniversaryPotionCtrl ctrl)
	{
	}
}
