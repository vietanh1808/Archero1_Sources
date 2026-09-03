using System.Collections.Generic;
using UnityEngine;

public class SkillAlone2325 : SkillAlonePetBase
{
	private class StarOrbData
	{
		public Vector3 position;

		public GameObject effect;
	}

	private float starCreateProbability;

	private int maxStarCount;

	private float collectDistance;

	private int speedBuffId;

	private int mutationLevel;

	private int vampireBuffId;

	private List<StarOrbData> starOrbs;

	private bool mutation15Triggered;

	private EntityPetBase petEntity;

	private static readonly float[] StarAngleSlots;

	private const float STAR_FLY_SPEED = 8f;

	private int _collectBatchCount;

	private int _collectArrivedCount;

	protected override void OnInstall(params object[] args)
	{
	}

	private void OnPetAppear(BattlePetVO vo)
	{
	}

	private void OnPetDisappear(BattlePetVO vo)
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHeroDealDamage(EntityBase target, HitStruct hs, HittedData data)
	{
	}

	private void OnHeroTakeDamage(EntityBase attacker, long damage, HitStruct hs)
	{
	}

	private void TryCreateStarOrb()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void CollectAllStars(EntityBase hero)
	{
	}

	private void OnStarOrbArrived(SkillAlone2325EffectCtrl ctrl)
	{
	}

	private void OnHeroHPChange(long currentHP, long maxHP, float hpPercent, long deltaHP)
	{
	}

	private void CreateStarOrb(Vector3 spawnPos)
	{
	}

	private void ClearAllStarOrbs()
	{
	}
}
