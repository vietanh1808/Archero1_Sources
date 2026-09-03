using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PlinkoPathInfo
{
	public int id;

	public Vector2Int startPos;

	public List<PlinkoPathPoint> pathPoints;
}
