using System.Collections.Generic;
using UnityEngine;

public class Bullet1911 : BulletBase
{
	[SerializeField]
	protected int bulletId;

	private int freezeBulletId;

	[SerializeField]
	private CapsuleCollider capsuleCollider;

	private float ExplodeRadius;

	private float ExplodeHitRatio;

	private const int towerId = 1856;

	private List<SkillAloneGoodCtrlBase> mList;

	private static bool isMakeFirePath;

	private float FirePathDuration;

	private float defaultDistance;

	private int debuffId;

	private ActionFirePath firePath;

	protected override void OnInit()
	{
	}

	protected override void OnSetBulletAttribute()
	{
	}

	protected override void OnDeInit()
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	protected BulletBase CreateBullet(int bulletId, Vector3 bulletPos, float rota, float atkPercent, float radius, float radiusRate)
	{
		return null;
	}

	protected override void HitWater(Collider o)
	{
	}

	private bool HitWalls(Collider o)
	{
		return false;
	}

	protected override void CheckCapsuleHits()
	{
	}
}
