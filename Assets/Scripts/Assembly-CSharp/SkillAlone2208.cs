using System.Collections.Generic;
using Dxx.Util;

public class SkillAlone2208 : SkillAloneArtifactBase
{
	private float createLastTime;

	private float createInterval;

	private int[] allBulletID;

	private float bulletRadiusScale;

	private float dropRadius;

	private int perEnemeyCreateMaxCount;

	private float hitratio;

	private int canBulletEject;

	private float bulletDmgScale;

	private Dictionary<int, int> hitEnemyNum;

	private SequencePool sequencePool;

	protected List<int> RealAllBulletID => null;

	protected float RealCreateLastTime => 0f;

	protected float RealCreateInterval => 0f;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected override void SetEntityArtifactActive(bool isShow, bool needUpdateRotate = false)
	{
	}

	protected override void CastSkill()
	{
	}

	protected override void SkillStart()
	{
	}

	protected override void SkillEnd()
	{
	}

	protected override void SkillClear()
	{
	}

	protected void TrySendBullet()
	{
	}

	protected virtual void SendBullet(EntityBase target, int bulletID)
	{
	}

	protected virtual BulletBase CreateSkillBullet(EntityBase target, int bulletID)
	{
		return null;
	}

	protected List<EntityBase> GetAllCanAttackEntity()
	{
		return null;
	}

	private List<int> GetAllBulletID()
	{
		return null;
	}

	private void UpdateBulletTransmit(BulletBase bullet, bool needEject)
	{
	}

	protected override void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void SendBulletMsg(EntityBase target, int bulletID)
	{
	}

	private void SyncBulletMsg(EntityBase target, int bulletID)
	{
	}

	protected override void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
