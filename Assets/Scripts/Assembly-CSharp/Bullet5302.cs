using System.Collections.Generic;
using UnityEngine;

public class Bullet5302 : BulletBase
{
	private List<Transform> nodeList;

	private int timerId;

	private const int EFFECT_ID = 1014;

	private const int SKILL_ALONE_ID = 1014;

	private float m_fTime;

	private AutoDespawn mAutoDespawn;

	private float createdis;

	private Vector3 m_pos;

	private GameObject good;

	private ParticleSystem mParticle;

	private Vector3 lastPos;

	private bool isElite;

	public Transform nodes;

	protected int charId;

	private string updateName;

	private Vector3 posXZ;

	private const float EXPLOSION_RADIUS = 3f;

	private int ATTACK_TIMES;

	private const int MAX_BULLET = 6;

	private const int SMALL_FIRE_BALL_BULLET_ID = 5303;

	private const float radius = 1.5f;

	protected virtual bool IsNormalCharID => false;

	protected virtual float TriggerInterval => 0f;

	private Vector3 bulletPosXZ => default;

	public object DOTWeen { get; private set; }

	protected virtual int FIRE_BULLET_ID => 0;

	protected override void OnInit()
	{
	}

	private void trackTarget()
	{
	}

	protected override void UpdateProcess()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void onGotoNextRoom(RoomGenerateBase.Room obj)
	{
	}

	protected override void OnDeInit()
	{
	}

	private void onUpdate(float delta)
	{
	}

	private void CreateFireEffect()
	{
	}

	private void CreateOne(Vector3 pos)
	{
	}

	private void onTimer()
	{
	}

	protected virtual void CreateNormalCharFireBullet(BulletBase bulletBase)
	{
	}

	protected override void ShowDeadEffect()
	{
	}

	private void showExplodeEffect()
	{
	}

	private void createSmallFireBalls(Vector3 hitPos, Vector3 normal)
	{
	}

	private bool onHitWall(Collider collider)
	{
		return false;
	}
}
