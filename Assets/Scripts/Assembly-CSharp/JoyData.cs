using UnityEngine;

public struct JoyData
{
	public string name;

	public Vector3 direction;

	public Vector3 _moveDirection;

	public bool forceRotate;

	public float angle;

	public float length;

	public int type;

	public string action;

	public Vector3 MoveDirection => default;

	public void Revert()
	{
	}

	public void UpdateDirectionByAngle(float angle)
	{
	}
}
