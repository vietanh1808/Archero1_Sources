public class SkillAlone2290 : SkillAloneBase
{
	private class SkillEffect2290_LightningChainVO : CustomJsonActionVO
	{
		public int SourceGuid;
	}

	private float triggerRate;

	private int thunderRingDebuffId;

	private int initEjectCount;

	private float maxChainDistance;

	private float initDamageRatio;

	private float decreaseRatio;

	private float minDamageRatio;

	private float extraDamageRatio;

	private int blessingBuffId;

	private float pvpChainTriggerRate;

	private const int lightningChainBulletId = 9065;

	private const string SyncSkill2290_LightningChain = "SyncSkill2290_LightningChain";

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

	private void ApplyThunderRing(EntityBase target)
	{
	}

	private void OnEnemyDead(EntityBase deadEntity)
	{
	}

	private void CreateLightningChain(EntityBase sourceEntity)
	{
	}

	private void DoCreateLightningChain(EntityBase sourceEntity)
	{
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void SyncLightningChain(int sourceGuid)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
