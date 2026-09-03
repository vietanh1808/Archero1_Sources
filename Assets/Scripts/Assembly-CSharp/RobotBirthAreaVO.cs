using System.Collections.Generic;
using UnityEngine;

public class RobotBirthAreaVO
{
	public Vector2Int LeftTop;

	public Vector2Int RightDown;

	public string Name;

	private int monsterCount;

	public List<Vector2Int> GridList => null;

	public void IncreaseMonster()
	{
	}

	public bool CanPlaceMonster()
	{
		return false;
	}
}
