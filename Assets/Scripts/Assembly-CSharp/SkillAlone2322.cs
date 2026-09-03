using System.Collections.Generic;
using UnityEngine;

public class SkillAlone2322 : SkillAloneBase
{
	private class SkillEffect2322_BloomVO : CustomJsonActionVO
	{
		public Vector3 Pos;
	}

	private float bloomRate;

	private int lotusPetalCount;

	private float bloomExplodeDmgRatio;

	private float bloomExplodeRadius;

	private float lotusFlyDistance;

	private float lotusDmgRatio;

	private float smallExplodeDmgRatio;

	private float smallExplodeRadius;

	private int slowDebuffId;

	private int absorbBuffId;

	private float hpRecoverPercent;

	private const int sweepBulletId = 1210403;

	private const int lotusBulletId = 1609;

	private const int lotusRetBulletId = 1610;

	private const int bloomExplodeBulletId = 1611;

	private const int smallExplodeBulletId = 1612;

	private readonly HashSet<BulletBase> returnPetals;

	private const string SyncSkill2322_Bloom = "SyncSkill2322_Bloom";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnHitAction(EntityBase enemy, HitStruct hs, HittedData data)
	{
	}

	private void DoBloom(Vector3 bloomPos)
	{
	}

	private void CreateBloomExplode(Vector3 pos)
	{
	}

	private void CreateSmallExplode(Vector3 pos)
	{
	}

	private void CreateLotusPetal(Vector3 startPos, float angle)
	{
	}

	private void CreateReturnLotusPetal(Vector3 startPos)
	{
	}

	private void SyncBloom(Vector3 pos)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
