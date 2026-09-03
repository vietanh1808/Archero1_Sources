using System.Collections.Generic;

public class SkillAlone2318 : SkillAloneBase
{
	private class SyncVO : CustomJsonActionVO
	{
	}

	private float flySwordDuration;

	private int maxFlySwordCount;

	private int buffId;

	private float HitRatio;

	private float DecreaseRatio;

	private float MinRatio;

	private float AngularVelocity;

	private int FlySwordBulletId;

	private List<BulletBase> flySwordBullets;

	private const string SyncAction = "SyncSkill2318_FlySword";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnImpulseEnd()
	{
	}

	private void DoCreateFlySwordAndBuff()
	{
	}

	private void CreateFlySword()
	{
	}

	private void OnFlySwordCache(BulletBase bullet)
	{
	}

	private void SyncFlySword()
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
