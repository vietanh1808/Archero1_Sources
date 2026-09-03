using UnityEngine;

public class AIMove1065 : AIMove1008
{
	private float maxDuration;

	private float duration;

	private Vector3 targetPos;

	protected override int MoveEffectID => 0;

	public AIMove1065(EntityBase entity, float move2playerratio, int time, float speedratio)
		: base(null, 0f, 0, 0f)
	{
	}

	protected override void OnEnd()
	{
	}

	protected override void OnUpdate()
	{
	}
}
