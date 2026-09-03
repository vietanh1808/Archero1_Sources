using System;
using System.Collections.Generic;
using UnityEngine;

public class SkillAlone2177 : SkillAloneBase
{
	[Serializable]
	private class SyncSkill2177GroundWaveVO : CustomJsonActionVO
	{
		public Vector3 Pos;

		public float Angle;

		public int TargetGuid;
	}

	[Serializable]
	private class SyncSkill2177ShockwaveVO : CustomJsonActionVO
	{
		public Vector3 Pos;
	}

	[Serializable]
	private class SyncSkill2177ExplodeVO : CustomJsonActionVO
	{
		public Vector3 Pos;
	}

	private float shockwaveHitRatio;

	private float shockwaveMaxRadius;

	private float shockwaveSpeed;

	private int tideBaseBuffId;

	private int tideExtraBuffId;

	private float groundWaveRate;

	private float groundWaveHitRatio;

	private float groundWaveCooldown;

	private float explodeHitRatio;

	private float explodeRadius;

	private bool isTideActive;

	private readonly Dictionary<int, float> groundWaveCdMap;

	private const int groundWaveBulletId = 1622;

	private const int groundWaveExplodeBulletId = 1623;

	private SkillAlone2177GoodCtrl shockwaveCtrl;

	private const string SyncSkill2177_GroundWave = "SyncSkill2177_GroundWave";

	private const string SyncSkill2177_Shockwave = "SyncSkill2177_Shockwave";

	private const string SyncSkill2177_Explode = "SyncSkill2177_Explode";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnEnterKnightKing(bool isEnter)
	{
	}

	private void CastShockwave()
	{
	}

	private void CastShockwaveAt(Vector3 pos)
	{
	}

	private void OnShockwaveEnd(int hitCount)
	{
	}

	private void OnHitAction(EntityBase enemy, HitStruct hs, HittedData data)
	{
	}

	private void CreateGroundWaveAt(Vector3 pos, float angle, EntityBase target = null)
	{
	}

	private void OnGroundWaveEnd(BulletBase wave)
	{
	}

	private void CreateExplodeAt(Vector3 pos)
	{
	}

	private void OnBuffRemoved(EntityBase entity, int buffId)
	{
	}

	private void SyncShockwave()
	{
	}

	private void SyncGroundWave(Vector3 pos, float angle, int targetGuid)
	{
	}

	private void SyncExplode(Vector3 pos)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
