using UnityEngine;

public class SkillAlone2308 : SkillAloneBase
{
	private class SyncVO : CustomJsonActionVO
	{
		public long shield;
	}

	private float shieldPerHitPercent;

	private float shieldCapPercent;

	private int hitDebuffId;

	private const int waterBallFlySwordId = 5382;

	private const int EFFECT_ID = 3100030;

	private GameObject shieldFx;

	private long addAmount;

	private const string SyncAction = "SyncSkill2308_Shield";

	private LocalSave.BattleInBase BattleIn => null;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnHit(EntityBase enemy, HitStruct hs, HittedData ht)
	{
	}

	private void DispatchShield(long shieldValue, long shieldCap)
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void AddShieldFx()
	{
	}

	private void RemoveShieldFx()
	{
	}

	private void SyncShield(long shield)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
