using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1828 : SkillAloneBase
{
	public class Skill1828_RingExplode : CustomJsonActionVO
	{
		public Vector3 Pos;
	}

	public class Skill1828_BurnGround : CustomJsonActionVO
	{
		public int IsInit;

		public Vector3 Pos;
	}

	private float ringExpandTime;

	private float ringInitRadius;

	private float ringMaxRadius;

	private float ringInitWidth;

	private float ringMaxWidth;

	private float ringAngularVelocity;

	private float ringHitRatio;

	private float ringInterval;

	private float explodeHitRatio;

	private float explodeThunderRate;

	private float ringExplodeRadius;

	private float fallThunderHitRatio;

	private float fallThunderHitFactor;

	private float callBurnRate;

	private int burnBuffId;

	private int[] burnDebuffs;

	private float burnDuration;

	private int burnAreaGrid;

	private int maxBurnAreaCount;

	private float preRingEffectTime;

	private GameObject ringEff;

	private int ringExplodeBulletId;

	private int newThunderFallBulletId;

	private const string BurnEffPath = "Game/SkillPrefab/SkillAlone1828Burn";

	private const string BurnEnermyEffPath = "Game/SkillPrefab/SkillAlone1828BurnEnermy";

	private List<int> burnAreaList;

	private List<float> burnAreaStartTime;

	private Dictionary<int, int> allBurnUnitsDict;

	private Dictionary<int, GameObject> allBurnGoUnitsDict;

	private const string SyncSkill1828_RingExplode = "SyncSkill1828_RingExplode";

	private const string SyncSkill1828_BurnGround = "SyncSkill1828_BurnGround";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void OnHitAction(EntityBase enermy, HitStruct hs, HittedData ht)
	{
	}

	private void CreateBurnGround(Vector3 enermyPos, bool isFromEnermy)
	{
	}

	private void DestroyBurnGround()
	{
	}

	private void OnFireRingHitEnermy(EntityBase enermy)
	{
	}

	private void InitRing()
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	public BulletBase CreateRingExplode(int bulletId, Vector3 bulletPos, float atkPercent, float radius)
	{
		return null;
	}

	private float ThunderFallHitRise()
	{
		return 0f;
	}

	private void SyncRingExplode(Vector3 pos)
	{
	}

	private void SyncBurnGround(Vector3 pos, int isInit)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
