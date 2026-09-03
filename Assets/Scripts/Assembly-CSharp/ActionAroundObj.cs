using UnityEngine;

public class ActionAroundObj
{
	private const string UPDATE_NAME = "ActionAroundObj-Update";

	public Transform objectA;

	public Transform objectB;

	public float innerRadius;

	public float outerRadius;

	public float moveSpeed;

	public const float ButterFlyInnerRadius = 3f;

	public const float ButterFlyOuterRadius = 5f;

	public const float ButterFlySpeed = 2f;

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	private void onUpdate(float delta)
	{
	}
}
