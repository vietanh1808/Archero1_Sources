using Dxx.Util;
using UnityEngine;

public class AIMove1087 : AIMoveBase
{
	private const string COLLIDER_RESOURCE = "Game/SkillPrefab/CollisionCtrl1007";

	private GameObject mCollision;

	private bool m_bStart;

	private SequencePool mSeqPool;

	private float m_fDistance;

	private Vector3 m_lastPos;

	private float Speed;

	private bool m_bShoot;

	private float m_fMaxDistance;

	private float m_fStartTime;

	private bool IsStart;

	public AIMove1087(EntityBase entity, float fMaxDistance = 15f, bool bShoot = true)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override void OnEnd()
	{
	}

	private void CreateBullets()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void MoveNormal()
	{
	}

	protected void AIMoveStart()
	{
	}

	private void AIMoving()
	{
	}

	protected void AIMoveEnd()
	{
	}

	private void UpdateDirection()
	{
	}

	private void CreateCollisionCtrl()
	{
	}

	private void DestroyCollision()
	{
	}

	private void CollisionEnter(Collision c)
	{
	}
}
