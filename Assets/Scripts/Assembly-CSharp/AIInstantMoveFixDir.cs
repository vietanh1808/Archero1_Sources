using UnityEngine;

public class AIInstantMoveFixDir : AIMoveToTarget
{
	protected bool startMove;

	protected override Vector3 moveDir => default;

	public AIInstantMoveFixDir(EntityBase entity)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override void updateDir()
	{
	}

	protected override void OnUpdate()
	{
	}

	protected override void OnEnd()
	{
	}

	protected virtual void onCollisionWallEvent()
	{
	}
}
