using System;
using UnityEngine;

[Serializable]
public class DropCustomHpVO : CustomJsonActionVO
{
	public int Guid;

	public int Hp;

	public Vector3 DropPos;

	public int DropCount;
}
