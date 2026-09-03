using UnityEngine;

public class AIMove1118 : AIMove1032
{
	private bool isElite;

	private int hitCount;

	private int maxHitCount;

	private float oldTime;

	public AIMove1118(EntityBase entity, float move2playerratio, int time, float speedratio)
		: base(null, 0f, 0, 0f)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override void CustomizeMoveEffect(GameObject moveEffect)
	{
	}

	protected override void OnEnd()
	{
	}

	private void onCollisionWall()
	{
	}
}
