using UnityEngine;

public class SkillAlone1619 : SkillAloneBase
{
	public class Skill1Effect1619_ChangeRadianceStateIgniteVO : CustomJsonActionVO
	{
		public int State;
	}

	public class Skill1Effect1619_AnglesAngerIgniteVO : CustomJsonActionVO
	{
	}

	private float pShieldRateIntoBattle;

	private float pShiledRateThreshold;

	private int pBuffId;

	private float pRadianceHitRatio;

	private int pRadianceAllowThrough;

	private float pExplodeRadius;

	private float pExplodeHitRatio;

	private int pExplodeBuffId;

	private float pShieldRateRecover;

	private float pEffectCDTime;

	private const int AngerBulletId = 1598;

	private float ratio;

	private int nThroughEnemy;

	private int curRecordWeaponID;

	private float preAngerTime;

	private bool isInRadiance;

	private const string SyncSkill1619_ChangeRadianceState = "SyncSkill1619_ChangeRadianceState";

	private const string SyncSkill1619_AnglesAnger = "SyncSkill1619_AnglesAnger";

	protected override void OnInstall()
	{
	}

	private void ParseParams()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void EnterRadianceState()
	{
	}

	private void ExitRadianceState()
	{
	}

	protected virtual int GetWeaponID()
	{
		return 0;
	}

	private void OnUpdateShieldValue(long cur, long max)
	{
	}

	private void TriggerAnglesAnger()
	{
	}

	public BulletBase CreateAngerExplode(int bulletId, Vector3 bulletPos, float atkPercent, float radius)
	{
		return null;
	}

	private void AddShiledEnterRoom()
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}

	private void SyncAnglesAnger()
	{
	}

	private void SyncState(int state)
	{
	}
}
