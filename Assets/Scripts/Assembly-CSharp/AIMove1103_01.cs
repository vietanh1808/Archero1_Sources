using UnityEngine;

public class AIMove1103_01 : AIMove1103
{
	private Vector3 targetPos;

	private bool isColliding;

	protected override Vector3 moveDir => default;

	public AIMove1103_01(EntityBase entity)
		: base(null)
	{
	}

	protected override void onAfterInit()
	{
	}

	protected override void OnUpdate()
	{
	}

	protected override void OnEnd()
	{
	}

	private void onCollideWall()
	{
	}

	protected override bool isCloseEnough()
	{
		return false;
	}

	protected override void updateDir()
	{
	}
}
