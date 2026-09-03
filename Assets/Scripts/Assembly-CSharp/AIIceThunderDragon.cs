using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class AIIceThunderDragon : AIDragonBase
{
	public float laserBallScale;

	public float laserEffectScale;

	public float deltaRadius;

	private const int ICE_BULLET_ID = 1227;

	private const int THUNDER_BULLET_ID = 1228;

	private float totalTime;

	private float startTime;

	private int startFrame;

	private int attackLoopCount;

	private Tweener scaleTweener;

	public EntityBase HatredTarget;

	private List<BulletBase> bulletList;

	private bool isHatredTargetLocked;

	private GameObject goLaserBall;

	private GameObject goLaserAppear;

	private GameObject goLaser;

	private Dictionary<string, float> originalPSTimeDict;

	private float mainPSTime;

	private float startRadius;

	private int maxBulletCount;

	private Coroutine bulletCortoutine;

	private int bulletCountPerFrame;

	private int curBulletCount;

	private float lastRadius;

	private Vector3 lastPos;

	private float preTime;

	protected override int AttackLoopCount => 0;

	protected override float deltaSpeed => 0f;

	protected override void OnInit1()
	{
	}

	protected override void OnUpdate(float delta)
	{
	}

	public override void DeInit()
	{
	}

	public override void BeforeStartAttack()
	{
	}

	protected override void BeforeSkillAppear()
	{
	}

	protected override void BeforeSkillAttackPre()
	{
	}

	protected override void AfterSkillAttackPre()
	{
	}

	protected override void BeforeSkillContinuousAttack()
	{
	}

	protected override void AfterSkillContinuousAttack()
	{
	}

	protected override void AfterSkillDisappear()
	{
	}

	protected override AIBase.ActionSequence getAnimSequenceAction()
	{
		return null;
	}

	private void initEffects()
	{
	}

	private void clearEffects()
	{
	}

	private void sendReleaseBuff()
	{
	}

	private void calculateContinuousAtkDeltaSpeed()
	{
	}

	private void calculateAttackLoopCount()
	{
	}

	private void clearBullets()
	{
	}

	private void setBulletsVisible(bool visible)
	{
	}

	private void setHatredTarget(EntityBase _entity)
	{
	}

	private void createBulletsPerFrame(ref int curBulletCount, int bulletCountPerFrame)
	{
	}

	private void createBullets(int len)
	{
	}

	private BulletIceThunder createBullet(int bulletId, float curRadius, Vector3 bulletPos)
	{
		return null;
	}
}
