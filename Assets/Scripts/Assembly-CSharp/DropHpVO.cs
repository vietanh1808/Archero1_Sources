using System;
using UnityEngine;

[Serializable]
public class DropHpVO : CustomJsonActionVO
{
	public Vector2 dropPos;

	public int dropCount;

	public int dropRadius;
}
