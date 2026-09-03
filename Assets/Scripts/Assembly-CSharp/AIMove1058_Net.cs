using UnityEngine;

public class AIMove1058_Net : AIMoveBase_Net
{
	private const string COLLIDER_RESOURCE = "Game/SkillPrefab/CollisionCtrl1007";

	protected float Move_NextX;

	protected float Move_NextY;

	private GameObject lastwall;

	private GameObject mCollision;

	private float attacktime;

	private float curenttime;

	public AIMove1058_Net(EntityBase entity, float attacktime)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void CreateCollisionCtrl()
	{
	}

	private void CollisionEnter(Collision o)
	{
	}

	protected override void OnEnd()
	{
	}
}
