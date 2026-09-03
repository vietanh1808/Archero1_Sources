using UnityEngine;

public class SkillAlone1616 : SkillAloneBase
{
	public class SkillEffect1616IgniteVO_SyncCoreEnergy : CustomJsonActionVO
	{
		public int coreEnergy;
	}

	public class SkillEffect1616IgniteVO_SyncLaserTarget : CustomJsonActionVO
	{
		public int TGuid;
	}

	public class SkillEffect1616IgniteVO_SyncLaserHit : CustomJsonActionVO
	{
		public long Hit;

		public int SGuid;

		public int TGuid;
	}

	private int lifeReduceRate;

	private int coreChargeRate;

	private int killEnemyChargeRate;

	private int chargeRatePerSec;

	private float fullDamageHitRate;

	private float fullDamageRadius;

	private float perDamageHitRate;

	private int attackMaxCount;

	private float initialAttackInterval;

	private float attackSpeedFactor;

	private float minAttackInterval;

	private int bloodThirstyBuffId;

	private float angerRate;

	private int fullExplodeBulletId;

	private const int EnergyFull = 100;

	private int hittedCount;

	private int curEnergyNum;

	private bool isCoreExploded;

	private float preAddEnergyTime;

	private float preHitEnemyTime;

	private EntityBase laserAttackTarget;

	private const string Skill1Effect1616_SycCoreEnergy = "Skill1Effect1616_SycCoreEnergy";

	private const string SkillEffect1616_SyncLaserTargetGuid = "SkillEffect1616_SyncLaserTargetGuid";

	private const string SkillEffect1616_SyncHitWithGuid = "SkillEffect1616_SyncHitWithGuid";

	private LanceCrystalCtrl topCoreEffCtrl;

	private GameObject topCoreEff;

	private GameObject laserEff;

	private Transform laserSpawn;

	private SkillAlone2149EffectCtrl laserFxCtrl;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnHitted(EntityBase entity, long value)
	{
	}

	private void OnChangeHP(long currentHP, long maxHP, float percent, long change)
	{
	}

	private void OnKill(EntityBase enemy, Vector3 vector, HitStruct hs)
	{
	}

	private void OnHitAction(EntityBase enemy, HitStruct hs, HittedData ht)
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private float GetHitInterval()
	{
		return 0f;
	}

	private void EnterCoreExplode()
	{
	}

	private void _EnterCoreExplode()
	{
	}

	private void SetTopFxParent(GameObject parent)
	{
	}

	private void ExitCoreExplode()
	{
	}

	private void _ExitCoreExplode()
	{
	}

	public BulletBase CreateFullEnergyExplode(int bulletId, Vector3 bulletPos, float atkPercent, float radius)
	{
		return null;
	}

	private void UpdateEnergy(int curEnergy)
	{
	}

	private void ShowLaserFx(bool isShow)
	{
	}

	private void SyncEnergy(int energy)
	{
	}

	private void SyncLaserTargetGuid(int guid)
	{
	}

	private void SendHitWithGuid(int TGuid, int SGuid, long hit)
	{
	}

	protected override void OnRecvCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO vo)
	{
	}
}
