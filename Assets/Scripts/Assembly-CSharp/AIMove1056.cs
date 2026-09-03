using UnityEngine;

public class AIMove1056 : AIMove1008
{
	private float createdis;

	private int bulletId;

	private float currentdis;

	private float angle;

	public AIMove1056(EntityBase entity, int time, float move2playerratio, float createdis, float speedratio)
		: base(null, 0f, 0, 0f)
	{
	}

	public AIMove1056(EntityBase entity, int time, float move2playerratio, float createdis, float speedratio, int bulletId)
		: base(null, 0f, 0, 0f)
	{
	}

	protected override void OnInitBase()
	{
	}

	private void OnMoveBy(Vector3 move)
	{
	}

	private void CreateBullet()
	{
	}

	protected override void OnEnd()
	{
	}
}
