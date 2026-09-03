using UnityEngine;

public class SkillAlone1826 : SkillAloneBase
{
	public class Skill1826_TigerRoarExplode : CustomJsonActionVO
	{
		public Vector3 Pos;
	}

	private float tigerRoarRate;

	private int tigerRoarBulletId;

	private float hitRadius;

	private float hitRatio;

	private int buffId;

	private float tigerRoarCDTime;

	private float preTigerRoarTime;

	private const string SyncSkill1826_TigerRoarExplode = "SyncSkill1826_TigerRoarExplode";

	protected override void OnInstall()
	{
	}

	private void ParseParams()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHitted(EntityBase enemy, long realhit, HitStruct hs)
	{
	}

	public BulletBase CreateExplodeHit(int bulletId, Vector3 bulletPos, float atkPercent, float radius)
	{
		return null;
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void SyncTigerRoarExplode(Vector3 pos)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
