using UnityEngine;

public class SkillAlone2263 : SkillAloneBase
{
	public class Skill2263_ChristmasExplode : CustomJsonActionVO
	{
		public Vector3 Pos;
	}

	private float explodeRadius;

	private float explodeHitRatio;

	private int buffId;

	private bool shouldExplode;

	private bool isReal;

	private int transToShadowTimes;

	private const int explodeBulletId = 1600;

	private const string SyncSkill2263_ChristmasExplode = "SyncSkill2263_ChristmasExplode";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnHit(EntityBase attackTarget, HitStruct hit, HittedData hitteddata)
	{
	}

	private void OnEnemyDing(EntityBase target)
	{
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void OnSwitch(bool normal)
	{
	}

	public BulletBase CreateExplode(int bulletId, Vector3 bulletPos, float atkPercent, float radius)
	{
		return null;
	}

	private void SyncShockExplode(Vector3 pos)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
