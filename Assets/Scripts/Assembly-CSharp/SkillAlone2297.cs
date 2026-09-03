using System.Collections.Generic;

public class SkillAlone2297 : SkillAloneMeteoriteBase
{
	private class SkillEffect2297_MeteorVO : CustomJsonActionVO
	{
		public float PosX;

		public float PosZ;

		public int ChainCount;
	}

	private float weaponTriggerRate;

	private int summonId;

	private float attackRatio;

	private float dragonBreathRate;

	private int dragonBreathBuffId;

	private float chainTriggerRate;

	private int maxChainCount;

	private float weaponCooldown;

	private float fallRadius;

	private float innerRadius;

	private float outerRadius;

	private float lastWeaponTriggerTime;

	private int hitGuid;

	private Dictionary<BulletSlopeBase, int> bulletChainCount;

	private const string SyncSkill2297_Meteor = "SyncSkill2297_Meteor";

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

	private void TryCreateDragonMeteor(int chainCount)
	{
	}

	private BulletSlopeBase DoCreateDragonMeteor(int chainCount)
	{
		return null;
	}

	protected override void OnSendHit(EntityBase entity, BulletBase bullet)
	{
	}

	private void SyncMeteor(float posX, float posZ, int chainCount)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
