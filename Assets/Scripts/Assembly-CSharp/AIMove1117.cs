using UnityEngine;

public class AIMove1117 : AIMove1032
{
	private float oldTime;

	private const int CALL_ID = 1825;

	private float aliveTime;

	public AIMove1117(EntityBase entity, float move2playerratio, int time, float speedratio)
		: base(null, 0f, 0, 0f)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override void OnEnd()
	{
	}

	protected override void CustomizeMoveEffect(GameObject moveEffect)
	{
	}

	private void onCollisionWall()
	{
	}
}
