using UnityEngine;

public class SkillAlone2319 : SkillAloneBase
{
	private class SyncVO : CustomJsonActionVO
	{
	}

	private float maxSpeedBoost;

	private float speedDecayDuration;

	private float flySwordDuration;

	private float explodeRadius;

	private float explodeAtkPercent;

	private float HitRatio;

	private float DecreaseRatio;

	private float MinRatio;

	private float AngularVelocity;

	private const int FlySwordBulletId = 3073;

	private float currentSpeedBoost;

	private float enterKnightTime;

	private bool isSpeedBoosting;

	private const int explodeBulletId = 1613;

	private const string SyncAction = "SyncSkill2319_FlySword";

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

	private void StartSpeedBoost()
	{
	}

	private void OnSpeedDecayUpdate(float delta)
	{
	}

	private void RemoveSpeedBoost()
	{
	}

	private void CreateFlySword()
	{
	}

	private void DoCreateFlySword()
	{
	}

	private void OnCreateFlySword(BulletBase bullet, float hitRatio)
	{
	}

	private void OnFlySwordStopTrack(Bullet3071 bullet)
	{
	}

	private void CreateExplodeBullet(Vector3 pos, float angle)
	{
	}

	private void SyncCreateFlySword()
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
