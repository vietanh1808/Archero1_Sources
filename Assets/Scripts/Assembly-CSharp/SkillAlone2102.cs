using UnityEngine;

public class SkillAlone2102 : SkillAloneBase
{
	public class Skill1Effect2102V0 : CustomJsonActionVO
	{
		public Vector3 pos;
	}

	public class Skill1Effect2102V0_EffShow : CustomJsonActionVO
	{
		public int EffId;

		public bool isShow;
	}

	private int killEnemyRecoverBuffId;

	private int damageEnemyRecoverBuffId;

	private float damageRate;

	private int buffId;

	private int attackTimes;

	private float CDTime;

	private float attackInterval;

	private int chargingEffId;

	private int chargedEffId;

	private int bulletId;

	private int curHitCount;

	private float preEffestTime;

	private float preAttackTime;

	private GameObject chargingEff;

	private GameObject chargedEff;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void OnHitEnemy(EntityBase enemy, HitStruct hs, HittedData ht)
	{
	}

	private bool InCDTime()
	{
		return false;
	}

	private void CreateChristBurst(Vector3 pos)
	{
	}

	private void ShowEff(int effId, ref GameObject eff, bool isShow)
	{
	}

	private void SyncChristBurst(Vector3 pos)
	{
	}

	private void SyncEffectShow(int id, bool isShow)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
