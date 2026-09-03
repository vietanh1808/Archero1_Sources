using System;
using UnityEngine;

[Serializable]
public class PlinkoMoveInfo
{
	public int ID;

	public float xOffSet;

	public float yOffSet;

	public float time;

	public int smoothness;

	public AnimationCurve Curve;

	[Range(0f, 360f)]
	public float angle;

	public PlinkoMoveInfo Clone()
	{
		return null;
	}
}
