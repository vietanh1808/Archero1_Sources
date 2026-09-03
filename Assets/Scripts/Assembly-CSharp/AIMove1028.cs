using UnityEngine;

public class AIMove1028 : AIMoveBase
{
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

	public AIMove1028(EntityBase entity)
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

	private void createReboundBullets(Collision o)
	{
	}

	protected override void OnEnd()
	{
	}
}
