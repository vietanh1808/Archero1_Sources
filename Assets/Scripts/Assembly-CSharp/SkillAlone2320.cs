using System.Collections.Generic;

public class SkillAlone2320 : SkillAloneBase
{
	private class SyncVO : CustomJsonActionVO
	{
	}

	private float triggerRate;

	private int holyLotusBuffId;

	private float stickRateAdd;

	private int flySwordCount;

	private int flySwordBulletId;

	private float flySwordHotRatio;

	private float decreaseRatio;

	private float minRatio;

	private float angularVelocity;

	private float lotusExplosionCD;

	private bool isHolyLotusActive;

	private ConditionTime triggerCD;

	private List<BulletBase> flySwordBullets;

	private const string SyncAction = "SyncSkill2320_EnterHolyLotus";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnHit(EntityBase entity, HitStruct hs, HittedData hd)
	{
	}

	private void EnterHolyLotus()
	{
	}

	private void DoEnterHolyLotus()
	{
	}

	private void CreateFlySword()
	{
	}

	private void OnFlySwordCache(BulletBase bullet)
	{
	}

	private void OnBuffRemoved(EntityBase entity, int buffId)
	{
	}

	private void ClearFlySwords()
	{
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void SyncEnterHolyLotus()
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
