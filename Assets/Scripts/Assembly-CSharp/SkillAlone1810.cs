public class SkillAlone1810 : SkillAloneBase
{
	private int HammerFarBulletID;

	private bool isThunderSpear;

	private int addCount;

	private LocalSave.HammerPassiveV0 HammerPassiveV0 => null;

	private LocalSave.Skill1810VO Skill1810VO => null;

	private int HammerPoint => 0;

	private EntityAttributeBase Attribute => null;

	private long LightningChargeStorm => 0L;

	private float LightningChargeOneCooling => 0f;

	private long StormLimit => 0L;

	private int StormStorePercentage => 0;

	private long HammerMeleeCostStorm => 0L;

	private long HammerFarCostStorm => 0L;

	private long ThunderLightChargeStorm => 0L;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}

	private void SendStormEnergyMsg(int count, bool isAdd)
	{
	}

	private void SyncStormEnergy(EntityBase entity, int count)
	{
	}

	private void SendHammerMeleeBulletMsg(EntityBase targetEntity, int buffID)
	{
	}

	private void SyncHammerMeleeBullet(EntityBase entity, EntityBase targetEntity, int buffID)
	{
	}

	private void OnHammerChangeState(bool isThunderSpear)
	{
	}

	private void OnAttack()
	{
	}

	private void ReduceHammerPoint(EntityBase entity, int count, bool isChangeLocal)
	{
	}

	private void CreateHammerMeleeAttackSkill(EntityBase originEntity, EntityBase targetEntity, int buffID)
	{
	}

	private void HammerMeleeAttack()
	{
	}

	private void HammerFarAttack()
	{
	}

	private void HitEnemy(EntityBase attackedTarget, HitStruct arg2, HittedData arg3)
	{
	}

	private void AddHammerPoint(EntityBase entity, int count, bool isChangeLocal)
	{
	}

	private void ThunderSpearAttack()
	{
	}

	private void FlashChainAttack(int enemyGuid)
	{
	}

	private (int, int, int, int) ParseSkillData()
	{
		return default;
	}
}
