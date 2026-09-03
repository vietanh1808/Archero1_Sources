using UnityEngine;

public class AISineMove : AIMoveCollisionBase
{
	public const float frontDistance = 5f;

	public const float front_Circle_Radius = 2.5f;

	public const float frontDeltaDegrees = 3f;

	public const float frontSpeedFactor = 1f;

	private float frontDis;

	private Vector3 originalCenter;

	private Vector3 frontCircleCenterMovDir;

	private float frontCircleRadius;

	private Vector3 frontCircleCenter;

	private Vector3 frontCirclePoint;

	private float deltaDegrees;

	private float speedFactor;

	private Vector3 startDir;

	public AISineMove(EntityBase entity)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void Move()
	{
	}

	protected virtual void CheckIfEnd()
	{
	}
}
