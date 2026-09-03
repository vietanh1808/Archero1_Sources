using UnityEngine;

public class PlinkoCylinderData
{
	public Vector2Int pos;

	public PlinkoCylinderData LeftTop;

	public PlinkoCylinderData RightTop;

	public PlinkoCylinderData Left;

	public PlinkoCylinderData Right;

	public PlinkoCylinderData LeftBottom;

	public PlinkoCylinderData RightBottom;

	public bool special;

	public PlinkoCylinderData(Vector2Int pos)
	{
	}

	public PlinkoCylinderData(int x, int y)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
