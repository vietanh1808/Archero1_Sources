using System;
using UnityEngine;

[Serializable]
public class PlinkoPathPoint
{
	[Header("下一目标点")]
	[SerializeField]
	public Vector2Int pos;

	[Header("方向")]
	[SerializeField]
	public PlinkoMoveType moveType;
}
