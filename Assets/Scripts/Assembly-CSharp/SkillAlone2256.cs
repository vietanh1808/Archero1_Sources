using System.Collections.Generic;
using UnityEngine;

public class SkillAlone2256 : SkillAloneBase
{
	public class SkillEffect2256_SyncFieldVO : CustomJsonActionVO
	{
		public Vector3 Pos;
	}

	public class SkillEffect2256_SyncThunderFallVO : CustomJsonActionVO
	{
		public Vector3 Pos;
	}

	public class SkillEffect2256_SyncWeaponEffVO : CustomJsonActionVO
	{
		public int IsShow;

		public int TarGuid;
	}

	private float chageInterval;

	private int criticalBuffId;

	private float initRadius;

	private float finalRadius;

	private float expandTime;

	private float hitRatio;

	private float addDurationPerHit;

	private int addMaxTime;

	private float callThunderRate;

	private float thunderHitRatio;

	private float thunderCDTime;

	private int thunderDebuffId;

	private int bulletId;

	private int thunderFallBulletId;

	private const string WeaponChargeFxPath = "Effect/Battle/eff_spear_purple_accure";

	private GameObject WeaponChargeFxGo;

	private bool isBuffOn;

	private float preChageTime;

	private Dictionary<int, float> enermyCDictionary;

	private const string SyncSkill2256_SyncField = "SyncSkill2256_SyncField";

	private const string SyncSkill2256_SyncThunderFall = "SyncSkill2256_SyncThunderFall";

	private const string SyncSkill2256_SyncWeaponEff = "SyncSkill2256_SyncWeaponEff";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParam()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void ShowWeaponFx(int isShow, EntityBase en)
	{
	}

	private void OnHit(EntityBase entity, HitStruct hs, HittedData ht)
	{
	}

	private void CreateEnergyBall(Vector3 dest)
	{
	}

	public BulletBase CreateThunderField(int bulletId, Vector3 bulletPos, float atkPercent, float radius, float finalRadius, float expandTime)
	{
		return null;
	}

	public BulletBase CreateThunderFall(int bulletId, Vector3 bulletPos, float atkPercent, float radius)
	{
		return null;
	}

	private void SyncField(Vector3 pos)
	{
	}

	private void SyncThunderFall(Vector3 pos)
	{
	}

	private void SyncWeaponEff(int isShow, int tarGuid)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
