using UnityEngine;

public class AIMove1110 : AIMoveToTarget
{
	private AnimationState runState;

	private bool isElite;

	protected override string LogTag => null;

	public AIMove1110(EntityBase entity)
		: base(null)
	{
	}

	protected override void onAfterInit()
	{
	}

	protected override void OnEnd()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void createIceBullet(Vector3 dir, float offset, float height)
	{
	}
}
