using UnityEngine;

public class AIMove1083 : AIMove1010
{
	public AIMove1083(EntityBase entity, float fardis)
		: base(null, 0f)
	{
	}

	protected override bool GetNear()
	{
		return false;
	}

	private Vector3 GetTargetPos()
	{
		return default;
	}

	protected override void UpdateMoveDirection()
	{
	}

	protected override void OnEnd()
	{
	}
}
