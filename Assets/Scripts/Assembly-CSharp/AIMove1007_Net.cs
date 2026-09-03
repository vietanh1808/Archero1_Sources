using UnityEngine;

public class AIMove1007_Net : AIMoveBase_Net
{
	private const string COLLIDER_RESOURCE = "Game/SkillPrefab/CollisionCtrl1007";

	protected float Move_NextX;

	protected float Move_NextY;

	private GameObject lastwall;

	private GameObject mCollision;

	public AIMove1007_Net(EntityBase entity)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	private void syncCmds(float Move_NextX, float Move_NextY)
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
