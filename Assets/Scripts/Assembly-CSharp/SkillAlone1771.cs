using UnityEngine;

public class SkillAlone1771 : SkillAloneBase
{
	private const int PART_ID = 1801;

	private const int GACHA_EGG_BULLET_ID = 8910;

	private const float DELAY_TIME = 0.1f;

	private int maxAtkCount;

	private float atkRatio;

	private float critFactor1;

	private float critFactor2;

	private int maxPartCount;

	private float partCD;

	private int minPartRadius;

	private int maxPartRadius;

	private float partAliveTime;

	private string partAttr;

	private int curAtkCount;

	private int curPartCount;

	private ConditionTime partTimeCondition;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void onRecvCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}

	private void parseArgs2(string[] args)
	{
	}

	private void parseArgs3(string[] args)
	{
	}

	private void parseArgs4(string[] args)
	{
	}

	private void OnHit(EntityBase enemy, HitStruct hs, HittedData hd)
	{
	}

	private void OnCrit(EntityBase enemy, long hit, HitStruct hs)
	{
	}

	private void tryCreateParts(EntityBase enemy, HitStruct hs)
	{
	}

	private void OnAfterMelindaSkillBullet(int cnt)
	{
	}

	private void createBullet(EntityBase entity, Vector3 startDir, int bulletCount)
	{
	}

	private void syncBullet(EntityBase entity, Vector3 dir, int bulletCount)
	{
	}
}
