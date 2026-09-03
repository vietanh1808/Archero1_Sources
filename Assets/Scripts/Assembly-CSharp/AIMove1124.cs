using UnityEngine;

public class AIMove1124 : AIMoveBase
{
	public const float REBOUND_FACTOR = 10f;

	private const string COLLIDER_RESOURCE = "Game/SkillPrefab/CollisionCtrl1007";

	private bool bRotateOver;

	private int reboundcount;

	private const int ReboundMaxCount = 3;

	protected float Move_NextX;

	protected float Move_NextY;

	private GameObject lastwall;

	private GameObject mCollision;

	private float mEndStartTime;

	private float mEndTime;

	private int mTimeID;

	private float angle;

	private float runSpeed;

	public AIMove1124(EntityBase entity)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	private void CreateCollisionCtrl()
	{
	}

	private void AIMoveStart()
	{
	}

	private void UpdateMoveData()
	{
	}

	private void AIMoving()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void CollisionEnter(Collision o)
	{
	}

	protected override void OnEnd()
	{
	}

	private void CreateBullets()
	{
	}
}
